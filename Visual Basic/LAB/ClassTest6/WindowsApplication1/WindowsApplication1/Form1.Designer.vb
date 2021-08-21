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
        Me.TextBoxFN = New System.Windows.Forms.TextBox()
        Me.TextBoxLN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBoxIndex = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FName"
        '
        'TextBoxFN
        '
        Me.TextBoxFN.Location = New System.Drawing.Point(102, 38)
        Me.TextBoxFN.Name = "TextBoxFN"
        Me.TextBoxFN.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFN.TabIndex = 1
        '
        'TextBoxLN
        '
        Me.TextBoxLN.Location = New System.Drawing.Point(102, 83)
        Me.TextBoxLN.Name = "TextBoxLN"
        Me.TextBoxLN.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLN.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LName"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(102, 129)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "تایید"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(256, 38)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(245, 186)
        Me.ListBox2.TabIndex = 8
        '
        'TextBoxIndex
        '
        Me.TextBoxIndex.Location = New System.Drawing.Point(102, 236)
        Me.TextBoxIndex.Name = "TextBoxIndex"
        Me.TextBoxIndex.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIndex.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Index"
        '
        'ButtonSort
        '
        Me.ButtonSort.Location = New System.Drawing.Point(525, 171)
        Me.ButtonSort.Name = "ButtonSort"
        Me.ButtonSort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSort.TabIndex = 11
        Me.ButtonSort.Text = "Sort"
        Me.ButtonSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 268)
        Me.Controls.Add(Me.ButtonSort)
        Me.Controls.Add(Me.TextBoxIndex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxLN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFN As TextBox
    Friend WithEvents TextBoxLN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBoxIndex As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonSort As Button
End Class
