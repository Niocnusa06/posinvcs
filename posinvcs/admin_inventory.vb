Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509
Imports ZXing
Imports ZXing.Common
Imports System.Globalization





Public Class inv
    Private fullTable As New DataTable()
    Private inventoryView As DataView
    Private pagedTable As DataTable
    Private WithEvents printDocBarcode As New Printing.PrintDocument()
    Private WithEvents printDocReport As New Printing.PrintDocument()
    Private printIndex As Integer = 0
    Dim totalToPrint As Integer = 0
    Dim printedCount As Integer = 0
    Dim currentPage As Integer = 1
    Dim totalPages As Integer = 1
    Dim isEditing As Boolean = False
    Private dtInventory As DataTable
    Private dvInventory As DataView
    Private pdfRows As DataTable
    Private currentRowIndex As Integer = 0


    Private Function ItemNameExistsLocal(name As String, Optional excludeSKU As String = "") As Boolean
        If String.IsNullOrWhiteSpace(name) Then Return False


        If fullTable Is Nothing OrElse fullTable.Rows.Count = 0 Then
            LoadInventory()
        End If

        Dim search As String = name.Trim()

        For Each r As DataRow In fullTable.Rows
            If r IsNot Nothing AndAlso Not IsDBNull(r("item_name")) Then
                Dim existingName As String = r("item_name").ToString().Trim()
                Dim existingSKU As String = If(r.Table.Columns.Contains("SKU") AndAlso Not IsDBNull(r("SKU")), r("SKU").ToString().Trim(), "")

                If String.Equals(existingName, search, StringComparison.OrdinalIgnoreCase) Then
                    If excludeSKU = "" OrElse Not String.Equals(existingSKU, excludeSKU, StringComparison.OrdinalIgnoreCase) Then
                        Return True
                    End If
                End If
            End If
        Next

        Return False
    End Function



    Private Sub inv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SKU.Text = GenerateNextSKU()
        barcode.Image = GenerateBarcodeWithText(SKU.Text, item_name.Text)

        LoadCategoryDropdown()
        LoadInventory()

        cmbShowEntries.Items.Clear()
        cmbShowEntries.Items.AddRange(New String() {"10", "20", "50", "100", "500", "1000"})
        cmbShowEntries.SelectedIndex = 0

        ShowPage(1)

        cmbQuickFilter.Items.Clear()
        cmbQuickFilter.Items.Add("All Records")
        cmbQuickFilter.Items.Add("Today")
        cmbQuickFilter.Items.Add("This Week")
        cmbQuickFilter.Items.Add("This Month")
        cmbQuickFilter.Items.Add("This Year")
        cmbQuickFilter.SelectedIndex = 0
    End Sub

    Private Sub inv_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadCategoryDropdown()
    End Sub


    Private Function GenerateNextSKU() As String
        Dim latestSKU As String = ""
        Dim nextNumber As Integer = 1

        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT SKU FROM products ORDER BY id DESC LIMIT 1", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    latestSKU = reader("SKU").ToString()
                    Dim numericPart As Integer = Integer.Parse(latestSKU.Substring(3))
                    nextNumber = numericPart + 1
                End If
                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error generating SKU: " & ex.Message)
        End Try

        Return "SKU" & nextNumber.ToString("D5")
    End Function


    Private Function GenerateBarcodeWithText(SKU As String, item_name As String) As Bitmap
        Dim writer As New ZXing.BarcodeWriterPixelData()
        writer.Format = BarcodeFormat.CODE_128
        writer.Options = New ZXing.Common.EncodingOptions With {
        .Width = 300,
        .Height = 100,
        .Margin = 1
    }

        Dim pixelData = writer.Write(SKU)
        Dim barcode As New Bitmap(pixelData.Width, pixelData.Height, Imaging.PixelFormat.Format32bppArgb)
        Dim bmpData = barcode.LockBits(New Rectangle(0, 0, barcode.Width, barcode.Height),
                                   Imaging.ImageLockMode.WriteOnly, barcode.PixelFormat)

        Try
            Marshal.Copy(pixelData.Pixels, 0, bmpData.Scan0, pixelData.Pixels.Length)
        Finally
            barcode.UnlockBits(bmpData)
        End Try

        ' Create combined image
        Dim finalHeight As Integer = barcode.Height + 40
        Dim combined As New Bitmap(barcode.Width, finalHeight)

        Using g As Graphics = Graphics.FromImage(combined)
            g.Clear(Color.White)
            g.DrawImage(barcode, 0, 0)

            Dim font As New Font("Arial", 10, FontStyle.Bold)
            Dim text As String = $"{SKU} - {item_name}"
            Dim size As SizeF = g.MeasureString(text, font)

            g.DrawString(text, font, Brushes.Black,
                     (combined.Width - size.Width) / 2,
                     barcode.Height + 5)
        End Using

        Return combined
    End Function

    Private Sub SaveItem()

        If ItemNameExists(item_name.Text) Then
            MessageBox.Show("Item name already exists!", "Duplicate Item",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()

                Dim cmd As New MySqlCommand("
                INSERT INTO products (SKU, item_name, catg, price, qty, barcode)
                VALUES (@SKU, @item_name, @catg, @price, @qty, @barcode)", conn)


                Dim ms As New IO.MemoryStream()
                barcode.Image.Save(ms, Imaging.ImageFormat.Png)
                Dim barcodeBytes As Byte() = ms.ToArray()

                cmd.Parameters.AddWithValue("@SKU", SKU.Text)
                cmd.Parameters.AddWithValue("@item_name", item_name.Text)
                cmd.Parameters.AddWithValue("@catg", cmbcategory.Text)
                cmd.Parameters.AddWithValue("@price", Decimal.Parse(price.Text))
                cmd.Parameters.AddWithValue("@qty", Integer.Parse(qty.Text))
                cmd.Parameters.AddWithValue("@barcode", barcodeBytes)

                cmd.ExecuteNonQuery()

                Dim alert1 As New AlertInventorySuccessAddItem()
                ShowAlert(alert1, admin_inventory)


            End Using

            LoadInventory()
            newitem.Visible = False
            ClearTextboxes()

        Catch ex As Exception
            MessageBox.Show("Error saving item: " & ex.Message)
        End Try

    End Sub


    Private Function ItemNameExists(name As String) As Boolean
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()

                Dim query As String = "
                SELECT COUNT(*) 
                FROM products 
                WHERE LOWER(TRIM(item_name)) = LOWER(TRIM(@name))"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", name)

                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking item name: " & ex.Message)
            Return True
        End Try
    End Function


    Public Sub LoadInventory()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()

                Dim sql As String = "
                SELECT SKU, item_name, catg, price, qty, date_created
                FROM products
                ORDER BY date_created DESC
            "

                Dim da As New MySqlDataAdapter(sql, conn)
                fullTable = New DataTable()
                da.Fill(fullTable)
            End Using

            inventoryView = New DataView(fullTable)
            ApplySearchFilter()
            ApplyQuickFilter()
            ShowPage(1)

        Catch ex As Exception
            MessageBox.Show("LoadInventory error: " & ex.Message)
        End Try
    End Sub




    Private Sub AddActionButtons()
        If Not datagridview1.Columns.Contains("Edit") Then
            Dim editButton As New DataGridViewImageColumn()
            With editButton
                .HeaderText = "Edit"
                .Name = "Edit"
                .Image = My.Resources.Resources.edit
                .ImageLayout = DataGridViewImageCellLayout.Zoom
                .Width = 20
            End With
            datagridview1.Columns.Add(editButton)
        End If

        If Not datagridview1.Columns.Contains("Damage") Then
            Dim damageButton As New DataGridViewImageColumn()
            With damageButton
                .HeaderText = "Damage"
                .Name = "Damage"
                .Image = My.Resources.Resources.damage_icon
                .ImageLayout = DataGridViewImageCellLayout.Zoom
                .Width = 20
            End With
            datagridview1.Columns.Add(damageButton)
        End If

        If Not datagridview1.Columns.Contains("StockIn") Then
            Dim stockInButton As New DataGridViewImageColumn()
            With stockInButton
                .HeaderText = "Stock In"
                .Name = "StockIn"
                .Image = My.Resources.Resources.stockin_icon
                .ImageLayout = DataGridViewImageCellLayout.Zoom
                .Width = 20
            End With
            datagridview1.Columns.Add(stockInButton)
        End If
    End Sub



    Private Sub datagridview1_CellMouseMove(
    sender As Object,
    e As DataGridViewCellMouseEventArgs
) Handles datagridview1.CellMouseMove

        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then
            datagridview1.Cursor = Cursors.Default
            Exit Sub
        End If


        If TypeOf datagridview1.Columns(e.ColumnIndex) Is DataGridViewImageColumn Then
            datagridview1.Cursor = Cursors.Hand
        Else
            datagridview1.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub datagridview1_CellMouseLeave(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles datagridview1.CellMouseLeave

        datagridview1.Cursor = Cursors.Default

    End Sub



    Private Sub btnSaveDamage_Click(sender As Object, e As EventArgs) Handles btnSaveDamage.Click
        '
        If damage_qty.Text = "" Or Not IsNumeric(damage_qty.Text) Then
            MessageBox.Show("Please enter a valid number for damaged quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim damagedQty As Integer = Val(damage_qty.Text)
        Dim currentQty As Integer = Val(available_qty.Text)
        Dim newQty As Integer = currentQty - damagedQty


        If damagedQty <= 0 Or damagedQty > currentQty Then
            MessageBox.Show("Invalid damage quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()


                Dim updateQuery As String = "UPDATE products SET qty = @newQty WHERE SKU = @sku"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@newQty", newQty)
                    cmd.Parameters.AddWithValue("@sku", SKU_dmg.Text)
                    cmd.ExecuteNonQuery()
                End Using


                Dim insertQuery As String = "
                INSERT INTO damage_items 
                (SKU, item_name, category, price, damage_qty, unit_type, remarks, date_reported, status)
                VALUES (@sku, @item_name, @category, @price, @damage_qty, @unit_type, @remarks, NOW(), 'Damaged')"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@sku", SKU_dmg.Text)
                    cmd.Parameters.AddWithValue("@item_name", item_dmg.Text)
                    cmd.Parameters.AddWithValue("@category", lblcategory.Text)
                    cmd.Parameters.AddWithValue("@price", Val(price_dmg.Text))
                    cmd.Parameters.AddWithValue("@damage_qty", damagedQty)
                    cmd.Parameters.AddWithValue("@unit_type", cmbUnitType.Text)
                    cmd.Parameters.AddWithValue("@remarks", remarks_dmg.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Dim alert2 As New AlertInventoryDamageSuccess()
            ShowAlert(alert2, admin_inventory)


            If Application.OpenForms().OfType(Of damage).Any() Then
                Dim dmgForm As damage = Application.OpenForms().OfType(Of damage).First()
                dmgForm.LoadDamageItems()
            End If

            damage_panel.Visible = False
            LoadInventory()




        Catch ex As Exception
            MessageBox.Show("Error saving damaged item: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim selectedRow As DataGridViewRow = datagridview1.Rows(e.RowIndex)
        Dim selectedSKU As String = selectedRow.Cells("SKU").Value.ToString()


        If datagridview1.Columns(e.ColumnIndex).Name = "Edit" Then
            isEditing = True
            newitem.BringToFront()
            newitem.Visible = True
            btnAdd.Visible = False
            btnSaveChanges.Visible = True
            Label2.Visible = False
            edit.Visible = True

            SKU.Text = selectedRow.Cells("SKU").Value.ToString()
            item_name.Text = selectedRow.Cells("item_name").Value.ToString()
            cmbcategory.Text = selectedRow.Cells("catg").Value.ToString()
            price.Text = selectedRow.Cells("price").Value.ToString()
            qty.Text = selectedRow.Cells("qty").Value.ToString()

            barcode.Image = GenerateBarcodeWithText(SKU.Text, item_name.Text)

        End If


        If datagridview1.Columns(e.ColumnIndex).Name = "Damage" Then

            damage_panel.Visible = True
            damage_panel.BringToFront()

            SKU_dmg.Text = selectedRow.Cells("SKU").Value.ToString()
            item_dmg.Text = selectedRow.Cells("item_name").Value.ToString()
            lblcategory.Text = selectedRow.Cells("catg").Value.ToString()
            available_qty.Text = selectedRow.Cells("qty").Value.ToString()
            price_dmg.Text = selectedRow.Cells("price").Value.ToString()


            damage_qty.Text = ""
            remarks_dmg.SelectedIndex = -1
        End If

        If datagridview1.Columns(e.ColumnIndex).Name = "StockIn" Then
            Dim sku As String = selectedRow.Cells("SKU").Value.ToString()
            Dim itemName As String = selectedRow.Cells("item_name").Value.ToString()
            Dim category As String = selectedRow.Cells("catg").Value.ToString()
            Dim price As String = selectedRow.Cells("price").Value.ToString()
            Dim qty As String = selectedRow.Cells("qty").Value.ToString()

            Dim stockForm As New stockin(sku, itemName, category, price, qty, Me)
            stockForm.ShowDialog()

        End If

    End Sub


    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If Not isEditing Then Exit Sub

        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("
                    UPDATE products 
                    SET item_name=@item_name, catg=@catg, price=@price, qty=@qty 
                    WHERE SKU=@SKU", conn)

                cmd.Parameters.AddWithValue("@SKU", SKU.Text)
                cmd.Parameters.AddWithValue("@item_name", item_name.Text)
                cmd.Parameters.AddWithValue("@catg", cmbcategory.Text)
                cmd.Parameters.AddWithValue("@price", Decimal.Parse(price.Text))
                cmd.Parameters.AddWithValue("@qty", Integer.Parse(qty.Text))
                cmd.ExecuteNonQuery()

                Dim alert3 As New AlertInventoryUpdateItem()
                ShowAlert(alert3, admin_inventory)
            End Using

            LoadInventory()
            ClearTextboxes()
            newitem.Visible = False
            isEditing = False
            btnAdd.Visible = True
            btnSaveChanges.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error updating item: " & ex.Message)
        End Try
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SaveItem()
        LoadInventory()
        SKU.Text = GenerateNextSKU()
        barcode.Image = GenerateBarcodeWithText(SKU.Text, item_name.Text)



    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        newitem.Visible = False
    End Sub


    Private Sub additembtn_Click(sender As Object, e As EventArgs) Handles additembtn.Click
        newitem.BringToFront()
        newitem.Visible = True
        isEditing = False
        ClearTextboxes()
        SKU.Text = GenerateNextSKU()
        barcode.Image = GenerateBarcodeWithText(SKU.Text, item_name.Text)

        btnAdd.Visible = True
        btnSaveChanges.Visible = False
    End Sub

    Private Sub ClearTextboxes()
        SKU.Clear()
        item_name.Clear()
        cmbcategory.SelectedIndex = -1
        price.Clear()
        qty.Clear()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        damage_panel.Visible = False
    End Sub

    Private Sub damage_qty_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles damage_qty.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    '-----------------------PRINT BARCODE FUNCTION-------------------------

    Private barcodeList As New List(Of Bitmap)()

    Public Sub PrintSingleBarcode(barcodeImg As Bitmap)
        RemoveHandler printDocBarcode.PrintPage, AddressOf PrintSinglePage
        RemoveHandler printDocBarcode.PrintPage, AddressOf PrintMultiplePage

        AddHandler printDocBarcode.PrintPage, AddressOf PrintSinglePage

        currentSingleBarcode = barcodeImg
        ShowPrintPreview()
    End Sub

    Private currentSingleBarcode As Bitmap

    Private Sub PrintSinglePage(sender As Object, e As Printing.PrintPageEventArgs)
        e.Graphics.DrawImage(currentSingleBarcode, 50, 50)
    End Sub


    Public Sub PrintMultipleBarcodes()
        If barcodeList.Count = 0 Then
            MessageBox.Show("No barcodes to print.")
            Exit Sub
        End If

        printIndex = 0

        RemoveHandler printDocBarcode.PrintPage, AddressOf PrintSinglePage
        RemoveHandler printDocBarcode.PrintPage, AddressOf PrintMultiplePage

        AddHandler printDocBarcode.PrintPage, AddressOf PrintMultiplePage

        ShowPrintPreview()
    End Sub

    Private Sub PrintMultiplePage(sender As Object, e As Printing.PrintPageEventArgs)
        e.Graphics.DrawImage(barcodeList(printIndex), 50, 50)

        printIndex += 1

        If printIndex < barcodeList.Count Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            printIndex = 0
        End If
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        totalToPrint = Integer.Parse(qty.Text)
        printedCount = 0

        Dim preview As New PrintPreviewDialog()
        preview.Document = printDocBarcode
        preview.WindowState = FormWindowState.Maximized
        preview.ShowDialog()
    End Sub

    Private Sub ShowPrintPreview()
        Dim preview As New PrintPreviewDialog()
        preview.Document = printDocBarcode
        preview.Width = 900
        preview.Height = 700
        preview.ShowDialog()
    End Sub
    Private Function CloneBarcodeImage(src As Bitmap) As Bitmap
        Return New Bitmap(src)
    End Function
    Private Sub printDocBarcode_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocBarcode.PrintPage
        Dim barcodesPerPage As Integer = 14
        Dim col As Integer = 2
        Dim barcodeWidth As Integer = 300
        Dim barcodeHeight As Integer = 80

        Dim startX As Integer = 50
        Dim startY As Integer = 40

        Dim spacingX As Integer = 370
        Dim spacingY As Integer = 150

        Dim labelWidth As Integer = 340
        Dim labelHeight As Integer = 140

        Dim countOnPage As Integer = 0

        While printedCount < totalToPrint And countOnPage < barcodesPerPage

            Dim currentRow As Integer = countOnPage \ col
            Dim currentCol As Integer = countOnPage Mod col

            Dim posX As Integer = startX + (currentCol * spacingX)
            Dim posY As Integer = startY + (currentRow * spacingY)

            e.Graphics.DrawRectangle(Pens.Black, posX - 10, posY - 10, labelWidth, labelHeight)


            Dim writer As New ZXing.BarcodeWriterPixelData()
            writer.Format = ZXing.BarcodeFormat.CODE_128
            writer.Options = New ZXing.Common.EncodingOptions With {
                .Width = barcodeWidth,
                .Height = barcodeHeight,
                .Margin = 1
            }


            Dim pixel = writer.Write(SKU.Text)


            Dim barcodeImg As New Bitmap(pixel.Width, pixel.Height, Imaging.PixelFormat.Format32bppArgb)
            Dim bmpData = barcodeImg.LockBits(
                New Rectangle(0, 0, barcodeImg.Width, barcodeImg.Height),
                Imaging.ImageLockMode.WriteOnly,
                Imaging.PixelFormat.Format32bppArgb)

            Runtime.InteropServices.Marshal.Copy(pixel.Pixels, 0, bmpData.Scan0, pixel.Pixels.Length)
            barcodeImg.UnlockBits(bmpData)


            e.Graphics.DrawImage(barcodeImg, posX, posY)

            Dim skuFont As New Font("Arial", 12, FontStyle.Bold)
            Dim skuText As String = SKU.Text

            Dim textSize = e.Graphics.MeasureString(skuText, skuFont)

            Dim textX As Single = posX + (barcodeWidth - textSize.Width) / 2


            e.Graphics.DrawString(
                skuText,
                skuFont,
                Brushes.Black,
                textX,
                posY + barcodeHeight + 5
            )


            e.Graphics.DrawString(item_name.Text,
                                  New Font("Arial", 10),
                                  Brushes.Black,
                                  posX,
                                  posY + barcodeHeight + 25)

            countOnPage += 1
            printedCount += 1
        End While

        e.HasMorePages = (printedCount < totalToPrint)
    End Sub

    Private Sub datagridview1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagridview1.CellFormatting
        If datagridview1.Columns.Contains("qty") = False Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = datagridview1.Rows(e.RowIndex)
        Dim qtyValue As Integer = 0


        Integer.TryParse(row.Cells("qty").Value.ToString(), qtyValue)


        If qtyValue < 10 Then
            row.DefaultCellStyle.BackColor = Color.LightCoral
            row.DefaultCellStyle.ForeColor = Color.Black
        ElseIf qtyValue = 10 Then
            row.DefaultCellStyle.BackColor = Color.Khaki
            row.DefaultCellStyle.ForeColor = Color.Black
        Else
            row.DefaultCellStyle.BackColor = Color.White
            row.DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    '-----------------------------CATEGORY DROPDOWN LOAD-------------------------
    Public Sub LoadCategoryDropdown()
        Try
            Using conn = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT category_name FROM categories ORDER BY category_name"
                Using cmd As New MySqlCommand(query, conn)
                    Dim reader = cmd.ExecuteReader()
                    cmbcategory.Items.Clear()
                    While reader.Read()
                        cmbcategory.Items.Add(reader("category_name").ToString())
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading category dropdown: " & ex.Message)
        End Try
    End Sub

    Private Sub ApplySearchFilter()
        If inventoryView Is Nothing Then Exit Sub

        Dim s As String = searchtb.Text.Replace("'", "''")

        inventoryView.RowFilter =
         $"SKU LIKE '%{s}%' OR " &
         $"item_name LIKE '%{s}%' OR " &
         $"catg LIKE '%{s}%' OR " &
         $"Convert(price, 'System.String') LIKE '%{s}%' OR " &
         $"Convert(qty, 'System.String') LIKE '%{s}%'"

    End Sub

    Private Sub searchtb_TextChanged_1(sender As Object, e As EventArgs) Handles searchtb.TextChanged

        ApplySearchFilter()
        ShowPage(1)
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbShowEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShowEntries.SelectedIndexChanged
        ShowPage(1)
    End Sub




    Private Sub item_name_TextChanged(sender As Object, e As EventArgs) Handles item_name.TextChanged
        Try

            If fullTable Is Nothing OrElse fullTable.Rows.Count = 0 Then
                LoadInventory()
            End If

            Dim typedName As String = item_name.Text.Trim()

            If typedName = "" Then
                lblDuplicate.Visible = False
                item_name.BackColor = Color.White
                Exit Sub
            End If

            Dim excludeSKU As String = If(isEditing, SKU.Text.Trim(), "")

            If ItemNameExistsLocal(typedName, excludeSKU) Then
                lblDuplicate.Visible = True
                lblDuplicate.Text = "Item name already exists!"
                lblDuplicate.ForeColor = Color.Red
                item_name.BackColor = Color.LightPink
            Else
                lblDuplicate.Visible = False
                item_name.BackColor = Color.White
            End If

        Catch ex As Exception
            lblDuplicate.Visible = False
            item_name.BackColor = Color.White
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            ShowPage(currentPage - 1)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            ShowPage(currentPage + 1)
        End If
    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        Try

            If TypeOf datagridview1.DataSource Is DataView Then
                pdfRows = CType(datagridview1.DataSource, DataView).ToTable()
            ElseIf TypeOf datagridview1.DataSource Is DataTable Then
                pdfRows = CType(datagridview1.DataSource, DataTable)
            Else
                MessageBox.Show("Cannot export: Unknown data source type!")
                Return
            End If

            currentRowIndex = 0

            If pdfRows Is Nothing OrElse pdfRows.Rows.Count = 0 Then
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"

            Dim today As String = Date.Now.ToString("yyyy.MM.dd")
            saveDialog.FileName = today & " Inventory.pdf"


            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim pdfPath As String = saveDialog.FileName

                Dim ps As New Printing.PrinterSettings()
                ps.PrinterName = "Microsoft Print to PDF"
                ps.PrintToFile = True
                ps.PrintFileName = pdfPath

                printDocReport.PrinterSettings = ps

                printDocReport.Print()
                MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("PDF export error: " & ex.Message)
        End Try
    End Sub

    Private Sub printDocReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocReport.PrintPage
        Dim titleFont As New Font("Arial", 18, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim bodyFont As New Font("Arial", 10)
        Dim linePen As New Pen(Color.Black, 1)

        Dim left As Single = 40
        Dim top As Single = 40
        Dim y As Single = top

        ' ================= REPORT HEADER ==================
        e.Graphics.DrawString("MARIA ATHENA MOTORSHOP & ACCESSORIES", titleFont, Brushes.Black, left, y)
        y += 35

        e.Graphics.DrawString("Inventory Report", headerFont, Brushes.Black, left, y)
        y += 25

        e.Graphics.DrawString("Generated: " & Date.Now.ToString("MMMM dd, yyyy hh:mm tt"),
                      bodyFont, Brushes.Black, left, y)
        y += 30

        ' ================== COLUMN POSITIONS ===============
        Dim colItem As Single = left
        Dim colCat As Single = left + 230
        Dim colQty As Single = left + 380
        Dim colPrice As Single = left + 430
        Dim colDate As Single = left + 500

        ' ==== TABLE HEADER ====
        e.Graphics.DrawString("Product Name", headerFont, Brushes.Black, colItem, y)
        e.Graphics.DrawString("Category", headerFont, Brushes.Black, colCat, y)
        e.Graphics.DrawString("Qty", headerFont, Brushes.Black, colQty, y)
        e.Graphics.DrawString("Price", headerFont, Brushes.Black, colPrice, y)
        e.Graphics.DrawString("Date Created", headerFont, Brushes.Black, colDate, y)

        y += 25
        e.Graphics.DrawLine(linePen, left, y, 780, y)
        y += 5

        ' ==== PRINT ROWS ====
        While currentRowIndex < pdfRows.Rows.Count

            Dim row = pdfRows.Rows(currentRowIndex)

            Dim itemName As String = row("item_name").ToString()
            Dim category As String = row("catg").ToString()
            Dim qty As String = row("qty").ToString()
            Dim price As String = row("price").ToString()
            Dim dateCreated As String = CDate(row("date_created")).ToString("MM/dd/yyyy")


            Dim itemRect As New RectangleF(colItem, y, 220, 150)
            Dim itemSize As SizeF = e.Graphics.MeasureString(itemName, bodyFont, itemRect.Size)


            Dim catRect As New RectangleF(colCat, y, 130, 150)
            Dim catSize As SizeF = e.Graphics.MeasureString(category, bodyFont, catRect.Size)


            Dim rowHeight As Single = Math.Max(Math.Max(itemSize.Height, catSize.Height), 20)

            ' ====================== DRAW TEXT ===============
            e.Graphics.DrawString(itemName, bodyFont, Brushes.Black, itemRect)
            e.Graphics.DrawString(category, bodyFont, Brushes.Black, catRect)
            e.Graphics.DrawString(qty, bodyFont, Brushes.Black, colQty, y)
            e.Graphics.DrawString(price, bodyFont, Brushes.Black, colPrice, y)
            e.Graphics.DrawString(dateCreated, bodyFont, Brushes.Black, colDate, y)

            y += rowHeight + 6

            ' ==== PAGE BREAK ====
            If y > e.MarginBounds.Bottom - 40 Then
                e.HasMorePages = True
                Exit Sub
            End If

            currentRowIndex += 1
        End While

        ' ==== END OF REPORT ====
        y += 10
        e.Graphics.DrawLine(linePen, left, y, 780, y)
        y += 15
        e.Graphics.DrawString("END OF REPORT", headerFont, Brushes.Black, left, y)

        e.HasMorePages = False
    End Sub



    Private Sub cmbQuickFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuickFilter.SelectedIndexChanged
        ApplyQuickFilter()
        ShowPage(1)
    End Sub

    '===================COMBOBOX QUICK FILTER=====================
    Private Sub ApplyQuickFilter()
        If inventoryView Is Nothing Then Exit Sub


        Dim s As String = searchtb.Text.Replace("'", "''").Trim()
        Dim searchFilter As String = ""
        If s <> "" Then
            searchFilter = String.Format("SKU LIKE '%{0}%' OR item_name LIKE '%{0}%' OR catg LIKE '%{0}%'", s)

            searchFilter &= String.Format(" OR Convert(price, 'System.String') LIKE '%{0}%'", s)
            searchFilter &= String.Format(" OR Convert(qty, 'System.String') LIKE '%{0}%'", s)
        End If


        Dim dateFilter As String = ""
        Dim today As Date = Date.Today

        Select Case cmbQuickFilter.Text
            Case "Today"
                Dim startD As String = today.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
                Dim nextD As String = today.AddDays(1).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
                dateFilter = String.Format("date_created >= #{0}# AND date_created < #{1}#", startD, nextD)

            Case "This Week"

                Dim diff As Integer = (CInt(today.DayOfWeek) - CInt(DayOfWeek.Monday))
                If diff < 0 Then diff += 7
                Dim weekStart As Date = today.AddDays(-diff)
                Dim weekEnd As Date = weekStart.AddDays(7) ' exclusive
                dateFilter = String.Format("date_created >= #{0}# AND date_created < #{1}#",
                                       weekStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                                       weekEnd.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture))

            Case "This Month"
                Dim monthStart As New Date(today.Year, today.Month, 1)
                Dim monthEnd As Date = monthStart.AddMonths(1)
                dateFilter = String.Format("date_created >= #{0}# AND date_created < #{1}#",
                                       monthStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                                       monthEnd.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture))

            Case "This Year"
                Dim yearStart As New Date(today.Year, 1, 1)
                Dim yearEnd As Date = yearStart.AddYears(1)
                dateFilter = String.Format("date_created >= #{0}# AND date_created < #{1}#",
                                       yearStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                                       yearEnd.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture))

            Case Else
                dateFilter = ""
        End Select


        Dim combined As String = ""

        If searchFilter <> "" Then
            combined = "(" & searchFilter & ")"
        End If

        If dateFilter <> "" Then
            If combined <> "" Then
                combined &= " AND (" & dateFilter & ")"
            Else
                combined = dateFilter
            End If
        End If

        inventoryView.RowFilter = combined
    End Sub


    Private Sub ShowPage(page As Integer)
        If inventoryView Is Nothing Then Exit Sub

        Dim limit As Integer

        If Not Integer.TryParse(cmbShowEntries.Text, limit) Then
            limit = 10
        End If

        Dim filteredTable As DataTable = inventoryView.ToTable()

        Dim total As Integer = filteredTable.Rows.Count
        totalPages = Math.Ceiling(total / limit)

        If page < 1 Then page = 1
        If page > totalPages Then page = totalPages

        currentPage = page

        Dim startIndex As Integer = (page - 1) * limit

        pagedTable = filteredTable.AsEnumerable().
        Skip(startIndex).
        Take(limit).
        CopyToDataTable()

        datagridview1.DataSource = pagedTable
        FixColumnOrder()

        lblentries.Text = $"Showing page {currentPage} of {totalPages} ({pagedTable.Rows.Count} entries)"
    End Sub
    Private Sub FixColumnOrder()
        If datagridview1.Columns.Count = 0 Then Exit Sub

        datagridview1.AutoGenerateColumns = False

        datagridview1.Columns("SKU").DisplayIndex = 0
        datagridview1.Columns("item_name").DisplayIndex = 1
        datagridview1.Columns("catg").DisplayIndex = 2
        datagridview1.Columns("price").DisplayIndex = 3
        datagridview1.Columns("qty").DisplayIndex = 4
        datagridview1.Columns("date_created").DisplayIndex = 5

        AddActionButtons()
    End Sub

    Private Sub lblentries_Click(sender As Object, e As EventArgs) Handles lblentries.Click

    End Sub
End Class
