
Imports ZXing

Public Class main
    Dim dashboardPage As New _1dashboard()
    Dim inventoryPage As New inv()
    Dim damagedPage As New damage()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormIntoPanel(dashboardPage)
        db.Show()
        invp.Hide()
        catgp.Hide()
        sihp.Hide()
        salesp.Hide()
        brp.Hide()
        usersp.Hide()
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            exitbtn.PerformClick()
        End If
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub LoadFormIntoPanel(form As Form)
        panelMain.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        panelMain.Controls.Add(form)
        form.Show()
    End Sub





    '/////// INVENTORY DROPDOWN CODE//////////
    ' Show the dropdown when inventory button clicked
    Private Sub Btn_sb_inventory_Click(sender As Object, e As EventArgs)
        DropD_Inve.Visible = True
    End Sub

    Private Sub DDInv(sender As Object, e As EventArgs)
        DropD_Inve.Visible = True
    End Sub


    Private Sub Control_MouseLeave(sender As Object, e As EventArgs)
        Dim mousePos = PointToClient(MousePosition)

        If Not Btn_sb_invi.Bounds.Contains(mousePos) AndAlso
       Not Btn_Inve_ProdL.Bounds.Contains(mousePos) AndAlso
       Not Btn_dmg.Bounds.Contains(mousePos) AndAlso
       Not DropD_Inve.Bounds.Contains(mousePos) Then
            DropD_Inve.Visible = False
        End If
    End Sub


    Private Sub Btn_sb_sales_Click(sender As Object, e As EventArgs) Handles Btn_sb_sales.Click
        LoadFormIntoPanel(sales)
    End Sub

    Private Sub Btn_Inve_ProdL_Click(sender As Object, e As EventArgs)
        LoadFormIntoPanel(inventoryPage)
    End Sub


    Private Sub Btn_Inve_Categ_Click(sender As Object, e As EventArgs)
        LoadFormIntoPanel(damagedPage)
        DropD_Inve.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
        )


        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub Btn_sb_backuprestore_Click(sender As Object, e As EventArgs) Handles Btn_sb_backuprestore.Click
        LoadFormIntoPanel(backuprestore)
        DropD_Inve.Hide()
        db.Hide()
        invp.Hide()
        catgp.Hide()
        sihp.Hide()
        salesp.Hide()
        brp.Show()
        usersp.Hide()
    End Sub

    Private Sub Btn_sb_users_Click(sender As Object, e As EventArgs) Handles Btn_sb_users.Click
        LoadFormIntoPanel(User)
        DropD_Inve.Hide()
        db.Hide()
        invp.Hide()
        catgp.Hide()
        sihp.Hide()
        salesp.Hide()
        brp.Hide()
        usersp.Show()
    End Sub

    Private Sub Btn_sb_invi_Click(sender As Object, e As EventArgs) Handles Btn_sb_invi.Click
        DropD_Inve.Visible = True
        db.Hide()
        invp.Show()
        catgp.Hide()
        sihp.Hide()
        salesp.Hide()
        brp.Hide()
        usersp.Hide()
    End Sub

    Private Sub Btn_sb_dash_Click(sender As Object, e As EventArgs) Handles Btn_sb_dash.Click
        LoadFormIntoPanel(dashboardPage)
        DropD_Inve.Hide()
        db.Show()
        invp.Hide()
        catgp.Hide()
        sihp.Hide()
        salesp.Hide()
        brp.Hide()
        usersp.Hide()
    End Sub

    Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_sales.Click
        LoadFormIntoPanel(sales)
        DropD_Inve.Hide()
        db.Hide()
        invp.Hide()
        catgp.Hide()
        sihp.Hide()
        salesp.Show()
        brp.Hide()
        usersp.Hide()
    End Sub

    Private Sub btn_catg_Click(sender As Object, e As EventArgs) Handles btn_catg.Click
        LoadFormIntoPanel(category)
        DropD_Inve.Hide()
        db.Hide()
        invp.Hide()
        catgp.Show()
        sihp.Hide()
        salesp.Hide()
        brp.Hide()
        usersp.Hide()
    End Sub

    Private Sub btn_stock_history_Click(sender As Object, e As EventArgs) Handles btn_stock_history.Click
        LoadFormIntoPanel(stockinhistory)
        DropD_Inve.Hide()
        db.Hide()
        invp.Hide()
        catgp.Hide()
        sihp.Show()
        salesp.Hide()
        brp.Hide()
        usersp.Hide()
    End Sub

    Private Sub Btn_Inve_ProdL_Click_1(sender As Object, e As EventArgs) Handles Btn_Inve_ProdL.Click
        LoadFormIntoPanel(inventoryPage)
        DropD_Inve.Hide()
        db.Hide()
        invp.Hide()
        catgp.Hide()
        sihp.Hide()
        salesp.Hide()
        brp.Hide()
        usersp.Hide()
    End Sub

    Private Sub Btn_dmg_Click(sender As Object, e As EventArgs) Handles Btn_dmg.Click
        LoadFormIntoPanel(damagedPage)
        DropD_Inve.Hide()
        db.Hide()
        invp.Hide()
        catgp.Hide()
        sihp.Hide()
        salesp.Hide()
        brp.Hide()
        usersp.Hide()

    End Sub

    Private Sub panelMain_Paint(sender As Object, e As PaintEventArgs) Handles panelMain.Paint

    End Sub

    Private Sub minimizebtn_Click(sender As Object, e As EventArgs) Handles minimizebtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click

    End Sub
End Class