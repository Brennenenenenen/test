Public Class CustomersForm
    'opens carey parts page

    'opens north baltimore parts page
    Private Sub btnNB_Click(sender As Object, e As EventArgs) Handles btnNB.Click
        NBPartsForm.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        loadform.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Adminform.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCrystal.Click
        Parts.Show()
        Me.Close()
    End Sub

    Private Sub CenterButton()
        btnCarrie.Top = (Me.ClientSize.Height / 2) - (btnCarrie.Height / 2)
        btnCarrie.Left = (Me.ClientSize.Width / 2) - (btnCarrie.Width / 2)
    End Sub

    Private Sub CustomersForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterButton()
    End Sub

    Private Sub CustomersForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterButton()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        hotmap.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        huningtonparts.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        CareyPartsForm.Show()
    End Sub

    Private Sub btnCarrie_Click(sender As Object, e As EventArgs) Handles btnCarrie.Click
        CareyPartsForm.Show()
        Me.Close()
    End Sub
End Class
