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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxArea = New System.Windows.Forms.TextBox()
        Me.TextBoxPerimeter = New System.Windows.Forms.TextBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a :"
        '
        'TextBoxA
        '
        Me.TextBoxA.Location = New System.Drawing.Point(370, 89)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxA.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(37, 45)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(199, 344)
        Me.ListBox1.TabIndex = 2
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(522, 88)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(122, 41)
        Me.ButtonAdd.TabIndex = 3
        Me.ButtonAdd.Text = "Add to List"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "b :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Perimeter :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Area :"
        '
        'TextBoxArea
        '
        Me.TextBoxArea.Enabled = False
        Me.TextBoxArea.Location = New System.Drawing.Point(371, 235)
        Me.TextBoxArea.Name = "TextBoxArea"
        Me.TextBoxArea.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxArea.TabIndex = 7
        '
        'TextBoxPerimeter
        '
        Me.TextBoxPerimeter.Enabled = False
        Me.TextBoxPerimeter.Location = New System.Drawing.Point(371, 191)
        Me.TextBoxPerimeter.Name = "TextBoxPerimeter"
        Me.TextBoxPerimeter.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxPerimeter.TabIndex = 8
        '
        'TextBoxB
        '
        Me.TextBoxB.Location = New System.Drawing.Point(371, 141)
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxB.TabIndex = 9
        '
        'TextBoxName
        '
        Me.TextBoxName.Enabled = False
        Me.TextBoxName.Location = New System.Drawing.Point(371, 278)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Name :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 486)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxB)
        Me.Controls.Add(Me.TextBoxPerimeter)
        Me.Controls.Add(Me.TextBoxArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBoxA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxA As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxArea As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPerimeter As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxB As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
