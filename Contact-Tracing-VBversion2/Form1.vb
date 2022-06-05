Public Class Form1
    Private Sub current_time(sender As Object, e As EventArgs) Handles Timer1.Tick
        current_timeLabel.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim file As System.IO.StreamWriter
        file = New IO.StreamWriter("ContactTracingForm.txt", True)
        file.Close()
    End Sub
End Class
