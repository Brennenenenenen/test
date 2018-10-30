Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Web

Public Class chartform
    Private chart1 As New Chart
    Private chart2 As New Chart
    Private chart3 As New Chart
    Private chartarea1 As New ChartArea
    Private chartarea2 As New ChartArea
    Private chartarea3 As New ChartArea

    Public gtable As New DataTable
    Public anualtbl As New DataTable
    Public dailytbl As New DataTable


    Private daGraph As SqlDataAdapter

    Private Sub dailydpu()

        chart3.ChartAreas.Clear()
        chart3.Series.Clear()
        chart3.Legends.Clear()


        chartarea3.Name = "ChartArea"
        chart3.ChartAreas.Add(chartarea3)
        chart3.Name = "Chart3"
        chart3.Titles.Add("Daily DPU")
        chart3.Titles(0).Text = "Daily DPU"
        chart3.Titles(0).Font = New System.Drawing.Font(Font.Bold, 18)
        chart3.TabIndex = 0
        chart3.Text = "Chart 3"
        chart3.Legends.Add(New Legend("L1"))
        chart3.Legends("L1").Alignment = StringAlignment.Center
        chart3.ChartAreas(0).AxisX.TitleFont = New System.Drawing.Font(Font.Bold, 18)
        chart3.ChartAreas(0).AxisY.TitleFont = New System.Drawing.Font(Font.Bold, 18)
        chart3.ChartAreas(0).AxisY.Title = "DPU"
        chart3.ChartAreas(0).AxisX.Title = "Date"

        dailytbl.Columns.Add("Date")
        dailytbl.Columns.Add("DPU")
        dailytbl.Columns.Add("UCL")
        dailytbl.Columns.Add("LCL")


        Dim row As DataRow = dailytbl.NewRow
        row("Date") = loadform.dtpdaily1.Value.Date.ToString("MM/dd/yyyy")
        dailytbl.Rows.Add(row)
        row = dailytbl.NewRow
        row("Date") = loadform.dtpdaily2.Value.Date.ToString("MM/dd/yyyy")
        dailytbl.Rows.Add(row)


        'add the dpui to the exisiting rows
        dailytbl.Rows(0)("DPU") = Val(loadform.txtbdpui1.Text)
        dailytbl.Rows(1)("DPU") = Val(loadform.txtbdpui2.Text)

        'add upper and lower control limits to the table
        dailytbl.Rows(0)("UCL") = Val(loadform.txtbucl.Text)
        dailytbl.Rows(1)("UCL") = Val(loadform.txtbucl.Text)
        dailytbl.Rows(0)("LCL") = Val(loadform.txtblcl.Text)
        dailytbl.Rows(1)("LCL") = Val(loadform.txtblcl.Text)



        chart3.DataSource = dailytbl

        Dim s1, s2, s3 As New Series

        With s1
            .XValueMember = "Date"
            .YValueMembers = "DPU"
            .Name = "DPUI"
            .ChartType = SeriesChartType.Spline
            .XValueType = ChartValueType.Date
            .YValueType = ChartValueType.Double
            .YAxisType = AxisType.Primary
        End With

        With s2
            .YValueMembers = "UCL"
            .Name = "Upper Limit"
            .ChartType = SeriesChartType.Line
            .XValueType = ChartValueType.Date
            .YValueType = ChartValueType.Double
        End With

        With s3
            .YValueMembers = "LCL"
            .Name = "Lower Limit"
            .ChartType = SeriesChartType.Line
            .XValueType = ChartValueType.Date
            .YValueType = ChartValueType.Double
        End With


        chart3.Series.Add(s1)
        chart3.Series.Add(s2)
        chart3.Series.Add(s3)

        Controls.Add(chart3)
        TabPage3.Controls.Add(chart3)
        chart3.Dock = DockStyle.Fill
        chart3.Series(0).BorderWidth = 3
        chart3.Series(1).BorderWidth = 3
        chart3.Series(2).BorderWidth = 3
        chart3.Series(1).Color = Color.Green
        chart3.Series(2).Color = Color.Red
        chart3.ChartAreas(0).AxisX.Interval = 1
        chart3.ChartAreas(0).BackColor = Color.AliceBlue
        chart3.BackColor = Color.AliceBlue
    End Sub

    Public Sub weeklydpu()

        chart1.Series.Clear()
        chart1.ChartAreas.Clear()
        chart1.Legends.Clear()
        chart1.Titles.Clear()
        chart1.Refresh()


        If gtable.Columns.Count = 0 Then
            gtable.Columns.Add("WeeklyDPU")
            gtable.Columns.Add("Defect")
            gtable.Columns.Add("PercTotal")
        End If

        gtable.Clear()

        'gets the weekly dpu values and stores them in gtable
        For Each c As Control In loadform.gbweeklydpu.Controls
            Dim rows As DataRow = gtable.NewRow
            If c.GetType Is GetType(TextBox) Then
                rows("WeeklyDPU") = c.Text
                gtable.Rows.Add(rows)
            End If
        Next

        'gets the names of all the defects and stores them in gtable
        Dim counter As Integer = 0
        For Each c As Control In loadform.gbdefects.Controls
            If c.GetType Is GetType(Label) Then
                gtable.Rows(counter)("Defect") = c.Text
            End If
            counter += 1
        Next

        'gets the percent total and stores it in gtable
        counter = 0
        For Each c As Control In loadform.gbperctotal.Controls
            If c.GetType Is GetType(TextBox) Then
                gtable.Rows(counter)("PercTotal") = c.Text
            End If
            counter += 1
        Next

        'deletes rows from the table that have no data 
        Dim i As Integer = (gtable.Rows.Count - 1)
        Do While (i >= 0)
            ' whatever your criteria is
            If (gtable.Rows(i)("WeeklyDPU").ToString = "") Then
                gtable.Rows(i).Delete()
            End If

            i -= 1
        Loop





        chartarea1.Name = "ChartArea"
        chart1.ChartAreas.Add(chartarea1)
        chart1.Name = "Chart1"
        chart1.Titles.Add("Weekly DPU")
        chart1.Titles.Add("Date")
        chart1.Titles(1).Text = loadform.dtploadform.Value.ToString("MM/dd/yyyy") & " - " & loadform.dtploadform.Value.AddDays(5).ToString("MM/dd/yyyy")
        chart1.Titles(1).Font = New System.Drawing.Font(Font.Bold, 14)
        chart1.Titles(0).Text = "Weekly DPU"
        chart1.Titles(0).Font = New System.Drawing.Font(Font.Bold, 18)
        chart1.TabIndex = 0
        chart1.Text = "Chart1"
        chart1.Legends.Add(New Legend("L1"))
        chart1.Legends("L1").Alignment = StringAlignment.Center
        chart1.ChartAreas(0).AxisX.TitleFont = New System.Drawing.Font(Font.Bold, 18)
        chart1.ChartAreas(0).AxisY.TitleFont = New System.Drawing.Font(Font.Bold, 18)
        chart1.ChartAreas(0).AxisY.Title = "DPU"
        chart1.ChartAreas(0).AxisX.Title = "Defect"

        Dim s1, s2 As New Series

        With s1
            .XValueMember = "Defect"
            .YValueMembers = "WeeklyDPU"
            .Name = "Weekly DPU"
            .ChartType = SeriesChartType.Spline
            .XValueType = ChartValueType.String
            .YValueType = ChartValueType.Double
            .YAxisType = AxisType.Primary
        End With

        With s2
            .YValueMembers = "PercTotal"
            .Name = "PercTotal"
            .ChartType = SeriesChartType.Column
            .XValueType = ChartValueType.String
            .YValueType = ChartValueType.Double
            .YAxisType = AxisType.Secondary

            .CustomProperties = "DrawingStyle = cylinder ,PixelPointWidth = 24"

        End With

        Dim lbl As New CustomLabel




        chart1.Series.Add(s1)
        chart1.Series.Add(s2)

        chart1.DataSource = gtable


        Controls.Add(chart1)
        TabPage1.Controls.Add(chart1)
        chart1.Dock = DockStyle.Fill
        chart1.Series(0).BorderWidth = 3
        chart1.ChartAreas(0).AxisX.Interval = 1
        chart1.ChartAreas(0).AxisY2.Interval = 10
        chart1.ChartAreas(0).AxisY2.Minimum = 0
        chart1.ChartAreas(0).AxisY2.Maximum = 100
        chart1.ChartAreas(0).BackColor = Color.AliceBlue
        chart1.BackColor = Color.AliceBlue


    End Sub


    Private Sub anualdpu()


        chart2.ChartAreas.Clear()
        chart2.Series.Clear()
        chart2.Legends.Clear()


        chartarea2.Name = "ChartArea"
        chart2.ChartAreas.Add(chartarea2)
        chart2.Name = "Chart1"
        chart2.Titles.Add("Annual DPU")
        chart2.Titles(0).Text = "Annual DPU"
        chart2.Titles(0).Font = New System.Drawing.Font(Font.Bold, 18)
        chart2.TabIndex = 0
        chart2.Text = "Chart1"
        chart2.Legends.Add(New Legend("L1"))
        chart2.Legends("L1").Alignment = StringAlignment.Center
        chart2.ChartAreas(0).AxisX.TitleFont = New System.Drawing.Font(Font.Bold, 18)
        chart2.ChartAreas(0).AxisY.TitleFont = New System.Drawing.Font(Font.Bold, 18)
        chart2.ChartAreas(0).AxisY.Title = "DPU"
        chart2.ChartAreas(0).AxisX.Title = "Defect"

        anualtbl.Columns.Add("AnualDPU")
        anualtbl.Columns.Add("Defect")
        anualtbl.Columns.Add("PercTotal")

        For Each c As Control In loadform.gbyearlydpu.Controls
            Dim rows As DataRow = anualtbl.NewRow
            If c.GetType Is GetType(TextBox) Then
                rows("AnualDPU") = c.Text
                anualtbl.Rows.Add(rows)
            End If
        Next

        Dim counter As Integer = 0
        For Each c As Control In loadform.gbdefects.Controls
            If c.GetType Is GetType(Label) Then
                anualtbl.Rows(counter)("Defect") = c.Text
            End If
            counter += 1
        Next


        counter = 0
        For Each c As Control In loadform.gpyearlyperctot.Controls
            If c.GetType Is GetType(TextBox) Then
                anualtbl.Rows(counter)("PercTotal") = c.Text
            End If
            counter += 1
        Next

        'deletes rows from the table that have no data 
        Dim i As Integer = (anualtbl.Rows.Count - 1)
        Do While (i >= 0)
            ' whatever your criteria is
            If (anualtbl.Rows(i)("AnualDPU").ToString = "") Then
                anualtbl.Rows(i).Delete()
            End If

            i -= 1
        Loop

        chart2.DataSource = anualtbl

        Dim s1, s2 As New Series

        With s1
            .XValueMember = "Defect"
            .YValueMembers = "AnualDPU"
            .Name = "Anual DPU"
            .ChartType = SeriesChartType.Spline
            .Color = Color.Red
            .XValueType = ChartValueType.String
            .YValueType = ChartValueType.Double
            .YAxisType = AxisType.Primary
        End With

        With s2
            .YValueMembers = "PercTotal"
            .Name = "PercTotal"
            .ChartType = SeriesChartType.Column
            .Color = Color.Blue
            .XValueType = ChartValueType.String
            .YValueType = ChartValueType.Double
            .YAxisType = AxisType.Secondary

            .CustomProperties = "DrawingStyle = cylinder ,PixelPointWidth = 24"
        End With



        chart2.Series.Add(s1)
        chart2.Series.Add(s2)

        Controls.Add(chart2)
        TabPage2.Controls.Add(chart2)
        chart2.Dock = DockStyle.Fill
        chart2.Series(0).BorderWidth = 3
        chart2.ChartAreas(0).AxisX.Interval = 1
        chart2.ChartAreas(0).AxisY2.Interval = 10
        chart2.ChartAreas(0).AxisY2.Minimum = 0
        chart2.ChartAreas(0).AxisY2.Maximum = 100
        chart2.ChartAreas(0).BackColor = Color.AliceBlue
        chart2.BackColor = Color.AliceBlue

    End Sub



    Private Sub chartform_Load(sender As Object, e As EventArgs) Handles Me.Load
        weeklydpu()
        'test
        Panel1.BackColor = Color.AliceBlue
        Me.BackColor = Color.AliceBlue
        TabPage1.BackColor = Color.AliceBlue
        TabPage2.BackColor = Color.AliceBlue

        anualdpu()
        dailydpu()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            dtpchart.Value = dtpchart.Value.AddDays(-7)
            loadform.dtploadform.Value = dtpchart.Value
            loadform.search()
            chartform_Load(Me, New System.EventArgs)
        End If
    End Sub

    Private Sub btnforward_Click(sender As Object, e As EventArgs) Handles btnforward.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            dtpchart.Value = dtpchart.Value.AddDays(7)
            loadform.dtploadform.Value = dtpchart.Value
            loadform.search()
            chart1.Series.Clear()
            chart1.ChartAreas.Clear()
            chart1.Legends.Clear()
            chart1.Titles.Clear()
            chart1.Refresh()
            weeklydpu()
        End If
    End Sub

    Private Sub dtpchart_ValueChanged(sender As Object, e As EventArgs) Handles dtpchart.ValueChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            dtpchart.Value = dtpchart.Value.AddDays(DayOfWeek.Tuesday - (dtpchart.Value.DayOfWeek + 1))
        End If
    End Sub



    Private Sub btnchartprint_Click(sender As Object, e As EventArgs) Handles btnchartprint.Click




        Dim pd As New System.Drawing.Printing.PrintDocument()
        ' Add the event handler, and then print 
        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        pd.DefaultPageSettings.Landscape = True
        Dim margins As New Printing.Margins(15, 15, 15, 15)
        pd.DefaultPageSettings.Margins = margins
        Dim result As DialogResult = PrintDialog1.ShowDialog()


        ' Print the document 
        If result = DialogResult.Cancel Then
            Exit Sub
        End If

        If result = DialogResult.OK Then

            chart1.ChartAreas(0).BackColor = Color.White
            chart1.BackColor = Color.White

            pd.Print()
        End If
        chart1.ChartAreas(0).BackColor = Color.AliceBlue
        chart1.BackColor = Color.AliceBlue


    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        ' Create and initialize print font 
        Dim printFont As New System.Drawing.Font("Arial", 10)
        ' Create Rectangle structure, used to set the position of the chart 
        Dim myRec As New System.Drawing.Rectangle(0, 0, 1100, 830)
        ' Draw a line of text, followed by the chart, and then another line of text 
        ' ev.Graphics.DrawString("Line before chart", printFont, Brushes.Black, 10, 10)


        chart1.Printing.PrintPaint(ev.Graphics, myRec)

        ' ev.Graphics.DrawString("Line after chart", printFont, Brushes.Black, 10, 200)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            chart1.Series(0).Points.Clear()
            chart1.Series(1).Points.Clear()

            gtable.DefaultView.Sort = "PercTotal ASC"
            gtable = gtable.DefaultView.ToTable

            chart1.DataSource = gtable
            chart1.Update()
            chart1.Refresh()

        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            chart2.Series(0).Points.Clear()
            chart2.Series(1).Points.Clear()

            anualtbl.DefaultView.Sort = "PercTotal ASC"
            anualtbl = anualtbl.DefaultView.ToTable

            chart2.DataSource = anualtbl
            chart2.Update()
            chart2.Refresh()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            chart1.Series(0).Points.Clear()
            chart1.Series(1).Points.Clear()

            gtable.DefaultView.Sort = "PercTotal DESC"
            gtable = gtable.DefaultView.ToTable

            chart1.DataSource = gtable
            chart1.Update()
            chart1.Refresh()

        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            chart2.Series(0).Points.Clear()
            chart2.Series(1).Points.Clear()

            anualtbl.DefaultView.Sort = "PercTotal DESC"
            anualtbl = anualtbl.DefaultView.ToTable

            chart2.DataSource = anualtbl
            chart2.Update()
            chart2.Refresh()

        End If

    End Sub
End Class