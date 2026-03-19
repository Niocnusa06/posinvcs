Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class _1dashboard



    Private Sub _1dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTodaySales()
        LoadTodayStockIn()
        LoadLowStock()
        LoadTodaySalesChart()
        LoadBestSellingCategories()
        LoadTodayDamage()
        LoadCurrentMonth()
    End Sub
    Private Sub _1dashboard_VisibleChanged(sender As Object, e As EventArgs) _
    Handles Me.VisibleChanged

        If Me.Visible Then
            RefreshDashboard()
        End If

    End Sub

    Public Sub RefreshDashboard()
        LoadTodaySales()
        LoadTodayStockIn()
        LoadTodayDamage()
        LoadLowStock()
        LoadSalesChart()
        LoadBestSellingCategories()
    End Sub


    '==================== TOTAL SALES (TODAY) ====================
    Private Sub LoadTodaySales()
        Dim total As Decimal = 0
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT SUM(total) FROM sales_transactions WHERE DATE(transaction_time) = CURDATE()"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If Not IsDBNull(result) Then total = Convert.ToDecimal(result)
                End Using
            End Using
            TotalSaleSum.Text = "₱ " & total.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error loading today's sales: " & ex.Message)
        End Try
    End Sub
    '==================== TOTAL DAMAGE (TODAY) ====================
    Private Sub LoadTodayDamage()
        Dim total As Integer = 0
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()

                Dim query As String =
                "SELECT IFNULL(SUM(damage_qty),0)
                 FROM damage_items
                 WHERE DATE(date_reported) = CURDATE()"

                Using cmd As New MySqlCommand(query, conn)
                    total = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            totaldmg.Text = total.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading today's damage: " & ex.Message)
        End Try
    End Sub


    '==================== TOTAL STOCK-IN (TODAY) ====================
    Private Sub LoadTodayStockIn()
        Dim total As Integer = 0
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT SUM(qty_added) FROM stockin_history WHERE DATE(date_in) = CURDATE()"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If Not IsDBNull(result) Then total = Convert.ToInt32(result)
                End Using
            End Using
            TotalStockInSum.Text = total.ToString()
        Catch ex As Exception
            MessageBox.Show("Error loading today's stock-in: " & ex.Message)
        End Try
    End Sub

    '==================== LOW STOCK TABLE ====================
    Private Sub LoadLowStock()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT SKU AS 'SKU', item_name AS 'Item Name', qty AS 'Quantity', catg AS 'Category' 
                                       FROM products WHERE qty <= 10 ORDER BY qty ASC"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DGV_LowStock.DataSource = table
            End Using

            StyleLowStockGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading low stock: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTodaySalesChart()
        Try
            Using conn As New MySqlConnection("server=localhost;port=3307;user id=root;password=;database=posinv;")
                conn.Open()

                Dim query = "
                SELECT DATE(transaction_time) AS sale_date, SUM(total) AS daily_total
                FROM sales_transactions
                WHERE DATE(transaction_time) = CURDATE()
                GROUP BY DATE(transaction_time)
            "

                Dim cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader()

                Chart1.Series("Sales").Points.Clear()

                While reader.Read()
                    Dim saleDate As Date = reader("sale_date")
                    Dim saleTotal As Decimal = reader("daily_total")

                    Chart1.Series("Sales").Points.AddXY(
                    saleDate.ToString("MM-dd"),
                    saleTotal
                )
                End While
            End Using

        Catch ex As Exception
            MsgBox("Error loading chart: " & ex.Message)
        End Try
    End Sub


    Private Sub dtFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtFrom.ValueChanged
        AutoLoadSalesChart()
    End Sub
    Private Sub dtTo_ValueChanged(sender As Object, e As EventArgs) Handles dtTo.ValueChanged
        AutoLoadSalesChart()
    End Sub
    Private Sub AutoLoadSalesChart()
        If dtFrom.Value.Date > dtTo.Value.Date Then Exit Sub
        LoadSalesChart()
    End Sub
    Private Sub LoadCurrentMonth()
        Dim today As Date = Date.Today


        dtFrom.Value = New Date(today.Year, today.Month, 1)
        dtTo.Value = dtFrom.Value.AddMonths(1).AddDays(-1)

        LoadSalesChart()
    End Sub


    Private Sub LoadSalesChart()
        Try
            Using conn = DBConnection.GetConnection()
            conn.Open()

            Dim query As String = "
                SELECT DATE(transaction_time) AS sale_date,
                       SUM(total) AS daily_total
                FROM sales_transactions
                WHERE transaction_time >= @dateFrom AND transaction_time <= @dateTo
                GROUP BY DATE(transaction_time)
                ORDER BY sale_date;
            "

            Using cmd As New MySqlCommand(query, conn)

                    Dim fromDt As DateTime = dtFrom.Value.Date
                    Dim toDt As DateTime = dtTo.Value.Date.AddDays(1).AddSeconds(-1)

                    cmd.Parameters.Add("@dateFrom", MySqlDbType.DateTime).Value = fromDt
                cmd.Parameters.Add("@dateTo", MySqlDbType.DateTime).Value = toDt

                Using reader = cmd.ExecuteReader()
                    Dim s = Chart1.Series("Sales")
                    s.Points.Clear()
                    s.ChartType = DataVisualization.Charting.SeriesChartType.SplineArea
                    s.BorderWidth = 2
                    s.IsValueShownAsLabel = False
                        s.ToolTip = "#VALX{MM-dd} : ₱ #VALY{N2}"



                        s.Color = Color.FromArgb(90, 90, 200)

                        While reader.Read()
                        Dim saleDate As DateTime = Convert.ToDateTime(reader("sale_date"))
                            Dim totalSales As Decimal = If(IsDBNull(reader("daily_total")), 0D, Convert.ToDecimal(reader("daily_total")))
                            s.Points.AddXY(saleDate, totalSales)
                        End While
                End Using
            End Using

                With Chart1.ChartAreas(0)
                    .BackColor = Color.White

                    .AxisX.MajorGrid.LineColor = Color.FromArgb(230, 230, 230)
                    .AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230)
                    .AxisX.LabelStyle.Font = New Font("Segoe UI", 9)
                    .AxisY.LabelStyle.Font = New Font("Segoe UI", 9)
                    .AxisX.LineColor = Color.FromArgb(200, 200, 200)
                    .AxisY.LineColor = Color.FromArgb(200, 200, 200)
                    .AxisX.LabelStyle.Format = "MM-dd"
                    .AxisX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Days
                    .AxisX.Interval = 1
                    .AxisX.MajorTickMark.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Days

                End With

                Dim series As Series = Chart1.Series("Sales")

                With series
                    .ChartType = SeriesChartType.SplineArea
                    .BorderWidth = 3
                    .BorderColor = Color.FromArgb(90, 120, 200)

                    ' Pastel blue gradient
                    .Color = Color.FromArgb(140, 180, 220)
                    .BackSecondaryColor = Color.FromArgb(220, 240, 255)
                    .BackGradientStyle = GradientStyle.TopBottom

                    .IsValueShownAsLabel = False
                    .MarkerStyle = MarkerStyle.None
                    .ToolTip = "#VALX : ₱ #VALY{N2}"
                End With



                If Chart1.Series("Sales").Points.Count > 0 Then
                Chart1.ChartAreas(0).RecalculateAxesScale()
            End If

        End Using

        Catch ex As Exception
            MessageBox.Show("Error loading sales chart: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadBestSellingCategories()

        Dim query As String =
        "SELECT p.catg AS category, SUM(sd.quantity) AS total_sold
         FROM sales_details sd
         INNER JOIN products p ON sd.item_id = p.id
         GROUP BY p.catg
         ORDER BY total_sold DESC;"

        Try
            Using conn = DBConnection.GetConnection
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)


                        chartBestCategory.Series.Clear()
                        chartBestCategory.Titles.Clear()

                        ' =================== SERIES ===================
                        Dim series As New Series("Best Selling Categories")
                        series.ChartType = SeriesChartType.Pie
                        series.XValueMember = "category"
                        series.YValueMembers = "total_sold"
                        series.Font = New Font("Segoe UI", 11, FontStyle.Bold)

                        series.Label = "#PERCENT{P0}"
                        series.LabelForeColor = Color.FromArgb(80, 80, 80)
                        series.LegendText = "#VALX"           ' category name
                        series.IsValueShownAsLabel = True

                        chartBestCategory.Series.Add(series)

                        ' =================== TITLE =====================
                        chartBestCategory.Titles.Add("BEST SELLING CATEGORIES")
                        chartBestCategory.Titles(0).Font = New Font("Segoe UI", 14, FontStyle.Bold)

                        ' =================== APPEARANCE ==================
                        chartBestCategory.ChartAreas(0).BackColor = Color.White


                        chartBestCategory.Palette = ChartColorPalette.SeaGreen

                        chartBestCategory.Legends(0).Enabled = True
                        chartBestCategory.Legends(0).Font = New Font("Segoe UI", 10)


                        chartBestCategory.DataSource = dt
                        chartBestCategory.DataBind()
                        Dim pastelColors As Color() = {
                            Color.FromArgb(168, 213, 186), ' soft green
                            Color.FromArgb(174, 198, 207), ' soft blue
                            Color.FromArgb(255, 223, 186), ' soft peach
                            Color.FromArgb(203, 195, 227), ' soft purple
                            Color.FromArgb(255, 204, 213), ' soft pink
                            Color.FromArgb(210, 225, 190)  ' soft olive
}

                        For i As Integer = 0 To series.Points.Count - 1
                            series.Points(i).Color = pastelColors(i Mod pastelColors.Length)
                        Next

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading chart: " & ex.Message)
        End Try

    End Sub

    Private Sub StyleLowStockGrid()

        With DGV_LowStock
            ' Structure
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .EnableHeadersVisualStyles = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True

            ' Background
            .BackgroundColor = Color.White
            .GridColor = Color.FromArgb(235, 235, 235)

            ' Header style
            .ColumnHeadersHeight = 38
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(210, 225, 245) ' pastel blue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Cell style
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.5)
            .DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 255) ' pastel selection
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Alternating rows (soft pastel)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 249, 255)

            ' Row height
            .RowTemplate.Height = 32
        End With

    End Sub

    Private Sub Guna2Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel6.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class