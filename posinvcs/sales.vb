Imports MySql.Data.MySqlClient

Public Class sales
    Dim conn As New MySqlConnection("server=localhost;port=3307;user id=root;password=;database=posinv;")

    Private Sub SalesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesData()
        LoadTodaySales()
        LoadMonthlySales()
    End Sub

    Private Sub LoadSalesData()
        Try
            conn.Open()
            Dim query As String = "
                SELECT 
                    st.transaction_time AS 'Transaction Date',
                    st.receipt_number AS 'Receipt Number',
                    p.SKU AS 'SKU',
                    p.item_name AS 'Item Name',
                    sd.quantity AS 'Quantity',
                    sd.item_price AS 'Item Price',
                    (sd.quantity * sd.item_price) AS 'Subtotal'
                FROM sales_transactions st
                INNER JOIN sales_details sd ON st.transaction_id = sd.transaction_id
                INNER JOIN products p ON sd.item_id = p.id
                ORDER BY st.transaction_time DESC
            "

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvsales.DataSource = dt
            dgvsales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvsales.ReadOnly = True
            dgvsales.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Catch ex As Exception
            MessageBox.Show("Error loading sales data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadTodaySales()
        Dim total As Decimal = 0
        Try
            Using conn As New MySqlConnection("server=localhost;port=3307;user id=root;password=;database=posinv;")
                conn.Open()
                Dim query As String = "SELECT SUM(total) FROM sales_transactions WHERE DATE(transaction_time) = CURDATE()"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If Not IsDBNull(result) Then total = Convert.ToDecimal(result)
                End Using
            End Using
            todaysales.Text = "₱ " & total.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error loading today's sales: " & ex.Message)
        End Try
    End Sub

    Private Sub searchtb_TextChanged(sender As Object, e As EventArgs) Handles searchtb.TextChanged
        Dim dt As DataTable = CType(dgvsales.DataSource, DataTable)

        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter =
            String.Format("[SKU] LIKE '%{0}%' OR [Item Name] LIKE '%{0}%' OR [Receipt Number] LIKE '%{0}%'",
            searchtb.Text.Replace("'", "''"))
        End If
    End Sub

    Private Sub LoadMonthlySales()
        Dim total As Decimal = 0
        Try
            Using conn As New MySqlConnection("server=localhost;port=3307;user id=root;password=;database=posinv;")
                conn.Open()

                Dim query As String = "
                SELECT SUM(total) 
                FROM sales_transactions 
                WHERE MONTH(transaction_time) = MONTH(CURDATE())
                AND YEAR(transaction_time) = YEAR(CURDATE())
            "

                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If Not IsDBNull(result) Then total = Convert.ToDecimal(result)
                End Using
            End Using

            monthsales.Text = "₱ " & total.ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error loading monthly sales: " & ex.Message)
        End Try
    End Sub

    Private Sub FilterByDate()
        Try
            Dim fromDate As String = dtpFrom.Value.ToString("yyyy-MM-dd")
            Dim toDate As String = dtpTo.Value.ToString("yyyy-MM-dd")

            Dim query As String = "
            SELECT 
                st.transaction_time AS 'Transaction Date',
                st.receipt_number AS 'Receipt Number',
                p.SKU AS 'SKU',
                p.item_name AS 'Item Name',
                sd.quantity AS 'Quantity',
                sd.item_price AS 'Item Price',
                (sd.quantity * sd.item_price) AS 'Subtotal'
            FROM sales_transactions st
            INNER JOIN sales_details sd ON st.transaction_id = sd.transaction_id
            INNER JOIN products p ON sd.item_id = p.id
            WHERE DATE(st.transaction_time) BETWEEN @from AND @to
            ORDER BY st.transaction_time DESC
        "

            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@from", fromDate)
                da.SelectCommand.Parameters.AddWithValue("@to", toDate)

                Dim dt As New DataTable()
                da.Fill(dt)
                dgvsales.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering date: " & ex.Message)
        End Try
    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        Try
            Dim saveFile As New SaveFileDialog
            saveFile.Filter = "PDF Files|*.pdf"
            saveFile.Title = "Save Sales Report as PDF"

            If saveFile.ShowDialog = DialogResult.OK Then

                Dim pdfTable As New iTextSharp.text.pdf.PdfPTable(dgvsales.ColumnCount)


                For Each col As DataGridViewColumn In dgvsales.Columns
                    pdfTable.AddCell(New iTextSharp.text.Phrase(col.HeaderText))
                Next

                For Each row As DataGridViewRow In dgvsales.Rows
                    If Not row.IsNewRow Then
                        For Each cell As DataGridViewCell In row.Cells
                            pdfTable.AddCell(cell.Value?.ToString)
                        Next
                    End If
                Next

                Dim pdfDoc As New iTextSharp.text.Document
                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, New IO.FileStream(saveFile.FileName, IO.FileMode.Create))

                pdfDoc.Open()
                pdfDoc.Add(pdfTable)
                pdfDoc.Close()

                MessageBox.Show("PDF Exported Successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub excelbtn_Click(sender As Object, e As EventArgs) Handles excelbtn.Click
        Try
            Dim saveFile As New SaveFileDialog
            saveFile.Filter = "Excel Workbook|*.xlsx"
            saveFile.Title = "Export Sales Report to Excel"

            If saveFile.ShowDialog = DialogResult.OK Then

                Dim wb As New ClosedXML.Excel.XLWorkbook
                Dim dt = CType(dgvsales.DataSource, DataTable)

                wb.Worksheets.Add(dt, "Sales Report")
                wb.SaveAs(saveFile.FileName)

                MessageBox.Show("Excel File Exported Successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting Excel: " & ex.Message)
        End Try
    End Sub

    Private Sub FILTERBTN_Click(sender As Object, e As EventArgs) Handles FILTERBTN.Click
        FilterByDate()
    End Sub
End Class