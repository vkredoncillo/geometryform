<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Geometryform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Geometryform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Length = New System.Windows.Forms.Label()
        Me.Width = New System.Windows.Forms.Label()
        Me.Height = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.len = New System.Windows.Forms.TextBox()
        Me.wid = New System.Windows.Forms.TextBox()
        Me.heit = New System.Windows.Forms.TextBox()
        Me.sid = New System.Windows.Forms.TextBox()
        Me.textboxall = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Parameter = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rectangle"
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Length.ForeColor = System.Drawing.Color.Coral
        Me.Length.Location = New System.Drawing.Point(45, 93)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(75, 22)
        Me.Length.TabIndex = 1
        Me.Length.Text = "Length"
        '
        'Width
        '
        Me.Width.AutoSize = True
        Me.Width.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Width.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Width.Location = New System.Drawing.Point(45, 151)
        Me.Width.Name = "Width"
        Me.Width.Size = New System.Drawing.Size(66, 22)
        Me.Width.TabIndex = 2
        Me.Width.Text = "Width"
        '
        'Height
        '
        Me.Height.AutoSize = True
        Me.Height.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Height.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Height.Location = New System.Drawing.Point(38, 205)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(73, 22)
        Me.Height.TabIndex = 3
        Me.Height.Text = "Height"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label5.Location = New System.Drawing.Point(361, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Side"
        '
        'len
        '
        Me.len.Location = New System.Drawing.Point(159, 93)
        Me.len.Name = "len"
        Me.len.Size = New System.Drawing.Size(100, 22)
        Me.len.TabIndex = 5
        '
        'wid
        '
        Me.wid.Location = New System.Drawing.Point(159, 153)
        Me.wid.Name = "wid"
        Me.wid.Size = New System.Drawing.Size(100, 22)
        Me.wid.TabIndex = 6
        '
        'heit
        '
        Me.heit.Location = New System.Drawing.Point(159, 207)
        Me.heit.Name = "heit"
        Me.heit.Size = New System.Drawing.Size(100, 22)
        Me.heit.TabIndex = 7
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(441, 92)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(100, 22)
        Me.sid.TabIndex = 8
        '
        'textboxall
        '
        Me.textboxall.Location = New System.Drawing.Point(324, 264)
        Me.textboxall.Name = "textboxall"
        Me.textboxall.Size = New System.Drawing.Size(443, 142)
        Me.textboxall.TabIndex = 9
        Me.textboxall.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Parameter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 37)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Volume"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(192, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 37)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Area"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(492, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 51)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Square"
        '
        'Parameter
        '
        Me.Parameter.Location = New System.Drawing.Point(441, 120)
        Me.Parameter.Name = "Parameter"
        Me.Parameter.Size = New System.Drawing.Size(87, 37)
        Me.Parameter.TabIndex = 15
        Me.Parameter.Text = "Parameter"
        Me.Parameter.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(520, 120)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 37)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Volume"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(604, 120)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(82, 36)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "Area"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Geometryform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Parameter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textboxall)
        Me.Controls.Add(Me.sid)
        Me.Controls.Add(Me.heit)
        Me.Controls.Add(Me.wid)
        Me.Controls.Add(Me.len)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Height)
        Me.Controls.Add(Me.Width)
        Me.Controls.Add(Me.Length)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Geometryform"
        Me.Text = "geometry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Length As Label
    Friend WithEvents Width As Label
    Friend WithEvents Height As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents len As TextBox
    Friend WithEvents wid As TextBox
    Friend WithEvents heit As TextBox
    Friend WithEvents sid As TextBox
    Friend WithEvents textboxall As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Parameter As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
