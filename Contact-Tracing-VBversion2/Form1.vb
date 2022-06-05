Public Class Form1
    Private Sub current_time(sender As Object, e As EventArgs) Handles Timer1.Tick
        current_timeLabel.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim qcctf As System.IO.StreamWriter
        qcctf = New IO.StreamWriter("ContactTracingForm.txt", True)

        qcctf.WriteLine("Quezon City Contact Tracing Form")
        qcctf.WriteLine("")
        qcctf.WriteLine("Full Name: " + fullnameTextbox.Text)
        qcctf.WriteLine("Age: " + ageTextbox.Text)

        If maleRadiobutton.Checked Then
            qcctf.WriteLine("Gender: Male")
        Else
            qcctf.WriteLine("Gender: Female")
        End If


        qcctf.Close()
    End Sub
End Class
