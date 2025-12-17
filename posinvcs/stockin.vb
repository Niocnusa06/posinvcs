Imports MySql.Data.MySqlClient

Public Class stockin
    Private SKU As String
    Private itemName As String
    Private category As String
    Private price As Decimal
    Private currentQty As Integer
    Private parentInventory As inv

    Public Sub New(sku As String, itemName As String, category As String, price As Decimal, qty As Integer, parent As inv)
        InitializeComponent()
        Me.SKU = sku
        Me.itemName = itemName
        Me.category = category
        Me.price = price
        Me.currentQty = qty
        Me.parentInventory = parent
    End Sub

    Private Sub StockInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSKU.Text = SKU
        lblItemName.Text = itemName
        lblCategory.Text = category
        lblPrice.Text = "₱" & price.ToString("N2")
        lblCurrentQty.Text = currentQty.ToString()
        LoadStockInHistory()
        stockinalert.Visible = False
    End Sub

    Private Sub LoadStockInHistory()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT date_in, qty_added FROM stockin_history WHERE SKU = @sku ORDER BY date_in DESC"
                Dim da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@sku", SKU)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvStockHistory.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading stock-in history: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveStockIn_Click(sender As Object, e As EventArgs) Handles btnSaveStockIn.Click
        Dim addedQty As Integer
        If Not Integer.TryParse(txtAddQty.Text, addedQty) Or addedQty <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()


                Dim updateQuery As String = "UPDATE products SET qty = qty + @addedQty WHERE SKU = @sku"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@addedQty", addedQty)
                    cmd.Parameters.AddWithValue("@sku", SKU)
                    cmd.ExecuteNonQuery()
                End Using


                Dim insertQuery As String = "INSERT INTO stockin_history (SKU, qty_added, date_in) VALUES (@sku, @qty_added, NOW())"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@sku", SKU)
                    cmd.Parameters.AddWithValue("@qty_added", addedQty)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            stockinalert.Visible = True



        Catch ex As Exception
            MessageBox.Show("Error adding stock: " & ex.Message)
        End Try

    End Sub

    Private Sub btnSaveStockIn_Click_1(sender As Object, e As EventArgs) Handles btnSaveStockIn.Click

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub

    Private Sub lblItemName_TextChanged(sender As Object, e As EventArgs) Handles lblItemName.TextChanged

    End Sub

    Private Sub txtAddQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddQty.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If parentInventory IsNot Nothing Then
            parentInventory.LoadInventory()
        End If

        LoadStockInHistory()
        txtAddQty.Clear()
        Me.Close()

    End Sub





End Class