Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Form1
    ' --- MySQL connection ---
    Private conn As MySqlConnection
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader

    ' --- Order list ---
    Private orderList As New DataTable()
    Private receiptText As String = ""
    Private currentReceiptNumber As String = ""

    ' --- Panel labels ---
    Private orderLabels As New Dictionary(Of String, Panel)
    Private selectedOrderSKU As String = ""
    Private selectedHeldReceipt As String = ""

    ' --- PrintDocument (declare WithEvents manually) ---

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;port=3307;user=root;password=;database=posinv")

        ' Initialize order table
        orderList.Columns.Add("SKU")
        orderList.Columns.Add("Item Name")
        orderList.Columns.Add("Qty", GetType(Integer))
        orderList.Columns.Add("Price", GetType(Decimal))
        orderList.Columns.Add("Subtotal", GetType(Decimal))

        ' Hide hold panel
        HoldPanel.Hide()

        ' Setup thermal paper for 58mm
        Dim receiptPaper As New PaperSize("Receipt58mm", 200, 10000)
        PrintDocument2.DefaultPageSettings.PaperSize = receiptPaper
        PrintDocument2.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        ' Generate receipt number
        GenerateReceiptNumber()

        ' Focus on SKU input
        SKUBarcodee.Focus()
    End Sub

    '==================== RECEIPT NUMBER GENERATOR ====================
    Private Sub GenerateReceiptNumber()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim lastSales As String = Convert.ToString(New MySqlCommand("SELECT receipt_number FROM sales_transactions ORDER BY transaction_id DESC LIMIT 1", conn).ExecuteScalar())
            Dim lastHeld As String = Convert.ToString(New MySqlCommand("SELECT receipt_number FROM held_transactions ORDER BY id DESC LIMIT 1", conn).ExecuteScalar())

            Dim num1 As Integer = 0, num2 As Integer = 0
            If Not String.IsNullOrEmpty(lastSales) Then Integer.TryParse(lastSales.Replace("RC", ""), num1)
            If Not String.IsNullOrEmpty(lastHeld) Then Integer.TryParse(lastHeld.Replace("RC", ""), num2)

            Dim nextNum As Integer = Math.Max(num1, num2) + 1
            currentReceiptNumber = "RC" & nextNum.ToString("000000")
            ReceiptNumber.Text = currentReceiptNumber
        Catch ex As Exception
            MessageBox.Show("Error generating receipt number: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    '==================== ADD ITEM ========================
    Private Sub AddItemToOrderList()
        If SKUBarcodee.Text.Trim() = "" Then
            MessageBox.Show("Please enter or scan a SKU first.", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim inputQty As Integer = 1
        If Integer.TryParse(Qty.Text, inputQty) = False OrElse inputQty <= 0 Then inputQty = 1

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            cmd = New MySqlCommand("SELECT item_name, price, qty FROM products WHERE SKU=@sku", conn)
            cmd.Parameters.AddWithValue("@sku", SKUBarcodee.Text.Trim())
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim sku As String = SKUBarcodee.Text.Trim()
                Dim itemName As String = reader("item_name").ToString()
                Dim unitPrice As Decimal = CDec(reader("price"))
                Dim stockQty As Integer = CInt(reader("qty"))
                reader.Close()
                conn.Close()

                ' Stock checks
                If stockQty <= 0 Then
                    MessageBox.Show("⚠️ This item is OUT OF STOCK!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    SKUBarcodee.Clear() : SKUBarcodee.Focus() : Return
                End If
                If inputQty > stockQty Then
                    MessageBox.Show("⚠️ Not enough stock! Available: " & stockQty, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    SKUBarcodee.Clear() : SKUBarcodee.Focus() : Return
                End If

                ' Update quantity if exists in orderList
                Dim found As Boolean = False
                For Each row As DataRow In orderList.Rows
                    If row("SKU").ToString() = sku Then
                        Dim newQty As Integer = CInt(row("Qty")) + inputQty
                        If newQty > stockQty Then
                            MessageBox.Show("⚠️ Not enough stock to add this quantity! Available: " & stockQty, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            SKUBarcodee.Clear() : SKUBarcodee.Focus() : Return
                        End If
                        row("Qty") = newQty
                        row("Subtotal") = CDec(row("Price")) * newQty
                        found = True
                        Exit For
                    End If
                Next

                If Not found Then
                    orderList.Rows.Add(sku, itemName, inputQty, unitPrice, unitPrice * inputQty)
                End If

                UpdateListPanel()
                SKUBarcodee.Clear() : Qty.Clear() : SKUBarcodee.Focus()
            Else
                reader.Close() : conn.Close()
                MessageBox.Show("SKU not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    '==================== UPDATE LISTPANEL =============================
    Private Sub UpdateListPanel()

        ListPanel.Controls.Clear()
        orderLabels.Clear()
        ListPanel.AutoScroll = True  ' Enable vertical scrolling
        ListPanel.HorizontalScroll.Enabled = False
        ListPanel.HorizontalScroll.Visible = False

        ' ========== SETTINGS ==========
        Dim headerFont As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim rowFont As New Font("Segoe UI", 10, FontStyle.Regular)

        Dim rowHeight As Integer = 50
        Dim headerHeight As Integer = 30

        ' Header background color (entire row)
        Dim headerBackColor As Color = Color.LightBlue  ' full row light blue

        ' Column headers
        Dim headers As String() = {"Item Name", "Qty", "Price", "Subtotal", "Actions"}

        ' Column widths
        Dim colWidths As Integer() = {150, 120, 100, 150, 100}

        Dim xPositions(colWidths.Length - 1) As Integer
        Dim runningX As Integer = 0
        For i As Integer = 0 To colWidths.Length - 1
            xPositions(i) = runningX
            runningX += colWidths(i)
        Next

        ' ===== HEADER PANEL (FULL WIDTH, LIGHT BLUE) =====
        Dim headerPanel As New Panel With {
        .Width = ListPanel.Width,
        .Height = headerHeight,
        .Location = New Point(0, 0),
        .BackColor = headerBackColor
    }

        ' Add header labels
        For i As Integer = 0 To headers.Length - 1
            Dim lbl As New Label With {
            .Text = headers(i),
            .Location = New Point(xPositions(i), 0),
            .Width = colWidths(i),
            .Height = headerHeight,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = headerFont,
            .BackColor = Color.Transparent
        }
            headerPanel.Controls.Add(lbl)
        Next

        ListPanel.Controls.Add(headerPanel)

        Dim yPos As Integer = headerHeight + 5

        ' ===== EACH ROW ITEM =====
        For Each row As DataRow In orderList.Rows
            Dim sku As String = row("SKU").ToString()
            Dim itemName As String = row("Item Name").ToString()
            Dim qty As Integer = CInt(row("Qty"))
            Dim price As Decimal = CDec(row("Price"))
            Dim subtotal As Decimal = CDec(row("Subtotal"))

            Dim itemPanel As New Panel With {
            .Width = ListPanel.Width - 4,
            .Height = rowHeight,
            .Location = New Point(2, yPos),
            .BorderStyle = BorderStyle.None,
            .Tag = sku
        }

            ' Item Name
            Dim nameLbl As New Label With {
            .Text = itemName,
            .Location = New Point(xPositions(0), 4),
            .Width = colWidths(0),
            .Height = rowHeight - 6,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = rowFont,
            .BackColor = Color.Transparent
        }

            ' Qty
            Dim qtyLbl As New Label With {
            .Text = qty.ToString(),
            .Location = New Point(xPositions(1), 4),
            .Width = 40,
            .Height = 22,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = rowFont,
            .BackColor = Color.Transparent
        }

            ' + BUTTON
            Dim plusBtn As New Button With {
            .Size = New Size(24, 20),
            .Location = New Point(xPositions(1) + 50, 2),
            .Tag = sku,
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.Transparent,
            .Text = "",
            .BackgroundImage = My.Resources.Plus_icon_icons_com_71848,
            .BackgroundImageLayout = ImageLayout.Stretch
        }

            ' - BUTTON
            Dim minusBtn As New Button With {
            .Size = New Size(24, 20),
            .Location = New Point(xPositions(1) + 50, 28),
            .Tag = sku,
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.Transparent,
            .Text = "",
            .BackgroundImage = My.Resources.minus_111123,
            .BackgroundImageLayout = ImageLayout.Stretch
        }

            ' Price
            Dim priceLbl As New Label With {
            .Text = "₱ " & price.ToString("0.00"),
            .Location = New Point(xPositions(2), 4),
            .Width = colWidths(2),
            .Height = rowHeight - 6,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = rowFont,
            .BackColor = Color.Transparent
        }

            ' Subtotal
            Dim subtotalLbl As New Label With {
            .Text = "₱ " & subtotal.ToString("0.00"),
            .Location = New Point(xPositions(3), 4),
            .Width = colWidths(3),
            .Height = rowHeight - 6,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = rowFont,
            .BackColor = Color.Transparent
        }

            ' Delete Button
            Dim deleteBtn As New Button With {
            .Size = New Size(30, 30),
            .Location = New Point(xPositions(4) + 30, 10),
            .Tag = sku,
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.Transparent,
            .Text = "",
            .BackgroundImage = My.Resources.trash_can_115312__2_,
            .BackgroundImageLayout = ImageLayout.Stretch
        }

            ' ADD TO PANEL
            itemPanel.Controls.AddRange({
            nameLbl, qtyLbl, plusBtn, minusBtn,
            priceLbl, subtotalLbl, deleteBtn
        })

            ' EVENTS
            AddHandler plusBtn.Click, AddressOf PlusBtn_Click
            AddHandler minusBtn.Click, AddressOf MinusBtn_Click
            AddHandler deleteBtn.Click, AddressOf DeleteBtn_Click

            ListPanel.Controls.Add(itemPanel)
            orderLabels.Add(sku, itemPanel)

            yPos += rowHeight + 2
        Next

        UpdateTotal()
    End Sub






    Private Sub PlusBtn_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim sku As String = btn.Tag.ToString()

        For Each row As DataRow In orderList.Rows
            If row("SKU").ToString() = sku Then
                row("Qty") = CInt(row("Qty")) + 1
                row("Subtotal") = CDec(row("Qty")) * CDec(row("Price"))
                Exit For
            End If
        Next

        UpdateListPanel()
    End Sub

    Private Sub MinusBtn_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim sku As String = btn.Tag.ToString()

        For Each row As DataRow In orderList.Rows
            If row("SKU").ToString() = sku Then
                Dim newQty As Integer = CInt(row("Qty")) - 1
                If newQty <= 0 Then
                    ' Remove if qty reaches 0
                    orderList.Rows.Remove(row)
                Else
                    row("Qty") = newQty
                    row("Subtotal") = CDec(newQty) * CDec(row("Price"))
                End If
                Exit For
            End If
        Next

        UpdateListPanel()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim sku As String = btn.Tag.ToString()

        For Each row As DataRow In orderList.Rows
            If row("SKU").ToString() = sku Then
                orderList.Rows.Remove(row)
                Exit For
            End If
        Next

        UpdateListPanel()
    End Sub

    '==================== SELECT ORDER ITEM ==========================
    Private Sub ListPanelItem_Click(sender As Object, e As EventArgs)
        Dim pnl As Panel = Nothing
        If TypeOf sender Is Panel Then
            pnl = CType(sender, Panel)
        ElseIf TypeOf sender Is Label Then
            pnl = CType(CType(sender, Label).Parent, Panel)
        End If

        If pnl IsNot Nothing Then
            For Each ctl As Control In ListPanel.Controls
                If TypeOf ctl Is Panel Then ctl.BackColor = Color.Transparent
            Next
            pnl.BackColor = Color.LightBlue
            selectedOrderSKU = pnl.Tag.ToString()
        End If
    End Sub

    '==================== UPDATE TOTAL ================================
    Private Sub UpdateTotal()
        Dim totalValue As Decimal = 0D
        For Each row As DataRow In orderList.Rows
            totalValue += CDec(row("Subtotal"))
        Next
        Total.Text = "₱ " & totalValue.ToString("0.00")
    End Sub

    '==================== SCAN ITEM ENTER KEY ==========================
    Private Sub SKUBarcodee_KeyDown(sender As Object, e As KeyEventArgs) Handles SKUBarcodee.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItemToOrderList()
            e.SuppressKeyPress = True
        End If
    End Sub
    '==================== MANUAL SUBMIT ==============================
    Private Sub SubmitItemButton_Click(sender As Object, e As EventArgs) Handles SubmitItemButton.Click
        AddItemToOrderList()
    End Sub

    '==================== BUILD RECEIPT ==============================
    Private Function BuildReceiptText(cashPaid As Decimal) As String
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine()
        sb.AppendLine()
        sb.AppendLine()

        sb.AppendLine("MARIA ATHENA MOTORCYCLE PARTS & ACCESSORIES")
        sb.AppendLine("       #408 Inocensio St. Pasay City")
        sb.AppendLine("-------------------------------------------")
        sb.AppendLine("Receipt No: " & currentReceiptNumber)
        sb.AppendLine("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
        sb.AppendLine("-------------------------------------------")

        ' Column headers (fixed width)
        sb.AppendLine(String.Format("{0,-14}{1,4}{2,10}{3,10}", "Item", "Qty", "Price", "SubTot"))
        sb.AppendLine("-------------------------------------------")

        Dim totalValue As Decimal = 0D
        For Each row As DataRow In orderList.Rows
            Dim itemName As String = Truncate(row("Item Name").ToString(), 14)
            Dim qty As Integer = CInt(row("Qty"))
            Dim price As Decimal = CDec(row("Price"))
            Dim subtotal As Decimal = CDec(row("Subtotal"))
            sb.AppendLine(String.Format("{0,-14}{1,4}{2,10:N2}{3,10:N2}", itemName, qty, price, subtotal))
            totalValue += subtotal
        Next

        Dim vatAmount As Decimal = Decimal.Round(totalValue * 12D / 112D, 2)
        Dim basePrice As Decimal = Decimal.Round(totalValue - vatAmount, 2)
        Dim change As Decimal = cashPaid - totalValue

        sb.AppendLine("-------------------------------------------")
        sb.AppendLine(String.Format("TOTAL (VAT EXCL): {0,19:N2}", basePrice))
        sb.AppendLine(String.Format("VAT(12%):         {0,19:N2}", vatAmount))
        sb.AppendLine(String.Format("GRAND TOTAL:      {0,19:N2}", totalValue))
        sb.AppendLine(String.Format("CASH:             {0,19:N2}", cashPaid))
        sb.AppendLine(String.Format("CHANGE:           {0,19:N2}", change))
        sb.AppendLine("===========================================")
        sb.AppendLine("If issues, contact us: 09154180402")
        sb.AppendLine("BIR NO#:               2312-12-514")
        sb.AppendLine("TIN NO#:         309-539-118-00000")
        sb.AppendLine("-------------------------------------------")
        sb.AppendLine("                THANK YOU!!")
        sb.AppendLine("           RIDE SAFE,COME AGAIN!")
        sb.AppendLine("-------------------------------------------")

        Return sb.ToString()
    End Function

    Private Function Truncate(text As String, maxLen As Integer) As String
        If text.Length <= maxLen Then Return text
        Return text.Substring(0, maxLen - 3) & "..."
    End Function

    '==================== PRINT ======================
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If orderList.Rows.Count = 0 Then
            MessageBox.Show("No items in the order list!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim cashPaid As Decimal
        Dim input As String = InputBox("Enter cash received:", "Cash Payment")

        If Not Decimal.TryParse(input, cashPaid) Then
            MessageBox.Show("Invalid cash amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim totalValue As Decimal = orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal")))
        If cashPaid < totalValue Then
            MessageBox.Show("Cash is not enough! Total: ₱" & totalValue.ToString("0.00"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        receiptText = BuildReceiptText(cashPaid)

        ' --- Show print preview ---
        Dim preview As New PrintPreviewDialog With {.Document = PrintDocument2, .WindowState = FormWindowState.Normal}
        preview.Width = 340
        preview.Height = 700
        preview.PrintPreviewControl.Zoom = 1.0
        preview.ShowDialog()

        ' Print document
        PrintDocument2.Print()

        ' Save transaction
        SaveTransaction(1)

        ' Clear order after print
        orderList.Clear()
        UpdateListPanel()
        Total.Clear()
        GenerateReceiptNumber()
    End Sub


    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        ' Fixed monospaced font
        Dim fontSize As Single = 5.5F ' good for 58mm paper
        Dim baseFont As New Font("Consolas", fontSize, FontStyle.Regular)

        ' Split receipt text into lines
        Dim lines() As String = receiptText.Split({vbCrLf, vbLf}, StringSplitOptions.None)

        ' Set margins
        Dim leftMargin As Single = 2
        Dim topMargin As Single = 2
        Dim y As Single = topMargin

        ' Draw each line with fixed font size
        For Each line As String In lines
            e.Graphics.DrawString(line, baseFont, Brushes.Black, leftMargin, y)
            y += baseFont.GetHeight(e.Graphics) + 1 ' small spacing between lines
        Next

        e.HasMorePages = False
    End Sub


    Private Sub SaveTransaction(userId As Integer)
        If orderList.Rows.Count = 0 Then Return
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "INSERT INTO sales_transactions (receipt_number, total) VALUES (@receipt_number, @total); SELECT LAST_INSERT_ID();"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@receipt_number", currentReceiptNumber)
            cmd.Parameters.AddWithValue("@total", CDec(orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal")))))
            Dim transactionId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            For Each row As DataRow In orderList.Rows
                Dim sku As String = row("SKU").ToString()
                Dim qtySold As Integer = CInt(row("Qty"))
                Dim price As Decimal = CDec(row("Price"))
                Dim subtotal As Decimal = CDec(row("Subtotal"))

                cmd = New MySqlCommand("INSERT INTO sales_details (transaction_id, item_id, quantity, item_price, subtotal) " &
                                       "VALUES (@tid, (SELECT id FROM products WHERE SKU=@sku LIMIT 1), @qty, @price, @subtotal)", conn)
                cmd.Parameters.AddWithValue("@tid", transactionId)
                cmd.Parameters.AddWithValue("@sku", sku)
                cmd.Parameters.AddWithValue("@qty", qtySold)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@subtotal", subtotal)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("UPDATE products SET qty = qty - @qtySold WHERE SKU=@sku", conn)
                cmd.Parameters.AddWithValue("@qtySold", qtySold)
                cmd.Parameters.AddWithValue("@sku", sku)
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show("Error saving transaction: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    '==================== CLEAR BUTTON ======================
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        orderList.Clear()
        UpdateListPanel()
        Total.Clear()
        SKUBarcodee.Focus()
        GenerateReceiptNumber()
    End Sub

    Private Sub Hold_Click(sender As Object, e As EventArgs) Handles Hold.Click
        If orderList.Rows.Count = 0 Then
            MessageBox.Show("No items to hold.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            For Each row As DataRow In orderList.Rows
                Dim query As String = "INSERT INTO held_transactions (receipt_number, sku, item_name, qty, price, subtotal, total) " &
                                  "VALUES (@receipt, @sku, @item_name, @qty, @price, @subtotal, @total)"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@receipt", currentReceiptNumber)
                cmd.Parameters.AddWithValue("@sku", row("SKU").ToString())
                cmd.Parameters.AddWithValue("@item_name", row("Item Name").ToString())
                cmd.Parameters.AddWithValue("@qty", CInt(row("Qty")))
                cmd.Parameters.AddWithValue("@price", CDec(row("Price")))
                cmd.Parameters.AddWithValue("@subtotal", CDec(row("Subtotal")))
                cmd.Parameters.AddWithValue("@total", CDec(orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal")))))
                cmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Transaction held successfully!", "Hold Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear order list
            orderList.Clear()
            UpdateListPanel()
            Total.Clear()
            GenerateReceiptNumber()

        Catch ex As Exception
            MessageBox.Show("Error holding transaction: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ReturnTransaction_Click(sender As Object, e As EventArgs) Handles ReturnTransaction.Click
        If DataGridView2.SelectedRows.Count = 0 Then
            HoldPanel.Visible = False
            Return
        End If

        ' Warn if current list has items
        If orderList.Rows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show(
            "The current order list is not empty. Do you want to clear it and restore the held transaction?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

            If result = DialogResult.No Then Return
            orderList.Clear()
            UpdateListPanel()
            Total.Clear()
        End If

        Dim selectedReceipt As String = DataGridView2.SelectedRows(0).Cells("receipt_number").Value.ToString()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT sku, item_name, qty, price, subtotal FROM held_transactions WHERE receipt_number=@receipt", conn)
            cmd.Parameters.AddWithValue("@receipt", selectedReceipt)
            reader = cmd.ExecuteReader()

            While reader.Read()
                orderList.Rows.Add(
                reader("sku").ToString(),
                reader("item_name").ToString(),
                CInt(reader("qty")),
                CDec(reader("price")),
                CDec(reader("subtotal"))
            )
            End While
            reader.Close()

            currentReceiptNumber = selectedReceipt
            ReceiptNumber.Text = selectedReceipt

            UpdateListPanel()
            Total.Text = "₱ " & orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal"))).ToString("0.00")

            ' Optionally delete restored transaction from held list
            cmd = New MySqlCommand("DELETE FROM held_transactions WHERE receipt_number=@receipt", conn)
            cmd.Parameters.AddWithValue("@receipt", selectedReceipt)
            cmd.ExecuteNonQuery()

            HoldPanel.Visible = False
            MessageBox.Show("Transaction restored successfully!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error restoring held transaction: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ViewHold_Click(sender As Object, e As EventArgs) Handles ViewHold.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT DISTINCT receipt_number, total, date_held FROM held_transactions ORDER BY date_held DESC"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DataGridView2.DataSource = dt

            HoldPanel.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error loading held transactions: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        HoldPanel.Show()
    End Sub
End Class
