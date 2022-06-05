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

        qcctf.WriteLine("Contact No: " + cnTextbox.Text)
        qcctf.WriteLine("Email: " + emailTextbox.Text)
        qcctf.WriteLine("Date: " + DateTimePicker1.Text + "       " + "Time: " + DateTime.Now.ToString("h:mm:ss tt"))
        qcctf.WriteLine("Address: " + addressTextbox.Text)

        qcctf.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
