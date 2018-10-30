Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class loadform

    Public cbcarey As SqlCommand
    ' Public connection As New SqlConnection()
    Public adptcar As SqlDataAdapter
    Public cartbl As New DataTable
    Public yeartbl As New DataTable
    Public temptbl As New DataTable

    Private Function mean()
        Dim average As Double = 0.0
        Dim dpi1 As Double = 0.0
        Dim dpi2 As Double = 0.0

        dpi1 = Val(txtbdpui1.Text)
        dpi2 = Val(txtbdpui2.Text)
        average = (dpi1 + dpi2) / 2
        txtbmean.Text = average.ToString
        Return average

    End Function

    'calculates the standard deviation
    Private Function standdev(average)
        Dim dpui1 As Double = 0.0
        Dim dpui2 As Double = 0.0
        Dim x, y As Double
        Dim sum As Double
        Dim stand As Double

        dpui1 = Val(txtbdpui1.Text)
        dpui2 = Val(txtbdpui2.Text)

        x = Math.Abs(average - dpui1)
        x = Math.Pow(x, 2)

        y = Math.Abs(average - dpui2)
        y = Math.Pow(y, 2)

        sum = (x + y)

        stand = Math.Sqrt(sum)

        Return stand

    End Function

    Private Function ucl(stand, average)
        Dim uclnum As Double
        uclnum = (3 * stand) + average
        Return uclnum
    End Function

    Private Function lcl(stand, average)
        Dim lclnum As Double
        lclnum = average - (3 * stand)
        Return lclnum
    End Function

    Private Sub txtbdpui1_TextChanged(sender As Object, e As EventArgs) Handles txtbdpui1.TextChanged
        mean()
        txtbstanddev.Text = standdev(mean())
        txtbucl.Text = ucl(standdev(mean()), mean())
        txtblcl.Text = lcl(standdev(mean()), mean())

    End Sub

    Private Sub txtbdpui2_TextChanged(sender As Object, e As EventArgs) Handles txtbdpui2.TextChanged
        mean()
        txtbstanddev.Text = standdev(mean())
        txtbucl.Text = ucl(standdev(mean()), mean())
        txtblcl.Text = lcl(standdev(mean()), mean())
    End Sub

    Private Sub yearlydpusearch()

        Try ' try to open the db

            initdb()
            cbcarey = New SqlCommand("Select * From dbo.tblCarey WHERE Date BETWEEN @StartDate AND @EndDate", connection)
            yeartbl.Clear()
            adptcar = New SqlDataAdapter(cbcarey)

            Dim date1 As New DateTime
            date1 = #01/01/2018#
            Dim date2 As DateTime
            date2 = #12/31/2018#

            'search by the date
            cbcarey.Parameters.Add("@StartDate", SqlDbType.Date).Value = date1
            cbcarey.Parameters.Add("@EndDate", SqlDbType.Date).Value = date2
            ' fill the datatable
            adptcar.Fill(yeartbl)

        Catch ex As Exception 'if there was an error connecting show an error message
            MessageBox.Show("Error: Yearly DPU Table Error " & ex.Message)
        End Try
        ' Close the connection
        closedb()

        Dim totalparts As Integer = yeartbl.Rows.Count
        txtbyearlytotal.Text = totalparts.ToString


        Dim ans As Object
        Dim total As Object = 0
        'counter variable for the column numbers of the data table =
        Dim counter As Integer = 6
        'for that runs through the groupbox on the load form page
        For Each c As Control In gbyearlytotal.Controls
            'string used in order to get the column number and not use the name of the coulmn
            Dim expression As String = "SUM(" + yeartbl.Columns(counter).ColumnName + ")"
            'if dbnull exit the for
            If yeartbl.Rows.Count = 0 Then
                Exit For
            Else
                'otherwise calculate the total and the weekly totals for all defects
                total += yeartbl.Compute(expression, "")
                ans = yeartbl.Compute(expression, "")
                'for to store the answers in the textboxes on the load form
                For count As Integer = 6 To yeartbl.Columns.Count - 1
                    If c.GetType Is GetType(TextBox) Then
                        c.Text = ans
                    End If
                Next
                'update the counter for the next coulmn of the data table
                counter += 1
                If counter = 31 Then
                    Exit For
                End If
            End If
        Next


        counter = 6
        For Each c As Control In gbyearlydpu.Controls
            'string used in order to get the column number and not use the name of the coulmn
            Dim expression As String = "SUM(" + yeartbl.Columns(counter).ColumnName + ")"
            'if dbnull exit the for
            If yeartbl.Rows.Count = 0 Then
                Exit For
            Else
                ans = yeartbl.Compute(expression, "")
                'for to store the answers in the textboxes on the load form
                For count As Integer = 6 To yeartbl.Columns.Count - 1
                    If c.GetType Is GetType(TextBox) Then

                        c.Text = Format(Double.Parse((ans / totalparts)), "#.##")
                    End If
                Next
                'update the counter for the next coulmn of the data table
                counter += 1
                If counter = 31 Then
                    Exit For
                End If
            End If
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        counter = 6
        Dim perctotal As Double = 0.00
        For Each c As Control In gpyearlyperctot.Controls
            'string used in order to get the column number and not use the name of the coulmn
            Dim expression As String = "SUM(" + yeartbl.Columns(counter).ColumnName + ")"
            'if dbnull exit the for
            If yeartbl.Rows.Count = 0 Then
                Exit For
            Else
                ans = yeartbl.Compute(expression, "")
                'for to store the answers in the textboxes on the load form
                For count As Integer = 6 To yeartbl.Columns.Count - 1
                    If c.GetType Is GetType(TextBox) Then
                        'error here ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        c.Text = Format(Double.Parse(((ans / total) * 100)), "#.##").ToString
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        ' c.Text = perctotal

                    End If
                Next
                'update the counter for the next coulmn of the data table
                counter += 1
                If counter = 31 Then
                    Exit For
                End If
            End If
        Next

    End Sub


    Public Sub search()


        temptbl.Clear()
        If Not temptbl.Columns.Contains("Weekly DPU") Then
            temptbl.Columns.Add("Weekly DPU")
        End If

        If Not temptbl.Columns.Contains("Weekly Total") Then
            temptbl.Columns.Add("Weekly Total")
        End If

        'gets the names of the part from the checkboxes on load form. 
        ' converts it into a usalable SQL select statment
        Dim Selstring As String = ""
        For Each c As Control In gbparts.Controls
            If c.GetType Is GetType(CheckBox) Then
                Dim cb As CheckBox = DirectCast(c, CheckBox)
                If cb.Checked = True Then
                    Selstring = Selstring & "part =  '" & c.Text & "'" & " OR "
                End If

            End If
        Next

        Dim SQL As String
        If Selstring.Length > 0 Then
            Selstring = Selstring.Substring(0, Selstring.Length - 3)
            SQL = "Select * From dbo.tblCarey WHERE Date BETWEEN @StartDate AND @EndDate AND " & Selstring
        Else
            SQL = "Select * From dbo.tblCarey WHERE Date BETWEEN @StartDate AND @EndDate"
        End If

        Try ' try to open the db

            initdb()
            cbcarey = New SqlCommand(SQL, connection)
            cartbl.Clear()
            adptcar = New SqlDataAdapter(cbcarey)

            'search by the date
            cbcarey.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtploadform.Value
            cbcarey.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtploadform.Value.AddDays(5)


            'fill the datatable
            adptcar.Fill(cartbl)

            'sub that calculates and fills daily defects
            dailydpu(gbmonday, 0)
            dailydpu(gbtuesday, 1)
            dailydpu(gbwednesday, 2)
            dailydpu(gbthursday, 3)
            dailydpu(gbFriday, 4)

            'function that adds daily defects and stores it into the correct textbox
            txtbmondayt.Text = rowcount(0).ToString
            txtbtuesdayt.Text = rowcount(1).ToString
            txtbwednesdayt.Text = rowcount(2).ToString
            txtbthursdayt.Text = rowcount(3).ToString
            txtbfridayt.Text = rowcount(4).ToString
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'calculates the daily dpu

            txtbmondpu.Text = (dailysum(gbmonday) / rowcount(0)).ToString
            txtbtuesdpu.Text = (dailysum(gbtuesday) / rowcount(1)).ToString
            txtbweddpu.Text = (dailysum(gbwednesday) / rowcount(2)).ToString
            txtbthursdpu.Text = (dailysum(gbthursday) / rowcount(3)).ToString
            txtbfridpu.Text = (dailysum(gbFriday) / rowcount(4)).ToString
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'calculate the total number of parts inspected
            Dim totalparts As Integer = cartbl.Rows.Count
            txtbtotalDefects.Text = totalparts.ToString

            Dim ans As Object
            Dim total As Object = 0
            'counter variable for the column numbers of the data table =
            Dim counter As Integer = 6
            'for that runs through the groupbox on the load form page
            For Each c As Control In gbwktotal.Controls
                'string used in order to get the column number and not use the name of the coulmn
                Dim expression As String = "SUM(" + cartbl.Columns(counter).ColumnName + ")"
                'if dbnull exit the for
                Dim row As DataRow = temptbl.NewRow
                If cartbl.Rows.Count = 0 Then
                    Exit For
                Else
                    'otherwise calculate the total and the weekly totals for all defects
                    total += cartbl.Compute(expression, "")
                    ans = cartbl.Compute(expression, "")

                    'for to store the answers in the textboxes on the load form
                    For count As Integer = 6 To cartbl.Columns.Count - 1

                        If c.GetType Is GetType(TextBox) Then
                            c.Text = ans
                        End If
                    Next


                    'update the counter for the next coulmn of the data table
                    counter += 1
                    'only needed tempararly in all loops for carey and NB
                    If counter = 32 Then
                        Exit For
                    End If
                End If
                row("Weekly Total") = Val(c.Text)
                temptbl.Rows.Add(row)
            Next

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            counter = 6
            For Each c As Control In gbweeklydpu.Controls
                'string used in order to get the column number and not use the name of the coulmn
                Dim expression As String = "SUM(" + cartbl.Columns(counter).ColumnName + ")"
                'if dbnull exit the for
                If cartbl.Rows.Count = 0 Then
                    Exit For
                Else
                    ans = cartbl.Compute(expression, "")

                    'for to store the answers in the textboxes on the load form
                    For count As Integer = 6 To cartbl.Columns.Count - 1
                        If c.GetType Is GetType(TextBox) Then

                            c.Text = Format(Double.Parse((ans / totalparts)), "#.##")

                        End If
                    Next
                    temptbl.Rows(counter - 6)("Weekly DPU") = Val(c.Text)
                    'update the counter for the next coulmn of the data table
                    counter += 1
                    If counter = 31 Then
                        Exit For
                    End If
                End If
            Next
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            counter = 6
            For Each c As Control In gbperctotal.Controls
                'string used in order to get the column number and not use the name of the coulmn
                Dim expression As String = "SUM(" + cartbl.Columns(counter).ColumnName + ")"
                'if dbnull exit the for
                If cartbl.Rows.Count = 0 Then
                    Exit For
                Else
                    ans = cartbl.Compute(expression, "")
                    'for to store the answers in the textboxes on the load form
                    For count As Integer = 6 To cartbl.Columns.Count - 1
                        If c.GetType Is GetType(TextBox) Then
                            c.Text = Format(Double.Parse(((ans / total) * 100)), "#.##")

                        End If
                    Next
                    'update the counter for the next coulmn of the data table
                    counter += 1
                    If counter = 31 Then
                        Exit For
                    End If
                End If
            Next

            '  DataGridView1.DataSource = temptbl


        Catch ex As Exception 'if there was an error connecting show an error message
            MessageBox.Show("Error: Weekly DPU Table Error: " & ex.Message & vbNewLine & ex.StackTrace)
        End Try
        'close the connection
        closedb()
    End Sub

    Private Function dailysum(groupbox As GroupBox)
        Dim daysum As Integer = 0
        For Each c As Control In groupbox.Controls
            If c.GetType Is GetType(TextBox) Then
                If Not IsDBNull(c.Text) Then
                    daysum += Val(c.Text)
                End If
            End If
        Next
        Return daysum
        Console.WriteLine("Daysum = " & daysum)
    End Function



    Private Function rowcount(i As Integer)
        Dim n As Integer = 0
        Dim day As String = dtploadform.Value.AddDays(i).ToString("yyyy-MM-dd")

        Dim result() As DataRow = cartbl.Select("Date = #" & day & "#")

        For Each row As DataRow In result
            n += 1
        Next
        Return n

    End Function

    Private Sub dailydpu(groupbox As GroupBox, i As Integer)
        Dim n As Integer = 6 'this number is the start of the defects from the tbl in sql
        Dim sum As Object
        Dim day As String = dtploadform.Value.AddDays(i).ToString("yyyy-MM-dd")
        For Each c As Control In groupbox.Controls
            Dim expression As String = "SUM(" + cartbl.Columns(n).ColumnName + ")"
            If cartbl.Rows.Count = 0 Then
                c.Text = ""
            Else
                sum = cartbl.Compute(expression, "Date = #" & day & "#")
                For count As Integer = 6 To cartbl.Columns.Count - 1
                    If c.GetType Is GetType(TextBox) Then
                        c.Text = sum.ToString
                    End If
                Next
                'update the counter for the next coulmn of the data table
                n += 1
                If n = 31 Then
                    Exit Sub

                End If
            End If
        Next
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        dtploadform.Value = dtploadform.Value.AddDays(-7)
        clear()
        search()
    End Sub

    Private Sub btnforward_Click_1(sender As Object, e As EventArgs) Handles btnforward.Click
        dtploadform.Value = dtploadform.Value.AddDays(7)
        clear()
        search()
    End Sub


    Private Sub loadform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddefectnames()
        'dtploadform_ValueChanged_1(sender, e)
        search()
        'makes sure that all the lables are aligned correctly
        For Each c As Label In gbdefects.Controls
            If c.GetType Is GetType(Label) Then
                c.TextAlign = ContentAlignment.TopRight
            End If
        Next

        For Each d As Label In gbyearlydefects.Controls
            If d.GetType Is GetType(Label) Then
                d.TextAlign = ContentAlignment.TopRight
            End If
        Next
    End Sub

    Private Sub dtploadform_ValueChanged_1(sender As Object, e As EventArgs) Handles dtploadform.ValueChanged
        'will only allow the user to pick monday
        dtploadform.Value = dtploadform.Value.AddDays(DayOfWeek.Tuesday - (dtploadform.Value.DayOfWeek + 1))
        clear()
        search()

        yearlydpusearch()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

        PrintForm1.Form = Me
        PrintForm1.PrintAction = PrintAction.PrintToPreview
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
    End Sub

    Private Sub loaddefectnames()
        Dim cmd As New SqlCommand
        Dim adpt As SqlDataAdapter
        Dim tbl As New DataTable

        'connect to the database
        Try
            initdb()

            cmd = New SqlCommand("Select * From dbo.Defect_Names WHERE location = 'Carey'", connection)

            adpt = New SqlDataAdapter(cmd)
            adpt.Fill(tbl)

            'loads the buttons names from the sql db
            Dim count As Integer = tbl.Rows.Count - 1
            For Each c As Control In gbdefects.Controls
                If c.GetType Is GetType(Label) Then
                    c.Text = CType(tbl.Rows(count)("Defect"), String)
                End If
                count -= 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading defect names: " & ex.Message)
        End Try
        closedb()
    End Sub

    Private Sub btnchart_Click_1(sender As Object, e As EventArgs) Handles btnchart.Click
        chartform.Show()

    End Sub

    Private Sub btncustomers_Click(sender As Object, e As EventArgs) Handles btncustomers.Click
        CustomersForm.Show()
        Me.Close()
    End Sub


    Private Sub clear()
        For Each c As Control In gbmonday.Controls
            c.Text = ""
        Next

        For Each c As Control In gbtuesday.Controls
            c.Text = ""
        Next

        For Each c As Control In gbwednesday.Controls
            c.Text = ""
        Next

        For Each c As Control In gbthursday.Controls
            c.Text = ""
        Next

        For Each c As Control In gbFriday.Controls
            c.Text = ""
        Next

        For Each c As Control In gbwktotal.Controls
            c.Text = ""
        Next

        For Each c As Control In gbweeklydpu.Controls
            c.Text = ""
        Next

        For Each c As Control In gbperctotal.Controls
            c.Text = ""
        Next

    End Sub

    Private Sub btnparts_Click(sender As Object, e As EventArgs) Handles btnparts.Click
        huningtonparts.Show()
        Me.Close()
    End Sub
    'see if i can group these into one function call

    Private Sub cbhatch_CheckedChanged(sender As Object, e As EventArgs) Handles cbhatch.CheckedChanged
        clear()
        cartbl.Clear()
        temptbl.Clear()
        search()
    End Sub

    Private Sub cbdecklid_CheckedChanged(sender As Object, e As EventArgs) Handles cbdecklid.CheckedChanged
        clear()
        cartbl.Clear()
        temptbl.Clear()
        search()
    End Sub

    Private Sub cblfender_CheckedChanged(sender As Object, e As EventArgs) Handles cblfender.CheckedChanged
        clear()
        cartbl.Clear()
        temptbl.Clear()
        search()
    End Sub

    Private Sub cbrfender_CheckedChanged(sender As Object, e As EventArgs) Handles cbrfender.CheckedChanged
        clear()
        cartbl.Clear()
        temptbl.Clear()
        search()
    End Sub

    Private Sub cbldoor_CheckedChanged(sender As Object, e As EventArgs) Handles cbldoor.CheckedChanged
        clear()
        cartbl.Clear()
        temptbl.Clear()
        search()
    End Sub

    Private Sub cbrdoor_CheckedChanged(sender As Object, e As EventArgs) Handles cbrdoor.CheckedChanged
        clear()
        cartbl.Clear()
        temptbl.Clear()
        search()
    End Sub
End Class