Imports Microsoft.VisualBasic.FileIO
Imports System.Linq
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class carjk2form

    Dim rectangles As New List(Of Rectangle)
    Dim hotmaptbl As New DataTable

    Dim count As Integer = -1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inithotmap()
        For n As Integer = 0 To PictureBox1.Width - 25 Step 25
            For m As Integer = 0 To PictureBox1.Height - 25 Step 25
                rectangles.Add(New Rectangle(n, m, 25, 25))
            Next
        Next

        Timer1.Enabled = True

    End Sub

    Private Sub inithotmap()
        Dim command As New SqlCommand
        Dim sqladpt As SqlDataAdapter

        initdb()
        command = New SqlCommand("Select * From dbo.Hotmap", connection)
        sqladpt = New SqlDataAdapter(command)
        sqladpt.Fill(hotmaptbl)

        hotmaptbl.Clear()
        closedb()
    End Sub

    'Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
    '    Dim i As Integer = rectangles.FindIndex(Function(r) r.Contains(e.Location))
    '    Select Case i
    '        Case 0
    '            ' MsgBox("Zone 1 clicked")
    '            PictureBox1_Click(sender, e)

    '        Case 1
    '            MsgBox("Zone 2 clicked")
    '        Case 2
    '            MsgBox("Zone 3 clicked")
    '        Case 3
    '            MsgBox("Zone 4 clicked")
    '        Case 4
    '            MsgBox("zone 5 clicked")
    '        Case 9
    '            MsgBox("zone 9")
    '        Case 10
    '            MsgBox("zone 10")
    '        Case 11
    '            MsgBox("zone 11")
    '    End Select
    'End Sub


    'draws the rectangles to be able to view them

    'Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
    '    'this is just for testing purposes
    '    'and can be removed in your code
    '    For Each r As Rectangle In rectangles
    '        e.Graphics.DrawRectangle(Pens.Black, r)
    '    Next
    'End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    Public defects_list As New List(Of List(Of Rectangle))


    Private Sub PictureBox1_Click(sender As Object, e As MouseEventArgs) Handles PictureBox1.Click
        Dim i As Integer = rectangles.FindIndex(Function(r) r.Contains(e.Location))
        'if statements ro draw dots if button is selected
        If rbtnDefect1.Checked = True Then
            If hotmaptbl.Rows.Count = 0 Then
                Dim rows As DataRow = hotmaptbl.NewRow
                rows("Adtech") = i
                rows("Date") = Date.Now
                rows("part") = lblpart.Text
                hotmaptbl.Rows.Add(rows)
                Defect1.Add(New Rectangle(e.X, e.Y, 4, 4))
            Else
                Dim rows As DataRow = hotmaptbl.NewRow
                rows("Adtech") = i
                rows("Date") = Date.Now
                rows("part") = lblpart.Text
                hotmaptbl.Rows.Add(rows)
                Defect1.Add(New Rectangle(e.X, e.Y, 4, 4))
            End If
            draw(e)
            txtb1.Text = Defect1.Count

        ElseIf rbtnDefect2.Checked = True Then

            If hotmaptbl.Rows.Count = 0 Then
                Dim rows As DataRow = hotmaptbl.NewRow
                rows("Beveled_Edge") = i
                rows("Date") = Date.Now
                rows("part") = lblpart.Text
                hotmaptbl.Rows.Add(rows)
                Defect2.Add(New Rectangle(e.X, e.Y, 4, 4))
            Else
                Dim rows As DataRow = hotmaptbl.NewRow
                rows("Beveled_Edge") = i
                rows("Date") = Date.Now
                rows("part") = lblpart.Text
                hotmaptbl.Rows.Add(rows)
                Defect2.Add(New Rectangle(e.X, e.Y, 4, 4))
            End If
            draw(e)
            txtb2.Text = Defect2.Count

        ElseIf rbtnDefect3.Checked = True Then
            Defect3.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb3.Text = Defect3.Count

        ElseIf rbtnDefect4.Checked = True Then
            Defect4.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb4.Text = Defect4.Count

        ElseIf rbtnDefect5.Checked = True Then
            defect5.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb5.Text = defect5.Count

        ElseIf rbtnDefect6.Checked = True Then
            defect6.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb6.Text = defect6.Count

        ElseIf rbtnDefect7.Checked = True Then
            defect7.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb7.Text = defect7.Count

        ElseIf rbtnDefect8.Checked = True Then
            defect8.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb8.Text = defect8.Count

        ElseIf rbtnDefect9.Checked = True Then
            defect9.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb9.Text = defect9.Count

        ElseIf rbtnDefect10.Checked = True Then
            defect10.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb10.Text = defect10.Count

        ElseIf rbtnDefect11.Checked = True Then
            defect11.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb11.Text = defect11.Count

        ElseIf rbtnDefect12.Checked = True Then
            defect12.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb12.Text = defect12.Count

        ElseIf rbtnDefect13.Checked = True Then
            defect13.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb13.Text = defect13.Count

        ElseIf rbtnDefect14.Checked = True Then
            defect14.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb14.Text = defect14.Count

        ElseIf rbtnDefect15.Checked = True Then
            defect15.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb15.Text = defect15.Count

        ElseIf rbtnDefect16.Checked = True Then
            defect16.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb16.Text = defect16.Count

        ElseIf rbtnDefect17.Checked = True Then
            defect17.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb17.Text = defect17.Count

        ElseIf rbtnDefect18.Checked = True Then
            defect18.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb18.Text = defect18.Count

        ElseIf rbtnDefect19.Checked = True Then
            defect19.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb19.Text = defect19.Count

        ElseIf rbtnDefect20.Checked = True Then
            defect20.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb20.Text = defect20.Count

        ElseIf rbtnDefect21.Checked = True Then
            defect21.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb21.Text = defect21.Count

        ElseIf rbtnDefect22.Checked = True Then
            defect22.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb22.Text = defect22.Count

        ElseIf rbtnDefect23.Checked = True Then
            defect23.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb23.Text = defect23.Count

        ElseIf rbtnDefect24.Checked = True Then
            defect24.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb24.Text = defect24.Count

        ElseIf rbtnDefect25.Checked = True Then
            defect25.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb25.Text = defect25.Count

        ElseIf rbtnDefect26.Checked = True Then
            defect26.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb26.Text = defect26.Count

        ElseIf rbtnDefect27.Checked = True Then
            defect27.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb27.Text = defect27.Count

        ElseIf rbtnDefect28.Checked = True Then
            defect28.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb28.Text = defect28.Count

        ElseIf rbtnDefect29.Checked = True Then
            defect29.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb29.Text = defect29.Count

        ElseIf rbtnDefect30.Checked = True Then
            defect30.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb30.Text = defect30.Count

        ElseIf rbtnDefect31.Checked = True Then
            defect31.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb31.Text = defect31.Count

        ElseIf rbtnDefect32.Checked = True Then
            defect32.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb32.Text = defect32.Count

        ElseIf rbtnDefect33.Checked = True Then
            defect33.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb33.Text = defect33.Count

        ElseIf rbtnDefect34.Checked = True Then
            defect34.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb34.Text = defect34.Count

        ElseIf rbtnDefect35.Checked = True Then
            defect35.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb35.Text = defect35.Count

        ElseIf rbtnDefect36.Checked = True Then
            defect36.Add(New Rectangle(e.X, e.Y, 4, 4))
            draw(e)
            txtb36.Text = defect36.Count
        End If

    End Sub
    'draws the dot based on x and y coords
    Private Sub draw(e As MouseEventArgs)
        ' Dim p As New System.Drawing.Pen(Color.Red, 4)
        Dim g As System.Drawing.Graphics
        g = PictureBox1.CreateGraphics
        g.DrawRectangle(Pens.Red, e.X, e.Y, 4, 4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Refresh()
        redraw()
    End Sub

    Private Sub redraw()
        Dim r As Rectangle
        Dim l As List(Of Rectangle)
        Dim str As String
        Dim index As Integer
        Dim index2 As Integer
        Dim g As System.Drawing.Graphics

        g = PictureBox1.CreateGraphics

        For Each c As Control In gbDefects.Controls
            If c.GetType Is GetType(RadioButton) Then
                Dim rb As RadioButton = DirectCast(c, RadioButton)
                If rb.Checked Then
                    str = Regex.Match(rb.Name, "\d+").Value
                    index = Convert.ToInt32(str)
                    index = index - 1
                    index2 = defects_list(index).Count

                    l = defects_list(index)
                    Try
                        r = l(index2 - 1)
                    Catch
                        MsgBox("Nothing to undo")
                    End Try
                    l.Remove(r)
                    Me.gbDefects.Controls("txtb" & index + 1).Text = defects_list(index).Count
                    Console.WriteLine()
                End If
            End If
        Next


    End Sub

    Private Sub btncheckall_Click(sender As Object, e As EventArgs) Handles btncheckall.Click
        For Each c As Control In gbDefects.Controls
            If c.GetType Is GetType(CheckBox) Then
                Dim cb As CheckBox = DirectCast(c, CheckBox)
                cb.Checked = True
            End If
        Next

        defect_select()
    End Sub

    Private Sub btnuncheckall_Click(sender As Object, e As EventArgs) Handles btnuncheckall.Click
        For Each c As Control In gbDefects.Controls
            If c.GetType Is GetType(CheckBox) Then
                Dim cb As CheckBox = DirectCast(c, CheckBox)
                cb.Checked = False
            End If
        Next

        defect_select()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Refresh()
        defect_select()
    End Sub

    Private Sub defect_select()

        add_lists()
        Dim g As System.Drawing.Graphics
        g = PictureBox1.CreateGraphics
        Dim str As String
        Dim index As Integer

        For Each c As Control In gbDefects.Controls
            If c.GetType Is GetType(CheckBox) Then
                Dim cb As CheckBox = DirectCast(c, CheckBox)
                If cb.Checked Then
                    str = Regex.Match(cb.Name, "\d+").Value
                    index = Convert.ToInt32(str)
                    index = index - 1

                    For Each d As Rectangle In defects_list.Item(index)
                        g.DrawRectangle(Pens.Red, d)
                    Next
                End If
            End If
        Next

    End Sub

    Private Sub loadbuttonnames()

        Dim cmd As New SqlCommand
        Dim adpt As SqlDataAdapter
        Dim tbl As New DataTable

        'connect to the database
        Try

            tbl.Clear()
            initdb()

            cmd = New SqlCommand("Select * From dbo.Defect_Names WHERE Location = 'NB'", connection)

            adpt = New SqlDataAdapter(cmd)
            adpt.Fill(tbl)

            'loads the buttons names from the sql db
            Dim count As Integer = 0

            For Each c As Control In gbDefects.Controls
                If c.GetType Is GetType(RadioButton) Then
                    c.Text = CType(tbl.Rows(count)("Defect"), String)
                    c.Enabled = tbl.Rows(count)("Enabled")
                    count += 1
                End If
            Next


        Catch ex As Exception
            MessageBox.Show("Error while reading defects: " & ex.Message)
        End Try
        closedb()
    End Sub

    Public Sub writebuttonnames()
        'create a new datatable
        Dim datatbl As New DataTable
        'create a column to store the defect names
        datatbl.Columns.Add("Name")
        datatbl.Columns.Add("Enabled")
        datatbl.Columns.Add("Location")

        ' Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        'connect to the database
        Try
            initdb()
            cmd.Connection = connection
            'set the commands for the columns to write to
            cmd.CommandText = "DELETE FROM Defect_Names"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "INSERT INTO dbo.Defect_Names(Enabled, Defect, Location) VALUES(@Enabled, @Defect, @Location)"

            'loop through the buttons in the groupbox
            'and store the names in the datatable
            Dim count As Integer = 1

            For Each c As Control In gbDefects.Controls
                If c.GetType Is GetType(RadioButton) Then
                    Dim row As DataRow = datatbl.NewRow
                    If c.Text = "" Then
                        row("name") = "spare" & count.ToString
                        row("Enabled") = False
                        row("Location") = "NB" 'lbllocation.Text
                        datatbl.Rows.Add(row)
                        count += 1
                    Else
                        row("Name") = c.Text
                        row("Enabled") = c.Enabled
                        row("Location") = "NB" 'lbllocation.Text
                        datatbl.Rows.Add(row)
                    End If
                End If
            Next



            'write the values to the sql table
            For Each row As DataRow In datatbl.Rows
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@Defect", SqlDbType.VarChar).Value = row("Name")
                cmd.Parameters.Add("@Enabled", SqlDbType.Bit).Value = row("Enabled")
                cmd.Parameters.Add("@Location", SqlDbType.VarChar).Value = row("location")
                cmd.ExecuteNonQuery()
            Next row
            'close the connection
        Catch ex As Exception
            MessageBox.Show("Error while writing defects: " & ex.Message)
        End Try
        closedb()

    End Sub

    Private Sub Carjk2Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadbuttonnames()
        'writebuttonnames()
    End Sub

    Private Sub Carjk2Form_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        writebuttonnames()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'go back to the customers page
        CustomersForm.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'check the label to open the correct form
        If lbllocation.Text = "Carey" Then
            CareyPartsForm.Show()
            Me.Close()
        ElseIf lbllocation.Text = "North Baltimore" Then
            NBPartsForm.Show()
            Me.Close()
        ElseIf lbllocation.Text = "Crystal" Then
            Parts.Show()
            Me.Close()
        ElseIf lbllocation.Text = "Huntington" Then
            huningtonparts.Show()
            Me.Close()

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Try
            initdb()

            Using bulkCopy As SqlBulkCopy = New SqlBulkCopy(connection)
                bulkCopy.DestinationTableName = "dbo.Hotmap"

                Try
                    ' Write from the source to the destination.
                    bulkCopy.WriteToServer(hotmaptbl)

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            closedb()
        End Try

        Try
            ' write the data to a csv sheet
            Dim objWriter As IO.StreamWriter = IO.File.AppendText("currentdate.csv")
            If IO.File.Exists("currentdate.csv") Then
                objWriter.Write(Date.Today.ToString("MM/dd/yy") & ",")
                objWriter.Write(txtbcarjk2serial.Text & ",")
                objWriter.Write(lbllocation.Text & ",")
                objWriter.Write(lblpart.Text & ",")
                If rbtncarjk2topcoat.Checked = True Then
                    objWriter.Write("Top Coat" & ",")
                Else
                    objWriter.Write("Prime" & ",")
                End If
                objWriter.Write(rbtnDefect1.Text & "," & txtb1.Text & ",")
                ' MessageBox.Show("File Saved.")
            End If
            objWriter.Close()
        Catch ex As Exception
        End Try

        'write to the database for carey tables

        Dim cmd As New SqlCommand
        Try
            'create the connection string for the db
            initdb()
            cmd.Connection = connection
            'set the commands for the columns to write to
            'possibly replace most of this with a for loop 
            cmd.CommandText = "INSERT INTO dbo.tblNorthBalt (Date, Part, Serial_num, Coat, Rework, Adtech, Bacteria, Beveled_edge, Blister, Bond, Booth_Water, Chain_Debris,
                                                            Chain_oil, Crack, Dried_Paint_Particulate, Etching, Fiber_Tear, Light_Paint, Jet_Water, Paint_sag_run, Pits_porosity, Pre_Gel, 
                                                            Sanding_Dig, Scratch_gouge, SMS_particulate, Solvent_Pop, Spits, Stress_Crack, Water_mark, Contamination_Water, Cotton_Fiber)
                                        VALUES(@Date, @Part, @Serial_num, @Coat, @Rework, @Adtech, @Bacteria, @Beveled_edge, @Blister, @Bond, @Booth_Water, @Chain_Debris,
                                                            @Chain_oil, @Crack, @Dried_Paint_Particulate, @Etching, @Fiber_Tear, @Light_Paint, @Jet_Water, @Paint_sag_run, @Pits_porosity, @Pre_Gel, 
                                                            @Sanding_Dig, @Scratch_gouge, @SMS_particulate, @Solvent_Pop, @Spits, @Stress_Crack, @Water_mark, @Contamination_Water, @Cotton_Fiber)"
            'tell the parameters what to write
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Date.Now()
            cmd.Parameters.Add("@Part", SqlDbType.VarChar).Value = lblpart.Text
            cmd.Parameters.Add("@Serial_num", SqlDbType.Int).Value = Convert.ToInt32(txtbcarjk2serial.Text)

            'was used for crystal 
            If rbtncarjk2topcoat.Checked Then
                cmd.Parameters.Add("@Coat", SqlDbType.VarChar).Value = "Top"
            ElseIf rbtncarjk2prime.Checked Then
                cmd.Parameters.Add("@Coat", SqlDbType.VarChar).Value = "Prime"
            End If
            ' ElseIf rbtnadpro.Checked Then
            '    cmd.Parameters.Add("@Coat", SqlDbType.VarChar).Value = "Adpro"
            ' End If

            If cbrework.Checked Then
                cmd.Parameters.Add("@Rework", SqlDbType.VarChar).Value = "Yes"
            Else
                cmd.Parameters.Add("@Rework", SqlDbType.VarChar).Value = "No"
            End If

            cmd.Parameters.Add("@Adtech", SqlDbType.Int).Value = Convert.ToInt32(txtb1.Text)
            cmd.Parameters.Add("@Bacteria", SqlDbType.Int).Value = Convert.ToInt32(txtb2.Text)
            cmd.Parameters.Add("@Beveled_edge", SqlDbType.Int).Value = Convert.ToInt32(txtb3.Text)
            cmd.Parameters.Add("@Blister", SqlDbType.Int).Value = Convert.ToInt32(txtb4.Text)
            cmd.Parameters.Add("@Bond", SqlDbType.Int).Value = Convert.ToInt32(txtb5.Text)
            cmd.Parameters.Add("@Booth_Water", SqlDbType.Int).Value = Convert.ToInt32(txtb6.Text)
            cmd.Parameters.Add("@Chain_Debris", SqlDbType.Int).Value = Convert.ToInt32(txtb7.Text)
            cmd.Parameters.Add("@Chain_oil", SqlDbType.Int).Value = Convert.ToInt32(txtb8.Text)
            cmd.Parameters.Add("@Crack", SqlDbType.Int).Value = Convert.ToInt32(txtb9.Text)
            cmd.Parameters.Add("@Dried_Paint_Particulate", SqlDbType.Int).Value = Convert.ToInt32(txtb10.Text)
            cmd.Parameters.Add("@Etching", SqlDbType.Int).Value = Convert.ToInt32(txtb11.Text)
            cmd.Parameters.Add("@Fiber_Tear", SqlDbType.Int).Value = Convert.ToInt32(txtb12.Text)
            cmd.Parameters.Add("@Light_Paint", SqlDbType.Int).Value = Convert.ToInt32(txtb13.Text)
            cmd.Parameters.Add("@Jet_Water", SqlDbType.Int).Value = Convert.ToInt32(txtb14.Text)
            cmd.Parameters.Add("@Paint_sag_run", SqlDbType.Int).Value = Convert.ToInt32(txtb15.Text)
            cmd.Parameters.Add("@Pits_porosity", SqlDbType.Int).Value = Convert.ToInt32(txtb16.Text)

            cmd.Parameters.Add("@Pre_Gel", SqlDbType.Int).Value = Convert.ToInt32(txtb17.Text)
            cmd.Parameters.Add("@Sanding_Dig", SqlDbType.Int).Value = Convert.ToInt32(txtb18.Text)
            cmd.Parameters.Add("@Scratch_gouge", SqlDbType.Int).Value = Convert.ToInt32(txtb19.Text)

            cmd.Parameters.Add("@SMS_particulate", SqlDbType.Int).Value = Convert.ToInt32(txtb20.Text)
            cmd.Parameters.Add("@Solvent_Pop", SqlDbType.Int).Value = Convert.ToInt32(txtb21.Text)
            cmd.Parameters.Add("@Spits", SqlDbType.Int).Value = Convert.ToInt32(txtb22.Text)
            cmd.Parameters.Add("@Stress_Crack", SqlDbType.Int).Value = Convert.ToInt32(txtb23.Text)
            cmd.Parameters.Add("@Water_mark", SqlDbType.Int).Value = Convert.ToInt32(txtb24.Text)
            cmd.Parameters.Add("@Contamination_Water", SqlDbType.Int).Value = Convert.ToInt32(txtb25.Text)
            cmd.Parameters.Add("@Cotton_Fiber", SqlDbType.Int).Value = Convert.ToInt32(txtb26.Text)
            'used for huntington
            'cmd.Parameters.Add("@Scratch", SqlDbType.Int).Value = Convert.ToInt32(txtb27.Text)
            'cmd.Parameters.Add("@SMC_Particulate", SqlDbType.Int).Value = Convert.ToInt32(txtb28.Text)
            'cmd.Parameters.Add("@Spits", SqlDbType.Int).Value = Convert.ToInt32(txtb30.Text)
            'cmd.Parameters.Add("@Stress_Crack", SqlDbType.Int).Value = Convert.ToInt32(txtb31.Text)
            'cmd.Parameters.Add("@Tiger_Strips", SqlDbType.Int).Value = Convert.ToInt32(txtb32.Text)
            'cmd.Parameters.Add("@Water_Contamination", SqlDbType.Int).Value = Convert.ToInt32(txtb33.Text)
            'cmd.Parameters.Add("@Water_Jet_Residue", SqlDbType.Int).Value = Convert.ToInt32(txtb34.Text)
            'cmd.Parameters.Add("@Water_Marks", SqlDbType.Int).Value = Convert.ToInt32(txtb35.Text)

            'cmd.Parameters.Add("@Water_Streaks", SqlDbType.Int).Value = Convert.ToInt32(txtb36.Text)
            'cmd.Parameters.Add("@Solvent_Pop", SqlDbType.Int).Value = Convert.ToInt32(txtb29.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("File saved to Database")

        Catch ex As Exception
            MessageBox.Show("Database error while writing to the table: " & ex.Message)
        Finally
            closedb()
        End Try



    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        'test to show the loadable data
        loadform.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Adminform.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        PictureBox1.Refresh()
        reset()
        txtbcarjk2serial.Text = "0000"
        Dim a As Control
        For Each a In gbDefects.Controls
            If TypeOf a Is TextBox Then
                a.Text = "0"
            End If
        Next

        hotmaptbl.Clear()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If lblpart.Text = "Corvette Hatch" Then
            PictureBox1.Image = My.Resources.corevetteleftfender
            lblpart.Text = "Corvette Left Fender"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Left Fender" Then
            PictureBox1.Image = My.Resources.corvetterightfender
            lblpart.Text = "Corvette Right Fender"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Right Fender" Then
            PictureBox1.Image = My.Resources.corvetteleftdoor
            lblpart.Text = "Corvette Left Door"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Left Door" Then
            PictureBox1.Image = My.Resources.corvetterightdoor
            lblpart.Text = "Corvette Right Door"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Right Door" Then
            PictureBox1.Image = My.Resources.corvettedeck
            lblpart.Text = "Corvette Decklid"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Decklid" Then
            PictureBox1.Image = My.Resources.corvettelatch
            lblpart.Text = "Corvette Hatch"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next
        End If

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If lblpart.Text = "Corvette Hatch" Then
            PictureBox1.Image = My.Resources.corvettedeck
            lblpart.Text = "Corvette Decklid"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Decklid" Then
            PictureBox1.Image = My.Resources.corvetterightdoor
            lblpart.Text = "Corvette Right Door"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Right Door" Then
            PictureBox1.Image = My.Resources.corvetteleftdoor
            lblpart.Text = "Corvette Left Door"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Left Door" Then
            PictureBox1.Image = My.Resources.corvetterightfender
            lblpart.Text = "Corvette Right Fender"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Right Fender" Then
            PictureBox1.Image = My.Resources.corevetteleftfender
            lblpart.Text = "Corvette Left Fender"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next

        ElseIf lblpart.Text = "Corvette Left Fender" Then
            PictureBox1.Image = My.Resources.corvettelatch
            lblpart.Text = "Corvette Hatch"
            reset()
            txtbcarjk2serial.Text = "0000"
            Dim a As Control
            For Each a In gbDefects.Controls
                If TypeOf a Is TextBox Then
                    a.Text = "0"
                End If
            Next
        End If
    End Sub


End Class