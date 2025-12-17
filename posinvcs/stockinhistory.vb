Imports MySql.Data.MySqlClient

Public Class stockinhistory

    Private pageSize As Integer = 0
    Private currentPage As Integer = 1
    Private totalRecords As Integer = 0
    Private isFormLoading As Boolean = True


    Private Sub StockInHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isFormLoading = True
        cmbEntries.SelectedIndex = -1
        cmbQuickFilter.SelectedItem = "All"
        pageSize = 0
        currentPage = 1
        LoadStockInHistory()
        isFormLoading = False
    End Sub


    Public Sub LoadStockInHistory(Optional searchText As String = "")
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()


            Dim countQuery As String = "
            SELECT COUNT(*) 
            FROM stockin_history sh
            LEFT JOIN products p ON sh.SKU = p.SKU
            WHERE (@search = '' OR sh.SKU LIKE @searchLike OR p.item_name LIKE @searchLike)
            " & GetQuickFilterCondition()

            Using countCmd As New MySqlCommand(countQuery, conn)
                countCmd.Parameters.AddWithValue("@search", searchText)
                countCmd.Parameters.AddWithValue("@searchLike", "%" & searchText & "%")
                totalRecords = Convert.ToInt32(countCmd.ExecuteScalar())
            End Using

            Dim offset As Integer = 0
            If pageSize > 0 Then
                offset = (currentPage - 1) * pageSize
            End If



            Dim query As String = "
                SELECT 
                    sh.SKU,
                    p.item_name,
                    sh.qty_added,
                    sh.date_in
                FROM stockin_history sh
                LEFT JOIN products p ON sh.SKU = p.SKU
                WHERE (@search = '' OR sh.SKU LIKE @searchLike OR p.item_name LIKE @searchLike)
                " & GetQuickFilterCondition() & "
                ORDER BY sh.date_in DESC
            "

            ' APPLY LIMIT ONLY IF pageSize > 0
            If pageSize > 0 Then
                query &= " LIMIT @limit OFFSET @offset "
            End If


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", searchText)
                cmd.Parameters.AddWithValue("@searchLike", "%" & searchText & "%")

                If pageSize > 0 Then
                    cmd.Parameters.AddWithValue("@limit", pageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                datagridview1.DataSource = table
            End Using

            UpdateEntriesLabel()
                UpdateButtons()
            End Using
    End Sub



    Private Sub searchtb_TextChanged(sender As Object, e As EventArgs) Handles searchtb.TextChanged
        currentPage = 1
        LoadStockInHistory(searchtb.Text.Trim())
    End Sub

    Private Function GetQuickFilterCondition() As String
        If isFormLoading Then Return ""

        Select Case cmbQuickFilter.Text
            Case "Today"
                Return " AND DATE(sh.date_in) = CURDATE() "
            Case "This Week"
                Return " AND YEARWEEK(sh.date_in, 1) = YEARWEEK(CURDATE(), 1) "
            Case "This Month"
                Return " AND MONTH(sh.date_in) = MONTH(CURDATE()) 
                     AND YEAR(sh.date_in) = YEAR(CURDATE()) "
            Case Else
                Return ""
        End Select
    End Function

    Private Sub cmbQuickFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuickFilter.SelectedIndexChanged
        If isFormLoading Then Exit Sub
        currentPage = 1
        LoadStockInHistory(searchtb.Text.Trim())
    End Sub

    Private Sub cmbEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEntries.SelectedIndexChanged
        If isFormLoading Then Exit Sub

        pageSize = Convert.ToInt32(cmbEntries.Text)
        currentPage = 1
        LoadStockInHistory(searchtb.Text.Trim())
    End Sub


    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadStockInHistory(searchtb.Text.Trim())
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage * pageSize < totalRecords Then
            currentPage += 1
            LoadStockInHistory(searchtb.Text.Trim())
        End If
    End Sub
    Private Sub UpdateEntriesLabel()
        If pageSize = 0 Then
            lblEntriesInfo.Text = $"Showing ALL {totalRecords} entries"
            Exit Sub
        End If

        Dim startRecord As Integer = ((currentPage - 1) * pageSize) + 1
        Dim endRecord As Integer = Math.Min(currentPage * pageSize, totalRecords)

        lblEntriesInfo.Text = $"Showing {startRecord} to {endRecord} of {totalRecords} entries"
    End Sub


    Private Sub UpdateButtons()
        If pageSize = 0 Then
            btnPrev.Enabled = False
            btnNext.Enabled = False
            Exit Sub
        End If

        btnPrev.Enabled = currentPage > 1
        btnNext.Enabled = (currentPage * pageSize) < totalRecords
    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        Dim downloadsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\"
        Dim fileName As String = Date.Now.ToString("yyyy-MM-dd") & "_stockinreport.txt"
        Dim fullPath As String = IO.Path.Combine(downloadsPath, fileName)

        Using writer As New IO.StreamWriter(fullPath)
            writer.WriteLine("STOCK-IN HISTORY REPORT")
            writer.WriteLine("Generated on: " & Date.Now.ToString("yyyy-MM-dd HH:mm"))
            writer.WriteLine(New String("-"c, 50))

            For Each row As DataGridViewRow In datagridview1.Rows
                If Not row.IsNewRow Then
                    writer.WriteLine(
                    row.Cells("SKU").Value & " | " &
                    row.Cells("item_name").Value & " | " &
                    row.Cells("qty_added").Value & " | " &
                    row.Cells("date_in").Value
                )
                End If
            Next
        End Using

        MessageBox.Show(
        "Report successfully generated." & vbCrLf &
        "Please check your Downloads folder.",
        "Success",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )
    End Sub

End Class