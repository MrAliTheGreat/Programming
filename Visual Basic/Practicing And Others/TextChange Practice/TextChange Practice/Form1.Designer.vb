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
        Me.TextBoxIN = New System.Windows.Forms.TextBox()
        Me.ListBoxInput = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxOUT = New System.Windows.Forms.TextBox()
        Me.ListBoxOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TextBoxIN
        '
        Me.TextBoxIN.Location = New System.Drawing.Point(138, 346)
        Me.TextBoxIN.Name = "TextBoxIN"
        Me.TextBoxIN.Size = New System.Drawing.Size(152, 26)
        Me.TextBoxIN.TabIndex = 0
        '
        'ListBoxInput
        '
        Me.ListBoxInput.FormattingEnabled = True
        Me.ListBoxInput.ItemHeight = 20
        Me.ListBoxInput.Location = New System.Drawing.Point(138, 64)
        Me.ListBoxInput.Name = "ListBoxInput"
        Me.ListBoxInput.Size = New System.Drawing.Size(152, 244)
        Me.ListBoxInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "="
        '
        'TextBoxOUT
        '
        Me.TextBoxOUT.Location = New System.Drawing.Point(386, 346)
        Me.TextBoxOUT.Name = "TextBoxOUT"
        Me.TextBoxOUT.Size = New System.Drawing.Size(152, 26)
        Me.TextBoxOUT.TabIndex = 4
        '
        'ListBoxOutput
        '
        Me.ListBoxOutput.FormattingEnabled = True
        Me.ListBoxOutput.ItemHeight = 20
        Me.ListBoxOutput.Location = New System.Drawing.Point(386, 64)
        Me.ListBoxOutput.Name = "ListBoxOutput"
        Me.ListBoxOutput.Size = New System.Drawing.Size(152, 244)
        Me.ListBoxOutput.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 509)
        Me.Controls.Add(Me.ListBoxOutput)
        Me.Controls.Add(Me.TextBoxOUT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxInput)
        Me.Controls.Add(Me.TextBoxIN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxIN As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxInput As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOUT As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxOutput As System.Windows.Forms.ListBox

End Class
