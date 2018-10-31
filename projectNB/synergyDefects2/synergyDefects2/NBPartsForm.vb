Public Class NBPartsForm
    Private Sub btnnbjk2_Click(sender As Object, e As EventArgs) Handles btnnbjk2.Click
        carjk2form.Show()
        carjk2form.PictureBox1.Image = My.Resources.jeep
        carjk2form.lbllocation.Text = "North Baltimore"
        carjk2form.lblpart.Text = "Jeep JK 2 Door"
        Me.Close()
    End Sub

    Private Sub btnnbjk4_Click(sender As Object, e As EventArgs) Handles btnnbjk4.Click
        carjk2form.Show()
        carjk2form.PictureBox1.Image = My.Resources.jeep
        carjk2form.lbllocation.Text = "North Baltimore"
        carjk2form.lblpart.Text = "Jeep JK 4 Door"
        Me.Close()
    End Sub

    Private Sub btnnbjl2_Click(sender As Object, e As EventArgs) Handles btnnbjl2.Click
        carjk2form.Show()
        carjk2form.PictureBox1.Image = My.Resources.jeep
        carjk2form.lbllocation.Text = "North Baltimore"
        carjk2form.lblpart.Text = "Jeep JL 2 Door"
        Me.Close()
    End Sub

    Private Sub btnnbjl4_Click(sender As Object, e As EventArgs) Handles btnnbjl4.Click
        carjk2form.Show()
        carjk2form.PictureBox1.Image = My.Resources.jeep
        carjk2form.lbllocation.Text = "North Baltimore"
        carjk2form.lblpart.Text = "Jeep JL 4 Door"
        Me.Close()
    End Sub

    Private Sub btnnbkenworth_Click(sender As Object, e As EventArgs) Handles btnnbkenworth.Click
        carjk2form.Show()
        carjk2form.PictureBox1.Image = My.Resources.kenworth
        carjk2form.lbllocation.Text = "North Baltimore"
        carjk2form.lblpart.Text = "Kenworth Fenders"
        Me.Close()
    End Sub

    Private Sub btnnbhino_Click(sender As Object, e As EventArgs) Handles btnnbhino.Click
        carjk2form.Show()
        carjk2form.PictureBox1.Image = My.Resources.hino
        carjk2form.lbllocation.Text = "North Baltimore"
        carjk2form.lblpart.Text = "Hino Fenders"
        Me.Close()
    End Sub

    Private Sub btnnbford_Click(sender As Object, e As EventArgs) Handles btnnbford.Click
        carjk2form.Show()
        carjk2form.PictureBox1.Image = My.Resources.ford
        carjk2form.lbllocation.Text = "North Baltimore"
        carjk2form.lblpart.Text = "Ford"
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CustomersForm.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        loadform.Show()
        Me.Close()
    End Sub
End Class