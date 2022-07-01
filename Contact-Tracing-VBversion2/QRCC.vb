Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow


Public Class QRCC
    Dim Cam As VideoCaptureDevice
    Dim BeatEmUp As Bitmap

    Private Sub ScanBtn_Click(sender As Object, e As EventArgs) Handles ScanBtn.Click
        Dim Era As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If Era.ShowDialog() = DialogResult.OK Then
            Cam = Era.VideoDevice
            AddHandler Cam.NewFrame, New NewFrameEventHandler(AddressOf PicBox)
            Cam.Start()
        End If
    End Sub

    Private Sub PicBox(sender As Object, eventArgs As NewFrameEventArgs)
        BeatEmUp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        QRPictureBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
End Class