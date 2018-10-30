Public Class Parts
    Private Sub btnnbjk2_Click(sender As Object, e As EventArgs) Handles btncrystalgwv6.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Crystal"
        carjk2form.lblpart.Text = "Great White V6 Top Cowl"
        carjk2form.PictureBox1.Image = My.Resources.Great_White
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnnbjk4_Click(sender As Object, e As EventArgs) Handles btncrystalgwv8.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Crystal"
        carjk2form.lblpart.Text = "Great White V8 Top Cowl"
        carjk2form.PictureBox1.Image = My.Resources.Great_White
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnnbjl2_Click(sender As Object, e As EventArgs) Handles btncrystalbedrock.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Crystal"
        carjk2form.lblpart.Text = "BedRock Top Cowl"
        carjk2form.PictureBox1.Image = My.Resources.Bedrock
        Me.Close()
        CustomersForm.Close()

    End Sub

    Private Sub btnnbkenworth_Click(sender As Object, e As EventArgs) Handles btncrystalTiger.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Crystal"
        carjk2form.lblpart.Text = "Tiger Shark Top Cowl"
        carjk2form.PictureBox1.Image = My.Resources.Tigershark
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CustomersForm.Show()
        Me.Close()

    End Sub
End Class