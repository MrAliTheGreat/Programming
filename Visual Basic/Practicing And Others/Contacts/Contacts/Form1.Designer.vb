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
        Me.ListBoxContacts = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAddNewContact = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxContacts
        '
        Me.ListBoxContacts.FormattingEnabled = True
        Me.ListBoxContacts.ItemHeight = 20
        Me.ListBoxContacts.Location = New System.Drawing.Point(30, 52)
        Me.ListBoxContacts.Name = "ListBoxContacts"
        Me.ListBoxContacts.Size = New System.Drawing.Size(191, 244)
        Me.ListBoxContacts.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contacts"
        '
        'ButtonAddNewContact
        '
        Me.ButtonAddNewContact.Location = New System.Drawing.Point(254, 149)
        Me.ButtonAddNewContact.Name = "ButtonAddNewContact"
        Me.ButtonAddNewContact.Size = New System.Drawing.Size(154, 40)
        Me.ButtonAddNewContact.TabIndex = 2
        Me.ButtonAddNewContact.Text = "Add New Contact"
        Me.ButtonAddNewContact.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 337)
        Me.Controls.Add(Me.ButtonAddNewContact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxContacts)
        Me.Name = "Form1"
        Me.Text = "Contacts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxContacts As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAddNewContact As System.Windows.Forms.Button

End Class
