Public Class Adminform
    Public Sub changename()

        For Each c As Control In carjk2form.gbDefects.Controls
            If c.GetType Is GetType(RadioButton) Then
                If c.Text = combNames.SelectedItem Then
                    c.Text = TextBox1.Text
                    c.Enabled = True
                End If
            End If
        Next

        'For Each childcontrols As Control In Carjk2Form.Controls
        '    If childcontrols.GetType.Name = "GroupBox" Then
        '        Dim Tempgroupbox As GroupBox = childcontrols
        '        For Each subcontrols As Control In Tempgroupbox.Controls
        '            If subcontrols.GetType.Name = "RadioButton" Then
        '                Dim optrad As RadioButton = subcontrols
        '                If optrad.Text = combNames.SelectedItem Then
        '                    optrad.Text = TextBox1.Text
        '                End If
        '            End If
        '        Next
        '    End If
        'Next
    End Sub

    Public Sub removename()

        For Each c As Control In carjk2form.gbDefects.Controls
            If c.GetType Is GetType(RadioButton) Then
                If c.Text = combRemovename.SelectedItem Then
                    c.Text = "Spare"
                    c.Enabled = False
                End If
            End If
        Next

        'For Each childcontrols As Control In Carjk2Form.Controls
        '    If childcontrols.GetType.Name = "GroupBox" Then
        '        Dim Tempgroupbox As GroupBox = childcontrols
        '        For Each subcontrols As Control In Tempgroupbox.Controls
        '            If subcontrols.GetType.Name = "RadioButton" Then
        '                Dim optrad As RadioButton = subcontrols
        '                If optrad.Text = combRemovename.SelectedItem Then
        '                    optrad.Text = ""
        '                End If
        '            End If
        '        Next
        '    End If
        'Next
    End Sub


    'gets the names of all the buttons on the defects form
    Public Sub SetRadioButtonProperties()

        Try

            For Each c As Control In carjk2form.gbDefects.Controls
                If c.GetType Is GetType(RadioButton) Then
                    combNames.Items.Add(c.Text)
                    combRemovename.Items.Add(c.Text)
                End If
            Next



            'For Each childcontrols As Control In Carjk2Form.Controls
            '    If childcontrols.GetType.Name = "GroupBox" Then
            '        Dim Tempgroupbox As GroupBox = childcontrols
            '        For Each subcontrols As Control In Tempgroupbox.Controls
            '            If subcontrols.GetType.Name = "RadioButton" Then
            '                Dim optrad As RadioButton = subcontrols
            '                combNames.Items.Add(optrad.Text)
            '                combRemovename.Items.Add(optrad.Text)
            '            End If
            '        Next
            '    End If
            'Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveChange_Click(sender As Object, e As EventArgs) Handles btnSaveChange.Click
        changename()
        carjk2form.writebuttonnames()
        SetRadioButtonProperties()
        MessageBox.Show("Defects updated")
    End Sub

    Private Sub Adminform_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetRadioButtonProperties()
    End Sub

    Private Sub btnsaveremove_Click(sender As Object, e As EventArgs) Handles btnsaveremove.Click
        removename()
        carjk2form.writebuttonnames()
        SetRadioButtonProperties()
        MessageBox.Show("Defects updated")
    End Sub
End Class