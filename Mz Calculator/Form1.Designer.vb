<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button4)
        Panel2.Location = New Point(-4, -4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(772, 493)
        Panel2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rubik", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(146, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 29)
        Label4.TabIndex = 6
        Label4.Text = "إخــتــر مــن الــقــائــمــة"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("ROG Fonts v1.6", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(146, 410)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 19)
        Label3.TabIndex = 5
        Label3.Text = "Powered By"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("ROG Fonts v1.6", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Chartreuse
        Label2.Location = New Point(255, 410)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 19)
        Label2.TabIndex = 4
        Label2.Text = "Mz_75"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkCyan
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("ROG Fonts v1.6", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(28, 511)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 19)
        Label1.TabIndex = 0
        Label1.Text = "Powered by"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Rubik", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Image = My.Resources.Resources.prototype
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(107, 207)
        Button3.Name = "Button3"
        Button3.Size = New Size(285, 45)
        Button3.TabIndex = 2
        Button3.Text = "الـهـنـدسـة"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Rubik", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Image = My.Resources.Resources.calculator__2_1
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(107, 137)
        Button2.Name = "Button2"
        Button2.Size = New Size(285, 45)
        Button2.TabIndex = 1
        Button2.Text = "الأرقـــام"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Rubik", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Image = My.Resources.Resources.mathematician
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(107, 277)
        Button4.Name = "Button4"
        Button4.Size = New Size(285, 45)
        Button4.TabIndex = 3
        Button4.Text = "الـنـظـريـات"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 434)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mz Calculator"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
