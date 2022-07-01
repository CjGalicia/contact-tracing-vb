<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QRCC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ScanBtn = New System.Windows.Forms.Button()
        Me.QRPictureBox = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.QR_TIMER = New System.Windows.Forms.Timer(Me.components)
        CType(Me.QRPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScanBtn
        '
        Me.ScanBtn.Location = New System.Drawing.Point(162, 323)
        Me.ScanBtn.Name = "ScanBtn"
        Me.ScanBtn.Size = New System.Drawing.Size(168, 44)
        Me.ScanBtn.TabIndex = 0
        Me.ScanBtn.Text = "Click to Scan"
        Me.ScanBtn.UseVisualStyleBackColor = True
        '
        'QRPictureBox
        '
        Me.QRPictureBox.Location = New System.Drawing.Point(12, 56)
        Me.QRPictureBox.Name = "QRPictureBox"
        Me.QRPictureBox.Size = New System.Drawing.Size(449, 261)
        Me.QRPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QRPictureBox.TabIndex = 1
        Me.QRPictureBox.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(12, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(449, 25)
        Me.Title.TabIndex = 27
        Me.Title.Text = "Quezon City Contact Tracing QR Scanner"
        '
        'QR_TIMER
        '
        Me.QR_TIMER.Interval = 1000
        '
        'QRCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 382)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.QRPictureBox)
        Me.Controls.Add(Me.ScanBtn)
        Me.Name = "QRCC"
        Me.Text = "QRCC"
        CType(Me.QRPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScanBtn As Button
    Friend WithEvents QRPictureBox As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents QRTimer As Timer
    Friend WithEvents QR_TIMER As Timer
End Class
