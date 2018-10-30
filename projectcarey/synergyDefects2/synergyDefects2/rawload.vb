Imports System.Data.SqlClient

Public Class rawload
    Public cbcarey As SqlCommand
    Public connection As New SqlConnection()
    Public datblcarey As SqlDataAdapter
    Public m_careydata As New DataTable

    Private Sub loadbydate()

        Try ' try to open the db
            initdb()
            cbcarey = New SqlCommand("Select * From dbo.tblCarey WHERE Date = @Date", connection)

            m_careydata.Clear()

            datblcarey = New SqlDataAdapter(cbcarey)
            'search by the date
            cbcarey.Parameters.Add("@Date", SqlDbType.Date).Value = dtpRawdata.Value
            'fill the datatable
            datblcarey.Fill(m_careydata)
            'bind the table to the data grid view
            dgvcarey.DataSource = m_careydata
        Catch ex As Exception 'if there was an error connecting show an error message
            MessageBox.Show("Error: " & ex.Message)
        End Try
        'close the connection
        closedb()
    End Sub

    Private Sub btnrawback_Click(sender As Object, e As EventArgs) Handles btnrawback.Click
        'set the date back one day when the button is clicked
        dtpRawdata.Value = dtpRawdata.Value.AddDays(-1)
        'load the data
        loadbydate()
    End Sub

    Private Sub btnrawForward_Click(sender As Object, e As EventArgs) Handles btnrawForward.Click
        'set the day forward one day when the button is clicked
        dtpRawdata.Value = dtpRawdata.Value.AddDays(1)
        'load the data
        loadbydate()
    End Sub

    Private Sub rawload_Load(sender As Object, e As EventArgs) Handles Me.Load
        'on form load load the data on that date in the data grid view
        loadbydate()
    End Sub
End Class