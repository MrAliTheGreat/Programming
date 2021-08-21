<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.ButtonAddContactToContacts = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(148, 24)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxFirstName.TabIndex = 1
        '
        'ButtonAddContactToContacts
        '
        Me.ButtonAddContactToContacts.Location = New System.Drawing.Point(108, 155)
        Me.ButtonAddContactToContacts.Name = "ButtonAddContactToContacts"
        Me.ButtonAddContactToContacts.Size = New System.Drawing.Size(138, 35)
        Me.ButtonAddContactToContacts.TabIndex = 2
        Me.ButtonAddContactToContacts.Text = "Add Contact"
        Me.ButtonAddContactToContacts.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number :"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(148, 68)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxLastName.TabIndex = 5
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(148, 107)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxNumber.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 217)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAddContactToContacts)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "New Contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAddContactToContacts As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLastName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumber As System.Windows.Forms.TextBox
End Class
