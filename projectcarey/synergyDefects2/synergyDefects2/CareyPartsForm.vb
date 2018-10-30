Public Class CareyPartsForm
    Private Sub btncarhome_Click(sender As Object, e As EventArgs) Handles btncarhome.Click
        CustomersForm.Show()
        Me.Close()
    End Sub

    Private Sub btncarjk2_Click(sender As Object, e As EventArgs) Handles btncarjk2.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Carey"
        carjk2form.lblpart.Text = "Jeep JK 2 Door"
        carjk2form.PictureBox1.Image = My.Resources.jeep
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btncarjk4_Click(sender As Object, e As EventArgs) Handles btncarjk4.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Carey"
        carjk2form.lblpart.Text = "Jeep JK 4 Door"
        carjk2form.PictureBox1.Image = My.Resources.jeep
        Me.Close()
        CustomersForm.Close()

    End Sub

    Private Sub bncarjl2_Click(sender As Object, e As EventArgs) Handles bncarjl2.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Carey"
        carjk2form.lblpart.Text = "Jeep JL 2 Door"
        carjk2form.PictureBox1.Image = My.Resources.jeep
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btncarjl4_Click(sender As Object, e As EventArgs) Handles btncarjl4.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Carey"
        carjk2form.lblpart.Text = "Jeep JL 4 Door"
        carjk2form.PictureBox1.Image = My.Resources.jeep
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btncarKen_Click(sender As Object, e As EventArgs) Handles btncarKen.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Carey"
        carjk2form.lblpart.Text = "Kenworth Fenders"
        carjk2form.PictureBox1.Image = My.Resources.kenworth
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnCarHino_Click(sender As Object, e As EventArgs) Handles btnCarHino.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Carey"
        carjk2form.lblpart.Text = "Hino Fenders"
        carjk2form.PictureBox1.Image = My.Resources.hino
        Me.Close()
        CustomersForm.Close()
    End Sub
End Class