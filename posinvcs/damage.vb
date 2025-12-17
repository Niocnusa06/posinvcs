Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class damage

    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalRecords As Integer = 0
    Private totalPages As Integer = 0
    Private searchText As String = ""
    Private statusFilter As String = "All"
    Private WithEvents printDoc As New PrintDocument()
    Private printRowIndex As Integer = 0
    Private columnWidths As New Dictionary(Of String, Integer)


    Public Sub LoadDamageItems()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()

                Dim whereClause As String = " WHERE 1=1 "

                If searchText <> "" Then
                    whereClause &= " AND (item_name LIKE @search OR category LIKE @search OR date_reported LIKE @search)  "
                End If

                If statusFilter <> "All" Then
                    whereClause &= " AND status=@status "
                End If


                Dim countQuery As String = "SELECT COUNT(*) FROM damage_items" & whereClause
                Using countCmd As New MySqlCommand(countQuery, conn)
                    If searchText <> "" Then
                        countCmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    End If
                    If statusFilter <> "All" Then
                        countCmd.Parameters.AddWithValue("@status", statusFilter)
                    End If
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using

                totalPages = Math.Ceiling(totalRecords / pageSize)
                Dim offset As Integer = (currentPage - 1) * pageSize


                Dim query As String =
                "SELECT * FROM damage_items " & whereClause &
                " ORDER BY date_reported DESC LIMIT @limit OFFSET @offset"

                Dim da As New MySqlDataAdapter(query, conn)
                If searchText <> "" Then
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchText & "%")
                End If
                If statusFilter <> "All" Then
                    da.SelectCommand.Parameters.AddWithValue("@status", statusFilter)
                End If
                da.SelectCommand.Parameters.AddWithValue("@limit", pageSize)
                da.SelectCommand.Parameters.AddWithValue("@offset", offset)

                Dim dt As New DataTable()
                da.Fill(dt)
                datagridview2.DataSource = dt
                UpdateReturnIcons()
            End Using


            lblPageInfo.Text = $"Page {currentPage} of {totalPages}"

        Catch ex As Exception
            MessageBox.Show("Error loading damage items: " & ex.Message)
        End Try
    End Sub

    Private Sub damage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        datagridview2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        If Not datagridview2.Columns.Contains("colReturn") Then
            Dim imgCol As New DataGridViewImageColumn()
            imgCol.Name = "colReturn"
            imgCol.HeaderText = "Action"
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            imgCol.DefaultCellStyle.NullValue = Nothing
            imgCol.Width = 60
            datagridview2.Columns.Add(imgCol)
        End If
        LoadDamageItems()

    End Sub


    Private Sub UpdateReturnIcons()

        If datagridview2.Rows.Count = 0 Then Exit Sub
        If Not datagridview2.Columns.Contains("colReturn") Then Exit Sub

        For Each row As DataGridViewRow In datagridview2.Rows
            If row.IsNewRow Then Continue For

            Dim status As String = row.Cells("status").Value.ToString()

            If status = "Returned" Then
                row.Cells("colReturn").Value = My.Resources.exchange2
                row.Cells("colReturn").Tag = "disabled"
                row.DefaultCellStyle.ForeColor = Color.Gray
            Else
                row.Cells("colReturn").Value = My.Resources.exchange
                row.Cells("colReturn").Tag = "active"
                row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next

    End Sub

    Private Sub datagridview2_DataBindingComplete(
        sender As Object,
        e As DataGridViewBindingCompleteEventArgs
    ) Handles datagridview2.DataBindingComplete

        UpdateReturnIcons()

    End Sub



    Private Sub ReturnDamageItem(damageID As Integer)
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE damage_items SET status='Returned', date_returned=NOW() WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", damageID)
                    cmd.ExecuteNonQuery()   
                End Using
            End Using

            MessageBox.Show("Item has been marked as RETURNED.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error returning item: " & ex.Message)
        End Try
    End Sub


    Private Sub datagridview2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview2.CellContentClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex <> datagridview2.Columns("colReturn").Index Then Exit Sub

        Dim cell = datagridview2.Rows(e.RowIndex).Cells("colReturn")


        If cell.Tag IsNot Nothing AndAlso cell.Tag.ToString() = "disabled" Then
            Exit Sub
        End If

        Dim itemID As Integer = datagridview2.Rows(e.RowIndex).Cells("id").Value
        Dim itemName As String = datagridview2.Rows(e.RowIndex).Cells("item_name").Value

        Dim ask = MessageBox.Show(
        $"Mark '{itemName}' as RETURNED to supplier?",
        "Confirm Return",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If ask = DialogResult.Yes Then
            ReturnDamageItem(itemID)
            LoadDamageItems()
        End If
    End Sub
    Private Sub datagridview2_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridview2.CellMouseMove

        If e.RowIndex < 0 OrElse e.ColumnIndex <> datagridview2.Columns("colReturn").Index Then
            datagridview2.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim cell = datagridview2.Rows(e.RowIndex).Cells("colReturn")

        If cell.Tag IsNot Nothing AndAlso cell.Tag.ToString() = "disabled" Then
            datagridview2.Cursor = Cursors.No
        Else
            datagridview2.Cursor = Cursors.Hand
        End If

    End Sub



    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        printRowIndex = 0
        printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"


        Dim downloads As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
        "Downloads"
    )

        Dim fileName As String = $"{Date.Now:yyyy-MM-dd}_DamageReport.pdf"
        printDoc.PrinterSettings.PrintFileName = Path.Combine(downloads, fileName)
        printDoc.PrinterSettings.PrintToFile = True

        printDoc.DefaultPageSettings.Landscape = True
        printDoc.Print()
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage

        Dim titleFont As New Font("Segoe UI", 18, FontStyle.Bold)
        Dim headerFont As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim bodyFont As New Font("Segoe UI", 10)

        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim y As Integer = topMargin

        ' ================= HEADER =================
        e.Graphics.DrawString(
        "MARIA ATHENA MOTORSHOP & ACCESSORIES",
        titleFont,
        Brushes.Black,
        leftMargin,
        y
    )

        y += 35
        e.Graphics.DrawString(
        "DAMAGED ITEMS REPORT",
        New Font("Segoe UI", 12, FontStyle.Bold),
        Brushes.Black,
        leftMargin,
        y
    )

        y += 25
        e.Graphics.DrawString(
        "Date Generated: " & Date.Now.ToString("MMMM dd, yyyy hh:mm tt"),
        bodyFont,
        Brushes.Gray,
        leftMargin,
        y
    )

        y += 35

        ' ================= COLUMN WIDTHS =================
        columnWidths.Clear()
        columnWidths("id") = 40
        columnWidths("SKU") = 90
        columnWidths("item_name") = 240
        columnWidths("category") = 200
        columnWidths("price") = 80
        columnWidths("damage_qty") = 90
        columnWidths("unit_type") = 80

        ' ================= TABLE HEADER =================
        Dim x As Integer = leftMargin
        For Each col As DataGridViewColumn In datagridview2.Columns
            If Not columnWidths.ContainsKey(col.Name) Then Continue For
            e.Graphics.FillRectangle(Brushes.LightGray, x, y, columnWidths(col.Name), 28)
            e.Graphics.DrawRectangle(Pens.Black, x, y, columnWidths(col.Name), 28)
            e.Graphics.DrawString(col.HeaderText, headerFont, Brushes.Black, x + 4, y + 6)
            x += columnWidths(col.Name)
        Next
        y += 28

        ' ================= TABLE ROWS =================
        While printRowIndex < datagridview2.Rows.Count
            Dim row = datagridview2.Rows(printRowIndex)
            x = leftMargin
            Dim rowHeight As Integer = 28

            For Each col As DataGridViewColumn In datagridview2.Columns
                If Not columnWidths.ContainsKey(col.Name) Then Continue For
                Dim text As String = row.Cells(col.Name).Value?.ToString()
                Dim size = e.Graphics.MeasureString(text, bodyFont, columnWidths(col.Name))
                rowHeight = Math.Max(rowHeight, CInt(size.Height) + 10)
            Next


            If y + rowHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If


            For Each col As DataGridViewColumn In datagridview2.Columns
                If Not columnWidths.ContainsKey(col.Name) Then Continue For
                Dim text As String = row.Cells(col.Name).Value?.ToString()

                Dim rect As New Rectangle(x, y, columnWidths(col.Name), rowHeight)
                e.Graphics.DrawRectangle(Pens.Black, rect)
                e.Graphics.DrawString(text, bodyFont, Brushes.Black, rect)

                x += columnWidths(col.Name)
            Next

            y += rowHeight
            printRowIndex += 1
        End While

        e.HasMorePages = False
    End Sub



    Private Sub cmbShowEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShowEntries.SelectedIndexChanged
        If cmbShowEntries.Text = "All" Then
            pageSize = 999999
        Else
            pageSize = Convert.ToInt32(cmbShowEntries.Text)
        End If
        currentPage = 1
        LoadDamageItems()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchText = txtSearch.Text.Trim()
        currentPage = 1
        LoadDamageItems()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadDamageItems()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            LoadDamageItems()
        End If
    End Sub


    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        statusFilter = cmbStatus.Text
        currentPage = 1
        LoadDamageItems()
    End Sub
    Private Sub printDoc_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles printDoc.EndPrint

        MessageBox.Show(
        "Report successfully exported!" & vbCrLf & vbCrLf &
        "Please check your Downloads folder.",
        "Export Complete",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )

    End Sub

End Class
