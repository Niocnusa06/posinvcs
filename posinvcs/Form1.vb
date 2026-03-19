Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Form1


    Private selectedIndex As Integer = -1


    Public LoggedInUsername As String
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

        Me.KeyPreview = True

        conn = New MySqlConnection("server=localhost;user=root;password=;database=posinv")

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

        lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        UpdateTime()
        tmrClock.Start()
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
        ' --- Clear and reset panel ---
        ListPanel.SuspendLayout()
        ListPanel.Controls.Clear()
        orderLabels.Clear()
        ListPanel.AutoScroll = True
        ListPanel.HorizontalScroll.Enabled = False
        ListPanel.HorizontalScroll.Visible = False

        Dim headerFont As New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Dim rowFont As New Font("Segoe UI", 9.5F, FontStyle.Regular)

        Dim headerHeight As Integer = 32
        Dim rowHeight As Integer = 52

        ' ===== Dynamic column widths =====
        Dim totalWidth As Integer = ListPanel.ClientSize.Width - 20
        Dim colItem As Integer = totalWidth * 0.4
        Dim colQty As Integer = totalWidth * 0.2
        Dim colPrice As Integer = totalWidth * 0.15
        Dim colSub As Integer = totalWidth * 0.15
        Dim colAct As Integer = totalWidth * 0.1

        Dim xItem = 0
        Dim xQty = xItem + colItem
        Dim xPrice = xQty + colQty
        Dim xSub = xPrice + colPrice
        Dim xAct = xSub + colSub

        ' ===== Header =====
        Dim headerPanel As New Panel With {
        .Dock = DockStyle.Top,
        .Height = headerHeight,
        .BackColor = Color.FromArgb(224, 242, 254)
    }

        AddHeader(headerPanel, "Item", xItem, colItem, headerFont, ContentAlignment.MiddleLeft)
        AddHeader(headerPanel, "Qty", xQty, colQty, headerFont, ContentAlignment.MiddleCenter)
        AddHeader(headerPanel, "Price", xPrice, colPrice, headerFont, ContentAlignment.MiddleRight)
        AddHeader(headerPanel, "Subtotal", xSub, colSub, headerFont, ContentAlignment.MiddleRight)
        AddHeader(headerPanel, "Action", xAct, colAct, headerFont, ContentAlignment.MiddleCenter)

        ListPanel.Controls.Add(headerPanel)

        Dim yPos As Integer = headerHeight + 4

        ' ===== Rows =====
        For Each row As DataRow In orderList.Rows
            Dim sku = row("SKU").ToString()

            Dim itemPanel As New Panel With {
            .Width = totalWidth,
            .Height = rowHeight,
            .Location = New Point(8, yPos),
            .BackColor = If(orderList.Rows.IndexOf(row) = selectedIndex,
                            Color.FromArgb(191, 219, 254),
                            Color.FromArgb(243, 244, 246)),
            .Tag = sku
        }

            ' Separator
            Dim separator As New Panel With {
            .Dock = DockStyle.Bottom,
            .Height = 1,
            .BackColor = Color.FromArgb(229, 231, 235)
        }
            itemPanel.Controls.Add(separator)
            separator.BringToFront()

            ' Item Name
            itemPanel.Controls.Add(CreateLabel(row("Item Name").ToString(), xItem + 6, colItem - 12, rowFont, ContentAlignment.MiddleLeft))

            ' Qty Panel with plus/minus buttons
            Dim qtyPanel As New Panel With {
            .Size = New Size(colQty - 16, 36),
            .Location = New Point(xQty + 8, 8),
            .BackColor = Color.Transparent
        }

            Dim plusBtn As New Button With {
            .Size = New Size(32, 32),
            .Location = New Point(0, 2),
            .Tag = sku,
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.FromArgb(34, 197, 94),
            .ForeColor = Color.White,
            .Font = New Font("Segoe MDL2 Assets", 14),
            .Text = ChrW(&HE109),
            .Cursor = Cursors.Hand
        }
            plusBtn.FlatAppearance.BorderSize = 0
            AddHandler plusBtn.Click, AddressOf PlusBtn_Click

            Dim qtyLbl As New Label With {
            .Size = New Size(40, 32),
            .Location = New Point((qtyPanel.Width - 40) \ 2, 2),
            .Text = row("Qty").ToString(),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = Color.White,
            .ForeColor = Color.Black,
            .BorderStyle = BorderStyle.FixedSingle,
            .AutoSize = False
        }

            Dim minusBtn As New Button With {
            .Size = New Size(32, 32),
            .Location = New Point(qtyPanel.Width - 32, 2),
            .Tag = sku,
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.FromArgb(239, 68, 68),
            .ForeColor = Color.White,
            .Font = New Font("Segoe MDL2 Assets", 14),
            .Text = ChrW(&HE108),
            .Cursor = Cursors.Hand
        }
            minusBtn.FlatAppearance.BorderSize = 0
            AddHandler minusBtn.Click, AddressOf MinusBtn_Click

            qtyPanel.Controls.Add(plusBtn)
            qtyPanel.Controls.Add(qtyLbl)
            qtyPanel.Controls.Add(minusBtn)
            itemPanel.Controls.Add(qtyPanel)
            plusBtn.BringToFront()
            minusBtn.BringToFront()

            ' Price & Subtotal
            itemPanel.Controls.Add(CreateLabel("₱ " & CDec(row("Price")).ToString("N2"), xPrice, colPrice, rowFont, ContentAlignment.MiddleRight))
            itemPanel.Controls.Add(CreateLabel("₱ " & CDec(row("Subtotal")).ToString("N2"), xSub, colSub, rowFont, ContentAlignment.MiddleRight))

            ' Delete button
            Dim delBtn As New Button With {
            .Size = New Size(36, 36),
            .Location = New Point(xAct + (colAct - 36) \ 2, 8),
            .Tag = sku,
            .FlatStyle = FlatStyle.Flat,
            .Image = New Bitmap(My.Resources.trashcan, New Size(25, 25)),
            .ImageAlign = ContentAlignment.MiddleCenter,
            .Cursor = Cursors.Hand
        }
            delBtn.FlatAppearance.BorderSize = 0
            AddHandler delBtn.Click, AddressOf DeleteBtn_Click
            itemPanel.Controls.Add(delBtn)

            ListPanel.Controls.Add(itemPanel)
            orderLabels.Add(sku, itemPanel)

            yPos += rowHeight + 2
        Next

        ' ===== VAT / TOTAL FOOTER =====
        Dim vatRate As Decimal = 0.12D
        Dim totalValue As Decimal = 0D
        Dim discountValue As Decimal = 0D

        If DiscountTextBox.Text <> "" Then Decimal.TryParse(DiscountTextBox.Text.Trim(), discountValue)

        For Each row As DataRow In orderList.Rows
            totalValue += CDec(row("Subtotal"))
        Next

        Dim vatAmount As Decimal = Decimal.Round(totalValue * vatRate / (1 + vatRate), 2)
        Dim basePrice As Decimal = Decimal.Round(totalValue - vatAmount, 2)
        Dim totalWithDiscount As Decimal = totalValue - discountValue

        ' --- Update Total TextBox ---
        Total.Text = "₱ " & totalWithDiscount.ToString("0.00")

        Dim vatPanel As New Panel With {
        .Width = totalWidth,
        .Height = 70,
        .Location = New Point(3, 662),
        .BackColor = Color.FromArgb(224, 242, 254)
    }

        vatPanel.Controls.Add(CreateLabel("VAT Sales: ₱" & basePrice.ToString("N2"), 8, totalWidth, rowFont, ContentAlignment.MiddleLeft))
        vatPanel.Controls.Add(CreateLabel("VAT (12%): ₱" & vatAmount.ToString("N2"), 8, totalWidth, rowFont, ContentAlignment.MiddleLeft))
        vatPanel.Controls.Add(CreateLabel("TOTAL: ₱" & totalWithDiscount.ToString("N2"), 8, totalWidth, New Font("Segoe UI", 10, FontStyle.Bold), ContentAlignment.MiddleLeft))

        ListPanel.Controls.Add(vatPanel)

        ListPanel.ResumeLayout()
    End Sub
    Private Function CreateLabel(text As String, x As Integer, w As Integer,
                             f As Font, align As ContentAlignment) As Label
        Return New Label With {
        .Text = text,
        .Location = New Point(x, 0),
        .Size = New Size(w, 52),
        .Font = f,
        .TextAlign = align
    }
    End Function

    Private Function CreateIconButton(
    text As String,
    x As Integer,
    y As Integer,
    tag As String,
    handler As EventHandler,
    bgColor As Color
) As Button

        Dim btn As New Button With {
        .Size = New Size(36, 36),
        .Location = New Point(x, y),
        .Text = text,
        .Tag = tag,
        .BackColor = bgColor,
        .ForeColor = Color.White,
        .FlatStyle = FlatStyle.Flat,
        .Font = New Font("Segoe UI", 16, FontStyle.Bold),
        .TextAlign = ContentAlignment.MiddleCenter,
        .Cursor = Cursors.Hand
    }

        btn.FlatAppearance.BorderSize = 0
        AddHandler btn.Click, handler

        Return btn
    End Function





    Private Sub AddHeader(p As Panel, text As String, x As Integer, w As Integer,
                      f As Font, align As ContentAlignment)
        p.Controls.Add(New Label With {
        .Text = text,
        .Location = New Point(x, 0),
        .Size = New Size(w, p.Height),
        .Font = f,
        .TextAlign = align
    })
    End Sub






    Private Sub PlusBtn_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim sku As String = btn.Tag.ToString()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Get available stock
            Dim stockCmd As New MySqlCommand(
            "SELECT qty FROM products WHERE SKU=@sku", conn)
            stockCmd.Parameters.AddWithValue("@sku", sku)

            Dim stockQty As Integer = Convert.ToInt32(stockCmd.ExecuteScalar())

            For Each row As DataRow In orderList.Rows
                If row("SKU").ToString() = sku Then

                    Dim currentQty As Integer = CInt(row("Qty"))


                    If currentQty >= stockQty Then
                        MessageBox.Show(
                        "⚠️ Cannot add more items." & vbCrLf &
                        "Available stock: " & stockQty,
                        "Insufficient Stock",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )
                        Exit Sub
                    End If


                    row("Qty") = currentQty + 1
                    row("Subtotal") = CDec(row("Qty")) * CDec(row("Price"))
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error checking stock: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

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
        Dim subtotal As Decimal = orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal")))

        Dim discount As Decimal = 0D
        Decimal.TryParse(DiscountTextBox.Text, discount)

        If discount > subtotal Then discount = subtotal

        Dim finalTotal As Decimal = subtotal - discount

        Total.Text = "₱ " & finalTotal.ToString("0.00")
    End Sub


    '==================== SCAN ITEM ENTER KEY ==========================
    Private Sub SKUBarcodee_KeyDown(sender As Object, e As KeyEventArgs) Handles SKUBarcodee.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItemToOrderList()
            e.SuppressKeyPress = True
            SKUBarcodee.Clear()
            SKUBarcodee.Focus()
        End If
    End Sub
    '==================== MANUAL SUBMIT ==============================
    Private Sub SubmitItemButton_Click(sender As Object, e As EventArgs) Handles SubmitItemButton.Click
        AddItemToOrderList()
    End Sub
    Private Function BuildReceiptText(cashPaid As Decimal, cashierName As String) As String
        Dim sb As New System.Text.StringBuilder()
        Const W As Integer = 29

        sb.AppendLine(CenterText("MARIA ATHENA MOTORCYCLE PARTS", W))
        sb.AppendLine(CenterText("& ACCESSORIES", W))
        sb.AppendLine(CenterText("#408 Inocensio St., Pasay", W))
        sb.AppendLine(New String("-"c, W))

        sb.AppendLine("Receipt #: " & currentReceiptNumber)
        sb.AppendLine("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
        sb.AppendLine("Cashier: " & cashierName.ToUpper())

        sb.AppendLine(New String("-"c, W))

        sb.AppendLine("ITEM           QTY     AMT")
        sb.AppendLine(New String("-"c, W))

        Dim totalValue As Decimal = 0D

        For Each row As DataRow In orderList.Rows
            Dim name As String = Truncate(row("Item Name").ToString(), 11)
            Dim qty As Integer = CInt(row("Qty"))
            Dim subtotal As Decimal = CDec(row("Subtotal"))

            Dim leftPart As String = String.Format("{0,-11} {1,3}", name, qty)

            sb.AppendLine(leftPart.PadRight(W - subtotal.ToString("0.00").Length) &
                  subtotal.ToString("0.00"))

            totalValue += subtotal
        Next


        Dim vatAmount As Decimal = Decimal.Round(totalValue * 12D / 112D, 2)
        Dim basePrice As Decimal = Decimal.Round(totalValue - vatAmount, 2)
        Dim change As Decimal = cashPaid + DiscountTextBox.Text.Trim() - totalValue
        Dim discount As Decimal = DiscountTextBox.Text.Trim()

        sb.AppendLine(New String("-"c, W))
        sb.AppendLine(FormatLine("+ VAT Sales", basePrice, W))
        sb.AppendLine(FormatLine("- VAT (12%)", vatAmount, W))
        sb.AppendLine(New String("-"c, W))
        sb.AppendLine(FormatLine("TOTAL", totalValue, W))
        sb.AppendLine(FormatLine("discount", discount, W))
        sb.AppendLine(FormatLine("Cash", cashPaid, W))
        sb.AppendLine(FormatLine("Change", change, W))

        sb.AppendLine(New String("="c, W))
        sb.AppendLine("BIR No: 2312-12-514")
        sb.AppendLine("TIN No: 309-539-118")
        sb.AppendLine("Contact: 0915-418-0402")
        sb.AppendLine(New String("-"c, W))

        sb.AppendLine(CenterText("THANK YOU!", W))
        sb.AppendLine(CenterText("RIDE SAFE, COME AGAIN!", W))

        Return sb.ToString()
    End Function

    Private Function MoneyLine(leftText As String, amount As Decimal) As String
        Const W As Integer = 29
        Dim amt As String = amount.ToString("0.00")
        Return leftText.PadRight(W - amt.Length) & amt
    End Function

    Private Function CenterText(text As String, width As Integer) As String
        If text.Length >= width Then Return text
        Dim padding As Integer = (width - text.Length) \ 2
        Return New String(" "c, padding) & text
    End Function
    Private Function FormatLine(label As String, value As Decimal, width As Integer) As String
        Dim amount As String = value.ToString("0.00")
        Return label.PadRight(width - amount.Length) & amount
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

        Dim totalValue As Decimal =
    orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal")))

        Cash.Clear()
        CashIn.Visible = True
        Cash.Focus()
    End Sub


    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage

        Dim baseFont As New Font("Consolas", 8.0F, FontStyle.Regular)



        Dim lines() As String = receiptText.Split({vbCrLf, vbLf}, StringSplitOptions.None)


        Dim leftMargin As Single = 2
        Dim topMargin As Single = 2
        Dim y As Single = topMargin

        For Each line As String In lines
            e.Graphics.DrawString(line, baseFont, Brushes.Black, leftMargin, y)
            y += baseFont.GetHeight(e.Graphics)
        Next

        e.HasMorePages = False
    End Sub


    Private Sub SaveTransaction(userId As Integer)
        If orderList.Rows.Count = 0 Then Return
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "
INSERT INTO sales_transactions 
(receipt_number, total, discount) 
VALUES (@receipt_number, @total, @discount); 
SELECT LAST_INSERT_ID();"
            cmd = New MySqlCommand(query, conn)
            Dim subtotal As Decimal = orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal")))

            Dim discount As Decimal = 0D
            Decimal.TryParse(DiscountTextBox.Text, discount)

            If discount > subtotal Then discount = subtotal

            Dim totalValue As Decimal = subtotal - discount

            cmd.Parameters.AddWithValue("@receipt_number", currentReceiptNumber)
            cmd.Parameters.AddWithValue("@total", totalValue)
            cmd.Parameters.AddWithValue("@discount", discount)
            Dim transactionId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            For Each row As DataRow In orderList.Rows
                Dim sku As String = row("SKU").ToString()
                Dim qtySold As Integer = CInt(row("Qty"))
                Dim price As Decimal = CDec(row("Price"))
                Dim itemSubtotal As Decimal = CDec(row("Subtotal"))

                cmd = New MySqlCommand("INSERT INTO sales_details (transaction_id, item_id, quantity, item_price, subtotal) " &
                                       "VALUES (@tid, (SELECT id FROM products WHERE SKU=@sku LIMIT 1), @qty, @price, @subtotal)", conn)
                cmd.Parameters.AddWithValue("@tid", transactionId)
                cmd.Parameters.AddWithValue("@sku", sku)
                cmd.Parameters.AddWithValue("@qty", qtySold)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@subtotal", itemSubtotal)
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


        Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)


        If selectedRow.IsNewRow OrElse
        selectedRow.Cells("receipt_number").Value Is Nothing Then
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

    Private Sub HoldPanel_Paint(sender As Object, e As PaintEventArgs) Handles HoldPanel.Paint

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        UpdateTime()
    End Sub

    Private Sub UpdateTime()
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Function GetCashierName(username As String) As String
        Dim name As String = ""

        Using con As MySqlConnection = DBConnection.GetConnection()
            con.Open()

            Using cmd As New MySqlCommand(
            "SELECT username FROM user WHERE username=@u", con)

                cmd.Parameters.AddWithValue("@u", username)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    name = result.ToString()
                End If
            End Using
        End Using

        Return name
    End Function




    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim result As DialogResult = MessageBox.Show(
           "Are you sure you want to logout?",
           "Confirm Logout",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub ShowItemNameBySKU()
        ' Clear if empty
        If SKUBarcodee.Text.Trim() = "" Then
            ItemName.Text = ""
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT item_name FROM products WHERE SKU=@sku LIMIT 1"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@sku", SKUBarcodee.Text.Trim())

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                ItemName.Text = result.ToString()
            Else
                ItemName.Text = "Item not found"
            End If

        Catch ex As Exception
            ItemName.Text = ""
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub






    Private Sub UpdatePriceFromSKU()
        ' Clear price if SKU is empty
        If SKUBarcodee.Text.Trim() = "" Then
            Price.Text = ""
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim cmd As New MySqlCommand(
            "SELECT price FROM products WHERE SKU=@sku LIMIT 1", conn)

            cmd.Parameters.AddWithValue("@sku", SKUBarcodee.Text.Trim())

            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Price.Text = "₱ " & CDec(result).ToString("0.00")
            Else
                Price.Text = ""
            End If

        Catch
            Price.Text = ""
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub






    Private Sub UpdateSubTotal()
        If Price.Text = "" Then
            SubTotal.Text = ""
            Exit Sub
        End If

        Dim priceValue = Val(Price.Text.Replace("₱", ""))

        ' If Qty is empty, subtotal = price
        If Qty.Text.Trim() = "" Then
            SubTotal.Text = "₱ " & priceValue.ToString("0.00")
        Else
            SubTotal.Text = "₱ " & (priceValue * Val(Qty.Text)).ToString("0.00")
        End If
    End Sub



    Private Sub Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Qty.KeyPress
        ' Allow only numbers and Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Qty_TextChanged(sender As Object, e As EventArgs) Handles Qty.TextChanged
        UpdateSubTotal()
    End Sub

    Private Sub Price_TextChanged(sender As Object, e As EventArgs) Handles Price.TextChanged
        UpdateSubTotal()
    End Sub



    Private Sub SKUBarcodee_TextChanged(sender As Object, e As EventArgs) Handles SKUBarcodee.TextChanged
        ShowItemNameBySKU()
        UpdatePriceFromSKU()
    End Sub


    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress


        If Me.ActiveControl Is Qty OrElse Me.ActiveControl Is Cash OrElse Me.ActiveControl Is DiscountTextBox Then
            Exit Sub
        End If

        If TypeOf Me.ActiveControl Is TextBox Then Exit Sub

        Select Case Char.ToUpper(e.KeyChar)

            Case "H"c, "C"c, "V"c, "Q"c, "D"c
                e.Handled = True
                Return

        End Select


        If Char.IsLetterOrDigit(e.KeyChar) Then
            SKUBarcodee.Focus()
            SKUBarcodee.AppendText(e.KeyChar)
            e.Handled = True
        End If

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If TypeOf Me.ActiveControl Is TextBox Then Exit Sub
        ' Do NOT hijack keys while typing Qty
        If Me.ActiveControl Is Qty Then Exit Sub

        Select Case e.KeyCode

        ' ===== ENTER → PRINT =====
            Case Keys.Enter

                ' If typing in SKU, let scanner handle it
                If Me.ActiveControl Is SKUBarcodee Then Exit Select

                ' If cash panel visible, don't trigger print
                If CashIn.Visible Then Exit Select

                ' Print only if there are items
                If orderList.Rows.Count > 0 Then
                    PrintButton.PerformClick()
                End If

        ' ===== S → SUBMIT ITEM =====
            Case Keys.Q
                SubmitItemButton.PerformClick()

            Case Keys.V
                ViewHold.PerformClick()


        ' ===== H → HOLD =====
            Case Keys.H
                Hold.PerformClick()


        ' ===== C → CLEAR =====
            Case Keys.C
                ClearButton.PerformClick()


        ' ===== MOVE SELECTION UP =====
            Case Keys.Up
                If orderList.Rows.Count = 0 Then Exit Select

                If selectedIndex > 0 Then
                    selectedIndex -= 1
                Else
                    selectedIndex = 0
                End If

                UpdateSelectedSKU()
                UpdateListPanel()


        ' ===== MOVE SELECTION DOWN =====
            Case Keys.Down
                If orderList.Rows.Count = 0 Then Exit Select

                If selectedIndex < orderList.Rows.Count - 1 Then
                    selectedIndex += 1
                End If

                UpdateSelectedSKU()
                UpdateListPanel()


        ' ===== INCREASE QTY =====
            Case Keys.Left
                If selectedIndex >= 0 Then
                    IncreaseQtyByIndex()
                    UpdateListPanel()
                End If


        ' ===== DECREASE QTY =====
            Case Keys.Right
                If selectedIndex >= 0 Then
                    DecreaseQtyByIndex()
                    UpdateListPanel()
                End If


        ' ===== DELETE ITEM =====
            Case Keys.D
                If selectedIndex >= 0 Then
                    DeleteByIndex()
                    UpdateListPanel()
                End If


                ' ===== F1 → DISCOUNT =====
            Case Keys.F1
                DiscountTextBox.Focus()
                DiscountTextBox.SelectAll()

        End Select

    End Sub

    Private Sub IncreaseQtyByIndex()
        If selectedIndex < 0 Then Exit Sub

        Dim row = orderList.Rows(selectedIndex)
        row("Qty") = CInt(row("Qty")) + 1
        row("Subtotal") = CDec(row("Qty")) * CDec(row("Price"))
    End Sub
    Private Sub DecreaseQtyByIndex()
        If selectedIndex < 0 Then Exit Sub

        Dim row = orderList.Rows(selectedIndex)
        Dim newQty = CInt(row("Qty")) - 1

        If newQty <= 0 Then
            orderList.Rows.RemoveAt(selectedIndex)
            selectedIndex = Math.Max(0, selectedIndex - 1)
        Else
            row("Qty") = newQty
            row("Subtotal") = CDec(newQty) * CDec(row("Price"))
        End If
    End Sub
    Private Sub DeleteByIndex()
        If selectedIndex < 0 Then Exit Sub

        orderList.Rows.RemoveAt(selectedIndex)
        selectedIndex = Math.Max(0, selectedIndex - 1)
    End Sub

    Private Sub UpdateSelectedSKU()
        If selectedIndex >= 0 AndAlso selectedIndex < orderList.Rows.Count Then
            selectedOrderSKU = orderList.Rows(selectedIndex)("SKU").ToString()
        Else
            selectedOrderSKU = ""
        End If
    End Sub

    Private Sub IncreaseQty(sku As String)
        For Each row As DataRow In orderList.Rows
            If row("SKU").ToString() = sku Then
                row("Qty") = CInt(row("Qty")) + 1
                row("Subtotal") = CDec(row("Qty")) * CDec(row("Price"))
                Exit For
            End If
        Next
        UpdateListPanel()
    End Sub
    Private Sub DecreaseQty(sku As String)
        For Each row As DataRow In orderList.Rows
            If row("SKU").ToString() = sku Then
                Dim newQty As Integer = CInt(row("Qty")) - 1
                If newQty <= 0 Then
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

    Private Sub DeleteSelectedItem()
        For Each row As DataRow In orderList.Rows
            If row("SKU").ToString() = selectedOrderSKU Then
                orderList.Rows.Remove(row)
                Exit For
            End If
        Next

        selectedOrderSKU = ""
        UpdateListPanel()
    End Sub

    Private Sub DiscountTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Back) Then
            Exit Sub
        End If


        If e.KeyChar = "."c AndAlso Not DiscountTextBox.Text.Contains(".") Then
            Exit Sub
        End If


        e.Handled = True
        MessageBox.Show("Discount must be a number only.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub DiscountTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Escape Then
            SKUBarcodee.Focus()
            e.Handled = True
        End If
    End Sub




    Private Sub Okaay_Click(sender As Object, e As EventArgs) Handles Okaay.Click
        Dim cashPaid As Decimal

        If Not Decimal.TryParse(Cash.Text, cashPaid) Then
            MessageBox.Show("Invalid cash amount!")
            Cash.Focus()
            Return
        End If

        ' AUTO total again (always correct)
        Dim subtotal As Decimal =
    orderList.AsEnumerable().Sum(Function(r) CDec(r("Subtotal")))

        Dim discount As Decimal = 0D
        Decimal.TryParse(DiscountTextBox.Text, discount)

        If discount > subtotal Then discount = subtotal

        Dim totalValue As Decimal = subtotal - discount

        If cashPaid < totalValue Then
            MessageBox.Show("Cash is not enough! Total: ₱ " &
                            totalValue.ToString("0.00"))
            Cash.Focus()
            Return
        End If

        CashIn.Visible = False

        receiptText = BuildReceiptText(cashPaid, LoggedInUsername)


        PrintDocument2.Print()
        SaveTransaction(1)

        orderList.Clear()
        UpdateListPanel()

        GenerateReceiptNumber()
    End Sub





    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        CashIn.Visible = False
        Cash.Clear()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Cash.TextChanged

    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) _
    Handles DiscountTextBox.TextChanged

        If DiscountTextBox.Text = "" Then
            UpdateTotal()
            Exit Sub
        End If

        Dim discount As Decimal
        If Not Decimal.TryParse(DiscountTextBox.Text, discount) Then
            DiscountTextBox.Text = ""
            UpdateTotal()
            Exit Sub
        End If

        UpdateTotal()
    End Sub
End Class
