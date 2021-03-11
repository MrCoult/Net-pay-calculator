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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHfunctie = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBpersoane = New System.Windows.Forms.ComboBox()
        Me.CHimpozabil = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Salariul Brut"
        '
        'CHfunctie
        '
        Me.CHfunctie.AutoSize = True
        Me.CHfunctie.Location = New System.Drawing.Point(49, 83)
        Me.CHfunctie.Name = "CHfunctie"
        Me.CHfunctie.Size = New System.Drawing.Size(105, 17)
        Me.CHfunctie.TabIndex = 2
        Me.CHfunctie.Text = "Functie de  baza"
        Me.CHfunctie.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numarul de persoane in intretinere"
        '
        'CMBpersoane
        '
        Me.CMBpersoane.FormattingEnabled = True
        Me.CMBpersoane.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CMBpersoane.Location = New System.Drawing.Point(49, 120)
        Me.CMBpersoane.Name = "CMBpersoane"
        Me.CMBpersoane.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMBpersoane.Size = New System.Drawing.Size(121, 21)
        Me.CMBpersoane.TabIndex = 4
        '
        'CHimpozabil
        '
        Me.CHimpozabil.AutoSize = True
        Me.CHimpozabil.Location = New System.Drawing.Point(49, 147)
        Me.CHimpozabil.Name = "CHimpozabil"
        Me.CHimpozabil.Size = New System.Drawing.Size(70, 17)
        Me.CHimpozabil.TabIndex = 5
        Me.CHimpozabil.Text = "Impozabil"
        Me.CHimpozabil.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculeaza Salariul Net"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 258)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Salariul Net"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 321)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CHimpozabil)
        Me.Controls.Add(Me.CMBpersoane)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CHfunctie)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CHfunctie As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CMBpersoane As ComboBox
    Friend WithEvents CHimpozabil As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
End Class
