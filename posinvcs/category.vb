Imports MySql.Data.MySqlClient
Public Class category

    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()

        Try
            Using conn = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT id, category_name FROM categories ORDER BY category_name"
                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvcategory.DataSource = dt
            End Using

            dgvcategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' ================== ADD EDIT & DELETE ICON COLUMNS ==================
            If Not dgvcategory.Columns.Contains("Edit") Then
                Dim editCol As New DataGridViewImageColumn()
                editCol.HeaderText = ""
                editCol.Name = "Edit"
                editCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                editCol.Image = My.Resources.edit

                editCol.Width = 35
                dgvcategory.Columns.Add(editCol)
            End If

            If Not dgvcategory.Columns.Contains("Delete") Then
                Dim delCol As New DataGridViewImageColumn()
                delCol.HeaderText = ""
                delCol.Name = "Delete"
                delCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                delCol.Image = My.Resources.delete

                delCol.Width = 35
                dgvcategory.Columns.Add(delCol)
            End If


        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try

    End Sub

    ' ========== ADD CATEGORY ==========
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtcategory.Text.Trim() = "" Then
            MessageBox.Show("Please enter a category name.")
            Return
        End If

        Try
            Using conn = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO categories (category_name) VALUES (@cat)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cat", txtcategory.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Category added successfully!")
            LoadCategories()
            txtcategory.Clear()

            If Application.OpenForms().OfType(Of inv)().Any() Then
                Dim invForm As inv = Application.OpenForms().OfType(Of inv)().First()
                invForm.LoadCategoryDropdown()
            End If

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Category already exists.")
            Else
                MessageBox.Show("Error adding category: " & ex.Message)
            End If
        End Try
    End Sub

    ' ========== WHEN ROW IS CLICKED ==========
    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategory.CellClick
        If e.RowIndex >= 0 Then
            txtcategory.Text = dgvcategory.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    ' ========== UPDATE CATEGORY ==========
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtcategory.Tag Is Nothing Then
            MessageBox.Show("Please select a category to update.")
            Return
        End If

        Dim id As Integer = CInt(txtcategory.Tag)

        Try
            Using conn = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE categories SET category_name=@cat WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cat", txtcategory.Text)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Category updated successfully!")
            LoadCategories()

            txtcategory.Clear()
            txtcategory.Tag = Nothing
            btnUpdate.Enabled = False
            btnadd.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error updating category: " & ex.Message)
        End Try
    End Sub


    Private Sub dgvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategory.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        Dim id As Integer = dgvcategory.Rows(e.RowIndex).Cells("id").Value
        Dim categoryName As String = dgvcategory.Rows(e.RowIndex).Cells("category_name").Value.ToString()

        ' ================== EDIT ==================
        If dgvcategory.Columns(e.ColumnIndex).Name = "Edit" Then
            txtcategory.Text = categoryName
            txtcategory.Tag = id   ' store the id temporarily
            btnUpdate.Enabled = True
            btnadd.Enabled = False
        End If

        ' ================== DELETE ==================
        If dgvcategory.Columns(e.ColumnIndex).Name = "Delete" Then

            If MessageBox.Show("Are you sure you want to delete this category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeleteCategory(id)
            End If

        End If

    End Sub
    Private Sub DeleteCategory(id As Integer)
        Try
            Using conn = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM categories WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Category deleted successfully!")
            LoadCategories()

        Catch ex As Exception
            MessageBox.Show("Error deleting category: " & ex.Message)
        End Try
    End Sub


End Class