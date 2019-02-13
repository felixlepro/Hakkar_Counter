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
        Me.nupBlood = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pourcentage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nupTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nupDraw = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.nupBlood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nupBlood
        '
        Me.nupBlood.Location = New System.Drawing.Point(112, 41)
        Me.nupBlood.Name = "nupBlood"
        Me.nupBlood.Size = New System.Drawing.Size(98, 22)
        Me.nupBlood.TabIndex = 0
        Me.nupBlood.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Blood in deck"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Health"
        '
        'Pourcentage
        '
        Me.Pourcentage.AutoSize = True
        Me.Pourcentage.Location = New System.Drawing.Point(393, 163)
        Me.Pourcentage.Name = "Pourcentage"
        Me.Pourcentage.Size = New System.Drawing.Size(16, 17)
        Me.Pourcentage.TabIndex = 9
        Me.Pourcentage.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total cards"
        '
        'nupTotal
        '
        Me.nupTotal.Location = New System.Drawing.Point(112, 78)
        Me.nupTotal.Name = "nupTotal"
        Me.nupTotal.Size = New System.Drawing.Size(98, 22)
        Me.nupTotal.TabIndex = 16
        Me.nupTotal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Draws"
        '
        'nupDraw
        '
        Me.nupDraw.Location = New System.Drawing.Point(112, 116)
        Me.nupDraw.Name = "nupDraw"
        Me.nupDraw.Size = New System.Drawing.Size(98, 22)
        Me.nupDraw.TabIndex = 18
        Me.nupDraw.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(260, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(180, 132)
        Me.ListBox1.TabIndex = 21
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(312, 161)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {6969, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(64, 22)
        Me.NumericUpDown1.TabIndex = 22
        Me.NumericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 197)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nupDraw)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.nupTotal)
        Me.Controls.Add(Me.Pourcentage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nupBlood)
        Me.Name = "Form1"
        Me.Text = "Hakkar counter"
        CType(Me.nupBlood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupDraw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nupBlood As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Pourcentage As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents nupTotal As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nupDraw As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
