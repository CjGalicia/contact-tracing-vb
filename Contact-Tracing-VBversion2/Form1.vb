Public Class Form1
    Public Property QRresult As String
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

        If feverYes.Checked Then
            qcctf.WriteLine("Are you experiencing fever?: Yes")
        Else
            qcctf.WriteLine("Are you experiencing fever?: No")
        End If

        If drycoughYes.Checked Then
            qcctf.WriteLine("Are you experiencing dry cough?: Yes")
        Else
            qcctf.WriteLine("Are you experiencing dry cough?: No")
        End If

        If tirednessYes.Checked Then
            qcctf.WriteLine("Are you experiencing tiredness?: Yes")
        Else
            qcctf.WriteLine("Are you experiencing tiredness?: No")
        End If

        If sorethroatYes.Checked Then
            qcctf.WriteLine("Are you experiencing sore throat?: Yes")
        Else
            qcctf.WriteLine("Are you experiencing sore throat?: No")
        End If

        qcctf.WriteLine("")

        qcctf.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KuhaData As String()
        KuhaData = QRresult.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        fullnameTextbox.Text = KuhaData(0)
        ageTextbox.Text = KuhaData(1)
        If KuhaData(2) = "Male" Then
            maleRadiobutton.Checked = True
        Else
            FemaleRadiobutton.Checked = True
        End If
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        fullnameTextbox.Clear()
        ageTextbox.Clear()
        cnTextbox.Clear()
        emailTextbox.Clear()
        addressTextbox.Clear()

        maleRadiobutton.Checked = False
        FemaleRadiobutton.Checked = False
        feverYes.Checked = False
        feverNo.Checked = False
        drycoughYes.Checked = False
        drycoughNo.Checked = False
        tirednessYes.Checked = False
        tirednessNo.Checked = False
        sorethroatYes.Checked = False
        sorethroatNo.Checked = False

    End Sub
End Class
