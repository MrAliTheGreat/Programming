<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ButtonReturnToContacts = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFullName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNumberContact = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonReturnToContacts
        '
        Me.ButtonReturnToContacts.Location = New System.Drawing.Point(12, 12)
        Me.ButtonReturnToContacts.Name = "ButtonReturnToContacts"
        Me.ButtonReturnToContacts.Size = New System.Drawing.Size(87, 34)
        Me.ButtonReturnToContacts.TabIndex = 0
        Me.ButtonReturnToContacts.Text = "Contacts"
        Me.ButtonReturnToContacts.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name :"
        '
        'TextBoxFullName
        '
        Me.TextBoxFullName.Location = New System.Drawing.Point(133, 66)
        Me.TextBoxFullName.Name = "TextBoxFullName"
        Me.TextBoxFullName.Size = New System.Drawing.Size(180, 26)
        Me.TextBoxFullName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number :"
        '
        'TextBoxNumberContact
        '
        Me.TextBoxNumberContact.Location = New System.Drawing.Point(133, 106)
        Me.TextBoxNumberContact.Name = "TextBoxNumberContact"
        Me.TextBoxNumberContact.Size = New System.Drawing.Size(180, 26)
        Me.TextBoxNumberContact.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 171)
        Me.Controls.Add(Me.TextBoxNumberContact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFullName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReturnToContacts)
        Me.Name = "Form3"
        Me.Text = "Contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonReturnToContacts As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNumberContact As System.Windows.Forms.TextBox
End Class
