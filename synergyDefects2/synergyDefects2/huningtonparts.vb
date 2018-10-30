Public Class huningtonparts
    Private Sub btncorvhatch_Click(sender As Object, e As EventArgs) Handles btncorvhatch.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Huntington"
        carjk2form.lblpart.Text = "Corvette Hatch"
        carjk2form.PictureBox1.Image = My.Resources.corvettelatch
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnhuncorvdeck_Click(sender As Object, e As EventArgs) Handles btnhuncorvdeck.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Huntington"
        carjk2form.lblpart.Text = "Corvette Decklid"
        carjk2form.PictureBox1.Image = My.Resources.corvettedeck
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnhuncorvrfender_Click(sender As Object, e As EventArgs) Handles btnhuncorvrfender.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Huntington"
        carjk2form.lblpart.Text = "Corvette Right Fender"
        carjk2form.PictureBox1.Image = My.Resources.corvetterightfender
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnhuncorvlfender_Click(sender As Object, e As EventArgs) Handles btnhuncorvlfender.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Huntington"
        carjk2form.lblpart.Text = "Corvette Left Fender"
        carjk2form.PictureBox1.Image = My.Resources.corevetteleftfender
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnhuncorvrdoor_Click(sender As Object, e As EventArgs) Handles btnhuncorvrdoor.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Huntington"
        carjk2form.lblpart.Text = "Corvette Right Door"
        carjk2form.PictureBox1.Image = My.Resources.corvetterightdoor
        Me.Close()
        CustomersForm.Close()
    End Sub

    Private Sub btnhuncorvldoor_Click(sender As Object, e As EventArgs) Handles btnhuncorvldoor.Click
        carjk2form.Show()
        carjk2form.lbllocation.Text = "Huntington"
        carjk2form.lblpart.Text = "Corvette Left Door"
        carjk2form.PictureBox1.Image = My.Resources.corvetteleftdoor
        Me.Close()
        CustomersForm.Close()
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