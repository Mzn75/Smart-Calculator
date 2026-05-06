<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        CyberButton2 = New ReaLTaiizor.Controls.CyberButton()
        CyberButton1 = New ReaLTaiizor.Controls.CyberButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Thistle
        Panel1.Controls.Add(CyberButton1)
        Panel1.Controls.Add(CyberButton2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(477, 426)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button4)
        Panel2.Location = New Point(-15, 423)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(519, 94)
        Panel2.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Rubik", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Image = My.Resources.Resources.prototype
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(355, 21)
        Button3.Name = "Button3"
        Button3.Size = New Size(124, 49)
        Button3.TabIndex = 8
        Button3.Text = "الهندسة"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Rubik", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Image = My.Resources.Resources.home
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(27, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 49)
        Button2.TabIndex = 7
        Button2.Text = "الرئيسية"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Rubik", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Image = My.Resources.Resources.calculator__2_
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(196, 21)
        Button4.Name = "Button4"
        Button4.Size = New Size(116, 49)
        Button4.TabIndex = 9
        Button4.Text = "الأرقام"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = True
        ' 
        ' CyberButton2
        ' 
        CyberButton2.Alpha = 20
        CyberButton2.BackColor = Color.Transparent
        CyberButton2.Background = True
        CyberButton2.Background_WidthPen = 4F
        CyberButton2.BackgroundPen = True
        CyberButton2.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        CyberButton2.ColorBackground_1 = Color.Transparent
        CyberButton2.ColorBackground_2 = Color.Transparent
        CyberButton2.ColorBackground_Pen = Color.White
        CyberButton2.ColorLighting = Color.White
        CyberButton2.ColorPen_1 = Color.Transparent
        CyberButton2.ColorPen_2 = Color.Transparent
        CyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberButton2.Effect_1 = True
        CyberButton2.Effect_1_ColorBackground = Color.White
        CyberButton2.Effect_1_Transparency = 25
        CyberButton2.Effect_2 = True
        CyberButton2.Effect_2_ColorBackground = Color.White
        CyberButton2.Effect_2_Transparency = 20
        CyberButton2.Font = New Font("Rubik SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        CyberButton2.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberButton2.Lighting = False
        CyberButton2.LinearGradient_Background = False
        CyberButton2.LinearGradientPen = False
        CyberButton2.Location = New Point(112, 115)
        CyberButton2.Name = "CyberButton2"
        CyberButton2.PenWidth = 15
        CyberButton2.Rounding = True
        CyberButton2.RoundingInt = 35
        CyberButton2.Size = New Size(253, 64)
        CyberButton2.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton2.TabIndex = 14
        CyberButton2.Tag = "Cyber"
        CyberButton2.TextButton = "فـيـثـاغـورث"
        CyberButton2.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton2.Timer_Effect_1 = 5
        CyberButton2.Timer_RGB = 300
        ' 
        ' CyberButton1
        ' 
        CyberButton1.Alpha = 20
        CyberButton1.BackColor = Color.Transparent
        CyberButton1.Background = True
        CyberButton1.Background_WidthPen = 4F
        CyberButton1.BackgroundPen = True
        CyberButton1.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        CyberButton1.ColorBackground_1 = Color.Transparent
        CyberButton1.ColorBackground_2 = Color.Transparent
        CyberButton1.ColorBackground_Pen = Color.White
        CyberButton1.ColorLighting = Color.White
        CyberButton1.ColorPen_1 = Color.Transparent
        CyberButton1.ColorPen_2 = Color.Transparent
        CyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberButton1.Effect_1 = True
        CyberButton1.Effect_1_ColorBackground = Color.White
        CyberButton1.Effect_1_Transparency = 25
        CyberButton1.Effect_2 = True
        CyberButton1.Effect_2_ColorBackground = Color.White
        CyberButton1.Effect_2_Transparency = 20
        CyberButton1.Font = New Font("Rubik SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        CyberButton1.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberButton1.Lighting = False
        CyberButton1.LinearGradient_Background = False
        CyberButton1.LinearGradientPen = False
        CyberButton1.Location = New Point(112, 249)
        CyberButton1.Name = "CyberButton1"
        CyberButton1.PenWidth = 15
        CyberButton1.Rounding = True
        CyberButton1.RoundingInt = 35
        CyberButton1.Size = New Size(253, 64)
        CyberButton1.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton1.TabIndex = 15
        CyberButton1.Tag = "Cyber"
        CyberButton1.TextButton = "إقــلــيــدس"
        CyberButton1.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton1.Timer_Effect_1 = 5
        CyberButton1.Timer_RGB = 300
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(476, 510)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mz Calculator | الـــنـــظـــريـــات"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CyberButton2 As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents CyberButton1 As ReaLTaiizor.Controls.CyberButton
End Class
