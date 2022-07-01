Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec


Public Class QRCC
    Dim Cam As VideoCaptureDevice
    Dim BeatEmUp As Bitmap

    Private Sub ScanBtn_Click(sender As Object, e As EventArgs) Handles ScanBtn.Click
        Dim Era As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If Era.ShowDialog() = DialogResult.OK Then
            Cam = Era.VideoDevice
            AddHandler Cam.NewFrame, New NewFrameEventHandler(AddressOf PicBox)
            Cam.Start()
            QR_TIMER.Start()
        End If
    End Sub

    Private Sub PicBox(sender As Object, eventArgs As NewFrameEventArgs)
        BeatEmUp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        QRPictureBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub QR_TIMER_Tick(sender As Object, e As EventArgs) Handles QR_TIMER.Tick
        If QRPictureBox.Image IsNot Nothing Then
            Dim BReader As BarcodeReader = New BarcodeReader
            Dim QRDecoder As Result = BReader.Decode(DirectCast(QRPictureBox.Image, Bitmap))
            If QRDecoder IsNot Nothing Then
                Dim ccresult As New Form1
                ccresult.QRresult = QRDecoder.ToString()
                ccresult.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class