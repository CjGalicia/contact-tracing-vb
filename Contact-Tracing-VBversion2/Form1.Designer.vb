<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.current_timeLabel = New System.Windows.Forms.Label()
        Me.tirednessBox = New System.Windows.Forms.GroupBox()
        Me.tirednessNo = New System.Windows.Forms.RadioButton()
        Me.tirednessYes = New System.Windows.Forms.RadioButton()
        Me.drycoughBox = New System.Windows.Forms.GroupBox()
        Me.drycoughNo = New System.Windows.Forms.RadioButton()
        Me.drycoughYes = New System.Windows.Forms.RadioButton()
        Me.feverBox = New System.Windows.Forms.GroupBox()
        Me.feverNo = New System.Windows.Forms.RadioButton()
        Me.feverYes = New System.Windows.Forms.RadioButton()
        Me.addressTextbox = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.emailTextbox = New System.Windows.Forms.TextBox()
        Me.cnLabel = New System.Windows.Forms.Label()
        Me.cnTextbox = New System.Windows.Forms.TextBox()
        Me.genderBox = New System.Windows.Forms.GroupBox()
        Me.FemaleRadiobutton = New System.Windows.Forms.RadioButton()
        Me.maleRadiobutton = New System.Windows.Forms.RadioButton()
        Me.ageTextbox = New System.Windows.Forms.TextBox()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.lnLabel = New System.Windows.Forms.Label()
        Me.miLabel = New System.Windows.Forms.Label()
        Me.fnLabel = New System.Windows.Forms.Label()
        Me.fullnameTextbox = New System.Windows.Forms.TextBox()
        Me.fullnameLabel = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.sorethroatBox = New System.Windows.Forms.GroupBox()
        Me.sorethroatNo = New System.Windows.Forms.RadioButton()
        Me.sorethroatYes = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tirednessBox.SuspendLayout()
        Me.drycoughBox.SuspendLayout()
        Me.feverBox.SuspendLayout()
        Me.genderBox.SuspendLayout()
        Me.sorethroatBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'current_timeLabel
        '
        Me.current_timeLabel.AutoSize = True
        Me.current_timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.current_timeLabel.Location = New System.Drawing.Point(343, 275)
        Me.current_timeLabel.Name = "current_timeLabel"
        Me.current_timeLabel.Size = New System.Drawing.Size(0, 15)
        Me.current_timeLabel.TabIndex = 47
        '
        'tirednessBox
        '
        Me.tirednessBox.Controls.Add(Me.tirednessNo)
        Me.tirednessBox.Controls.Add(Me.tirednessYes)
        Me.tirednessBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tirednessBox.Location = New System.Drawing.Point(29, 446)
        Me.tirednessBox.Name = "tirednessBox"
        Me.tirednessBox.Size = New System.Drawing.Size(359, 53)
        Me.tirednessBox.TabIndex = 46
        Me.tirednessBox.TabStop = False
        Me.tirednessBox.Text = "Are you experiencing tiredness?"
        '
        'tirednessNo
        '
        Me.tirednessNo.AutoSize = True
        Me.tirednessNo.Location = New System.Drawing.Point(212, 20)
        Me.tirednessNo.Name = "tirednessNo"
        Me.tirednessNo.Size = New System.Drawing.Size(41, 19)
        Me.tirednessNo.TabIndex = 9
        Me.tirednessNo.TabStop = True
        Me.tirednessNo.Text = "No"
        Me.tirednessNo.UseVisualStyleBackColor = True
        '
        'tirednessYes
        '
        Me.tirednessYes.AutoSize = True
        Me.tirednessYes.Location = New System.Drawing.Point(69, 20)
        Me.tirednessYes.Name = "tirednessYes"
        Me.tirednessYes.Size = New System.Drawing.Size(45, 19)
        Me.tirednessYes.TabIndex = 0
        Me.tirednessYes.TabStop = True
        Me.tirednessYes.Text = "Yes"
        Me.tirednessYes.UseVisualStyleBackColor = True
        '
        'drycoughBox
        '
        Me.drycoughBox.Controls.Add(Me.drycoughNo)
        Me.drycoughBox.Controls.Add(Me.drycoughYes)
        Me.drycoughBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.drycoughBox.Location = New System.Drawing.Point(29, 387)
        Me.drycoughBox.Name = "drycoughBox"
        Me.drycoughBox.Size = New System.Drawing.Size(359, 53)
        Me.drycoughBox.TabIndex = 45
        Me.drycoughBox.TabStop = False
        Me.drycoughBox.Text = "Are you experiencing dry cough?"
        '
        'drycoughNo
        '
        Me.drycoughNo.AutoSize = True
        Me.drycoughNo.Location = New System.Drawing.Point(212, 20)
        Me.drycoughNo.Name = "drycoughNo"
        Me.drycoughNo.Size = New System.Drawing.Size(41, 19)
        Me.drycoughNo.TabIndex = 9
        Me.drycoughNo.TabStop = True
        Me.drycoughNo.Text = "No"
        Me.drycoughNo.UseVisualStyleBackColor = True
        '
        'drycoughYes
        '
        Me.drycoughYes.AutoSize = True
        Me.drycoughYes.Location = New System.Drawing.Point(69, 20)
        Me.drycoughYes.Name = "drycoughYes"
        Me.drycoughYes.Size = New System.Drawing.Size(45, 19)
        Me.drycoughYes.TabIndex = 0
        Me.drycoughYes.TabStop = True
        Me.drycoughYes.Text = "Yes"
        Me.drycoughYes.UseVisualStyleBackColor = True
        '
        'feverBox
        '
        Me.feverBox.Controls.Add(Me.feverNo)
        Me.feverBox.Controls.Add(Me.feverYes)
        Me.feverBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.feverBox.Location = New System.Drawing.Point(29, 328)
        Me.feverBox.Name = "feverBox"
        Me.feverBox.Size = New System.Drawing.Size(359, 53)
        Me.feverBox.TabIndex = 44
        Me.feverBox.TabStop = False
        Me.feverBox.Text = "Are you experiencing fever?"
        '
        'feverNo
        '
        Me.feverNo.AutoSize = True
        Me.feverNo.Location = New System.Drawing.Point(212, 20)
        Me.feverNo.Name = "feverNo"
        Me.feverNo.Size = New System.Drawing.Size(41, 19)
        Me.feverNo.TabIndex = 9
        Me.feverNo.TabStop = True
        Me.feverNo.Text = "No"
        Me.feverNo.UseVisualStyleBackColor = True
        '
        'feverYes
        '
        Me.feverYes.AutoSize = True
        Me.feverYes.Location = New System.Drawing.Point(69, 20)
        Me.feverYes.Name = "feverYes"
        Me.feverYes.Size = New System.Drawing.Size(45, 19)
        Me.feverYes.TabIndex = 0
        Me.feverYes.TabStop = True
        Me.feverYes.Text = "Yes"
        Me.feverYes.UseVisualStyleBackColor = True
        '
        'addressTextbox
        '
        Me.addressTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addressTextbox.Location = New System.Drawing.Point(88, 301)
        Me.addressTextbox.Name = "addressTextbox"
        Me.addressTextbox.Size = New System.Drawing.Size(300, 21)
        Me.addressTextbox.TabIndex = 43
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addressLabel.Location = New System.Drawing.Point(28, 303)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(54, 15)
        Me.addressLabel.TabIndex = 42
        Me.addressLabel.Text = "Address:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(301, 275)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(36, 15)
        Me.timeLabel.TabIndex = 41
        Me.timeLabel.Text = "Time:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, 274)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(208, 21)
        Me.DateTimePicker1.TabIndex = 40
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dateLabel.Location = New System.Drawing.Point(46, 274)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(36, 15)
        Me.dateLabel.TabIndex = 39
        Me.dateLabel.Text = "Date:"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.emailLabel.Location = New System.Drawing.Point(43, 246)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(42, 15)
        Me.emailLabel.TabIndex = 38
        Me.emailLabel.Text = "Email:"
        '
        'emailTextbox
        '
        Me.emailTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.emailTextbox.Location = New System.Drawing.Point(88, 243)
        Me.emailTextbox.Name = "emailTextbox"
        Me.emailTextbox.Size = New System.Drawing.Size(300, 21)
        Me.emailTextbox.TabIndex = 37
        '
        'cnLabel
        '
        Me.cnLabel.AutoSize = True
        Me.cnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cnLabel.Location = New System.Drawing.Point(15, 218)
        Me.cnLabel.Name = "cnLabel"
        Me.cnLabel.Size = New System.Drawing.Size(70, 15)
        Me.cnLabel.TabIndex = 36
        Me.cnLabel.Text = "Contact No:"
        '
        'cnTextbox
        '
        Me.cnTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cnTextbox.Location = New System.Drawing.Point(88, 216)
        Me.cnTextbox.Name = "cnTextbox"
        Me.cnTextbox.Size = New System.Drawing.Size(300, 21)
        Me.cnTextbox.TabIndex = 35
        '
        'genderBox
        '
        Me.genderBox.Controls.Add(Me.FemaleRadiobutton)
        Me.genderBox.Controls.Add(Me.maleRadiobutton)
        Me.genderBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.genderBox.Location = New System.Drawing.Point(29, 157)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(359, 53)
        Me.genderBox.TabIndex = 34
        Me.genderBox.TabStop = False
        Me.genderBox.Text = "Gender:"
        '
        'FemaleRadiobutton
        '
        Me.FemaleRadiobutton.AutoSize = True
        Me.FemaleRadiobutton.Location = New System.Drawing.Point(212, 20)
        Me.FemaleRadiobutton.Name = "FemaleRadiobutton"
        Me.FemaleRadiobutton.Size = New System.Drawing.Size(67, 19)
        Me.FemaleRadiobutton.TabIndex = 9
        Me.FemaleRadiobutton.TabStop = True
        Me.FemaleRadiobutton.Text = "Female"
        Me.FemaleRadiobutton.UseVisualStyleBackColor = True
        '
        'maleRadiobutton
        '
        Me.maleRadiobutton.AutoSize = True
        Me.maleRadiobutton.Location = New System.Drawing.Point(69, 20)
        Me.maleRadiobutton.Name = "maleRadiobutton"
        Me.maleRadiobutton.Size = New System.Drawing.Size(53, 19)
        Me.maleRadiobutton.TabIndex = 0
        Me.maleRadiobutton.TabStop = True
        Me.maleRadiobutton.Text = "Male"
        Me.maleRadiobutton.UseVisualStyleBackColor = True
        '
        'ageTextbox
        '
        Me.ageTextbox.Location = New System.Drawing.Point(88, 116)
        Me.ageTextbox.Name = "ageTextbox"
        Me.ageTextbox.Size = New System.Drawing.Size(300, 23)
        Me.ageTextbox.TabIndex = 33
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Location = New System.Drawing.Point(51, 119)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(31, 15)
        Me.ageLabel.TabIndex = 32
        Me.ageLabel.Text = "Age:"
        '
        'lnLabel
        '
        Me.lnLabel.AutoSize = True
        Me.lnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lnLabel.Location = New System.Drawing.Point(301, 87)
        Me.lnLabel.Name = "lnLabel"
        Me.lnLabel.Size = New System.Drawing.Size(67, 15)
        Me.lnLabel.TabIndex = 31
        Me.lnLabel.Text = "Last Name"
        '
        'miLabel
        '
        Me.miLabel.AutoSize = True
        Me.miLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.miLabel.Location = New System.Drawing.Point(196, 87)
        Me.miLabel.Name = "miLabel"
        Me.miLabel.Size = New System.Drawing.Size(77, 15)
        Me.miLabel.TabIndex = 30
        Me.miLabel.Text = "Middle Initial"
        '
        'fnLabel
        '
        Me.fnLabel.AutoSize = True
        Me.fnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.fnLabel.Location = New System.Drawing.Point(98, 87)
        Me.fnLabel.Name = "fnLabel"
        Me.fnLabel.Size = New System.Drawing.Size(67, 15)
        Me.fnLabel.TabIndex = 29
        Me.fnLabel.Text = "First Name"
        '
        'fullnameTextbox
        '
        Me.fullnameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fullnameTextbox.Location = New System.Drawing.Point(88, 61)
        Me.fullnameTextbox.Name = "fullnameTextbox"
        Me.fullnameTextbox.Size = New System.Drawing.Size(300, 21)
        Me.fullnameTextbox.TabIndex = 28
        '
        'fullnameLabel
        '
        Me.fullnameLabel.AutoSize = True
        Me.fullnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fullnameLabel.Location = New System.Drawing.Point(15, 63)
        Me.fullnameLabel.Name = "fullnameLabel"
        Me.fullnameLabel.Size = New System.Drawing.Size(67, 15)
        Me.fullnameLabel.TabIndex = 27
        Me.fullnameLabel.Text = "Full Name:"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(53, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(315, 25)
        Me.Title.TabIndex = 26
        Me.Title.Text = "Quezon City Contact Tracing"
        '
        'resetButton
        '
        Me.resetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resetButton.Location = New System.Drawing.Point(300, 574)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(75, 23)
        Me.resetButton.TabIndex = 50
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.submitButton.Location = New System.Drawing.Point(195, 574)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 49
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'sorethroatBox
        '
        Me.sorethroatBox.Controls.Add(Me.sorethroatNo)
        Me.sorethroatBox.Controls.Add(Me.sorethroatYes)
        Me.sorethroatBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sorethroatBox.Location = New System.Drawing.Point(28, 505)
        Me.sorethroatBox.Name = "sorethroatBox"
        Me.sorethroatBox.Size = New System.Drawing.Size(359, 53)
        Me.sorethroatBox.TabIndex = 48
        Me.sorethroatBox.TabStop = False
        Me.sorethroatBox.Text = "Are you experiencing sore throat?"
        '
        'sorethroatNo
        '
        Me.sorethroatNo.AutoSize = True
        Me.sorethroatNo.Location = New System.Drawing.Point(212, 20)
        Me.sorethroatNo.Name = "sorethroatNo"
        Me.sorethroatNo.Size = New System.Drawing.Size(41, 19)
        Me.sorethroatNo.TabIndex = 9
        Me.sorethroatNo.TabStop = True
        Me.sorethroatNo.Text = "No"
        Me.sorethroatNo.UseVisualStyleBackColor = True
        '
        'sorethroatYes
        '
        Me.sorethroatYes.AutoSize = True
        Me.sorethroatYes.Location = New System.Drawing.Point(69, 20)
        Me.sorethroatYes.Name = "sorethroatYes"
        Me.sorethroatYes.Size = New System.Drawing.Size(45, 19)
        Me.sorethroatYes.TabIndex = 0
        Me.sorethroatYes.TabStop = True
        Me.sorethroatYes.Text = "Yes"
        Me.sorethroatYes.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 610)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.sorethroatBox)
        Me.Controls.Add(Me.current_timeLabel)
        Me.Controls.Add(Me.tirednessBox)
        Me.Controls.Add(Me.drycoughBox)
        Me.Controls.Add(Me.feverBox)
        Me.Controls.Add(Me.addressTextbox)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.emailTextbox)
        Me.Controls.Add(Me.cnLabel)
        Me.Controls.Add(Me.cnTextbox)
        Me.Controls.Add(Me.genderBox)
        Me.Controls.Add(Me.ageTextbox)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.lnLabel)
        Me.Controls.Add(Me.miLabel)
        Me.Controls.Add(Me.fnLabel)
        Me.Controls.Add(Me.fullnameTextbox)
        Me.Controls.Add(Me.fullnameLabel)
        Me.Controls.Add(Me.Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tirednessBox.ResumeLayout(False)
        Me.tirednessBox.PerformLayout()
        Me.drycoughBox.ResumeLayout(False)
        Me.drycoughBox.PerformLayout()
        Me.feverBox.ResumeLayout(False)
        Me.feverBox.PerformLayout()
        Me.genderBox.ResumeLayout(False)
        Me.genderBox.PerformLayout()
        Me.sorethroatBox.ResumeLayout(False)
        Me.sorethroatBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents current_timeLabel As Label
    Friend WithEvents tirednessBox As GroupBox
    Friend WithEvents tirednessNo As RadioButton
    Friend WithEvents tirednessYes As RadioButton
    Friend WithEvents drycoughBox As GroupBox
    Friend WithEvents drycoughNo As RadioButton
    Friend WithEvents drycoughYes As RadioButton
    Friend WithEvents feverBox As GroupBox
    Friend WithEvents feverNo As RadioButton
    Friend WithEvents feverYes As RadioButton
    Friend WithEvents addressTextbox As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dateLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents emailTextbox As TextBox
    Friend WithEvents cnLabel As Label
    Friend WithEvents cnTextbox As TextBox
    Friend WithEvents genderBox As GroupBox
    Friend WithEvents FemaleRadiobutton As RadioButton
    Friend WithEvents maleRadiobutton As RadioButton
    Friend WithEvents ageTextbox As TextBox
    Friend WithEvents ageLabel As Label
    Friend WithEvents lnLabel As Label
    Friend WithEvents miLabel As Label
    Friend WithEvents fnLabel As Label
    Friend WithEvents fullnameTextbox As TextBox
    Friend WithEvents fullnameLabel As Label
    Friend WithEvents Title As Label
    Friend WithEvents resetButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents sorethroatBox As GroupBox
    Friend WithEvents sorethroatNo As RadioButton
    Friend WithEvents sorethroatYes As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
