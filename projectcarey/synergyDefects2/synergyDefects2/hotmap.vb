Imports System.Data.SqlClient

Public Class hotmap
    Dim rectangles As New List(Of Rectangle)
    Dim defect As String


    Private Sub hotmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For n As Integer = 0 To PictureBox1.Width - 25 Step 25
            For m As Integer = 0 To PictureBox1.Height - 25 Step 25
                rectangles.Add(New Rectangle(n, m, 25, 25))
            Next
        Next
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CustomersForm.Show()
        Me.Close()
    End Sub


    Dim zone As Integer = 0
    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        If rbtnDefect1.Checked = True Then
            defect = "Adtech"
            draw()

        ElseIf rbtnDefect2.Checked = True Then
            defect = "Beveled_Edge"
            draw()



        End If
    End Sub

    Dim dt As New DataTable

    Private Sub loadhotmap()

        Dim command As New SqlCommand
        Dim sqladpt As SqlDataAdapter


        initdb()
        command = New SqlCommand("Select * From dbo.Hotmap WHERE Date BETWEEN @StartDate AND @EndDate AND Part = @part", connection)

        sqladpt = New SqlDataAdapter(command)

        'search by the date
        command.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtphotmap1.Value
        command.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtphotmap2.Value
        command.Parameters.Add("@part", SqlDbType.VarChar).Value = ComboBox1.SelectedItem & " Top Cowl"
        'fill the datatable
        sqladpt.Fill(dt)


        closedb()



        ' Dim distinctDT As DataTable = dt.DefaultView.ToTable(True, "296")
        ' MsgBox(distinctDT.Rows.Count)

    End Sub

    Private Sub draw()
        Dim blueBrush As New SolidBrush(Color.FromArgb(128, 255, 0, 0))

        If rbtnDefect1.Checked = True Then
            defect = "Adtech"

        ElseIf rbtnDefect2.Checked = True Then
            defect = "Beveled_Edge"

        End If

        Dim g As System.Drawing.Graphics
        g = PictureBox1.CreateGraphics

        For Each dr As DataRow In dt.Rows
            If Not IsDBNull(dr.Item(defect)) Then

                If dr.Item(defect) > -1 Then
                    zone = dr.Item(defect)
                    g.FillRectangle(blueBrush, rectangles.Item(zone))
                End If
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, ByVal e As MouseEventArgs) Handles Button1.Click
        PictureBox1.Refresh()
        dt.Clear()
        loadhotmap()
        draw()
        ' test()
        Console.WriteLine(rectangles.Count.ToString)
    End Sub

    Private Sub test()
        Dim array(30, 384) As String

        'fill array with -1 to not indicate a zone
        For i As Integer = 0 To array.GetUpperBound(0)
            For j As Integer = 0 To array.GetUpperBound(1)
                array(i, j) = -1
            Next
        Next

        'print array
        For i As Integer = 0 To array.GetUpperBound(0)
            For j As Integer = 0 To array.GetUpperBound(1)
                '  Console.WriteLine(array(i, j))
            Next
        Next
    End Sub


    Private Sub GetRowsBy()

        Dim table As DataTable = dt

        ' Presuming the DataTable has a column named Date.
        Dim expression As String
        expression = "Adtech > 200"
        Dim foundRows() As DataRow

        ' Use the Select method to find all rows matching the filter.
        foundRows = table.Select(expression)

        Dim i As Integer
        ' Print column 0 of each returned row.
        For i = 0 To foundRows.GetUpperBound(0)
            Console.WriteLine(foundRows(i)(0))
        Next i
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Great White V6" Then
            PictureBox1.Image = My.Resources.Great_White
        ElseIf ComboBox1.SelectedItem = "Great White V8" Then
            PictureBox1.Image = My.Resources.Great_White
        ElseIf ComboBox1.SelectedItem = "BedRock" Then
            PictureBox1.Image = My.Resources.Bedrock
        ElseIf ComboBox1.SelectedItem = "Tiger Shark" Then
            PictureBox1.Image = My.Resources.Tigershark
        End If
    End Sub
End Class