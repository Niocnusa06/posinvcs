Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class _1dashboard



    Private Sub _1dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTodaySales()
        LoadTodayStockIn()
        LoadLowStock()
        LoadTodaySalesChart()
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

            ' Style the grid
            DGV_LowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DGV_LowStock.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            DGV_LowStock.DefaultCellStyle.Font = New Font("Segoe UI", 9)
            DGV_LowStock.RowTemplate.Height = 25

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


    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
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
                ' Use DateTime parameters (beginning and end of day)
                Dim fromDt As DateTime = dtFrom.Value.Date ' 00:00:00
                Dim toDt As DateTime = dtTo.Value.Date.AddDays(1).AddSeconds(-1) ' 23:59:59

                cmd.Parameters.Add("@dateFrom", MySqlDbType.DateTime).Value = fromDt
                cmd.Parameters.Add("@dateTo", MySqlDbType.DateTime).Value = toDt

                Using reader = cmd.ExecuteReader()
                    Dim s = Chart1.Series("Sales")
                    s.Points.Clear()
                    s.ChartType = DataVisualization.Charting.SeriesChartType.SplineArea
                    s.BorderWidth = 2
                    s.IsValueShownAsLabel = False
                    s.ToolTip = "#VALX : ₱ #VALY{N2}"


                        s.Color = Color.FromArgb(90, 90, 200)

                        While reader.Read()
                        Dim saleDate As DateTime = Convert.ToDateTime(reader("sale_date"))
                            Dim totalSales As Decimal = If(IsDBNull(reader("daily_total")), 0D, Convert.ToDecimal(reader("daily_total")))
                            s.Points.AddXY(saleDate.ToOADate(), totalSales)
                    End While
                End Using
            End Using


                With Chart1.ChartAreas(0)
                .AxisX.LabelStyle.Format = "MM-dd"
                .AxisX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Days
                .AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220)
                .AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220)
                .BackColor = Color.White
            End With


                Dim series As Series = Chart1.Series("Sales")
                With series
                    .ChartType = SeriesChartType.Area
                    .Color = Color.FromArgb(120, 100, 180, 240) ' main fill
                    .BackSecondaryColor = Color.FromArgb(120, 140, 200, 255)
                    .BackGradientStyle = GradientStyle.TopBottom
                    .BorderColor = Color.FromArgb(60, 90, 160)
                    .BorderWidth = 2

                    .IsValueShownAsLabel = False
                    .MarkerStyle = MarkerStyle.None
                    .CustomProperties = "AreaDrawingStyle=Gradient"
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

                        series.Label = "#PERCENT{P2}"         ' % value
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
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading chart: " & ex.Message)
        End Try

    End Sub


End Class