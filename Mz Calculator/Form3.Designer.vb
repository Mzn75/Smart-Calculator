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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel1 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Panel2 = New Panel()
        cube_box = New ReaLTaiizor.Controls.HopePictureBox()
        CyberButton6 = New ReaLTaiizor.Controls.CyberButton()
        ball_box = New ReaLTaiizor.Controls.HopePictureBox()
        CyberButton5 = New ReaLTaiizor.Controls.CyberButton()
        parallelogram_box = New ReaLTaiizor.Controls.HopePictureBox()
        CyberButton4 = New ReaLTaiizor.Controls.CyberButton()
        trapezoid_box = New ReaLTaiizor.Controls.HopePictureBox()
        CyberButton7 = New ReaLTaiizor.Controls.CyberButton()
        triangle_box = New ReaLTaiizor.Controls.HopePictureBox()
        circle_box = New ReaLTaiizor.Controls.HopePictureBox()
        rectangle_box = New ReaLTaiizor.Controls.HopePictureBox()
        square_box = New ReaLTaiizor.Controls.HopePictureBox()
        CyberButton3 = New ReaLTaiizor.Controls.CyberButton()
        CyberButton2 = New ReaLTaiizor.Controls.CyberButton()
        rectangle = New ReaLTaiizor.Controls.CyberButton()
        square = New ReaLTaiizor.Controls.CyberButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(cube_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(ball_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(parallelogram_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(trapezoid_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(triangle_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(circle_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(rectangle_box, ComponentModel.ISupportInitialize).BeginInit()
        CType(square_box, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button4)
        Panel1.Location = New Point(1, 426)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(830, 88)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Rubik", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Image = My.Resources.Resources.calculator__2_
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(290, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(248, 49)
        Button3.TabIndex = 8
        Button3.Text = "الأرقـــــــام"
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
        Button2.Location = New Point(11, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(248, 49)
        Button2.TabIndex = 7
        Button2.Text = "الـصـفـحـة الـرئـيـسـيـة"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Rubik", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Image = My.Resources.Resources.mathematician
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(569, 23)
        Button4.Name = "Button4"
        Button4.Size = New Size(248, 49)
        Button4.TabIndex = 9
        Button4.Text = "الــنــظــريــات"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Cornsilk
        Panel2.Controls.Add(cube_box)
        Panel2.Controls.Add(CyberButton6)
        Panel2.Controls.Add(ball_box)
        Panel2.Controls.Add(CyberButton5)
        Panel2.Controls.Add(parallelogram_box)
        Panel2.Controls.Add(CyberButton4)
        Panel2.Controls.Add(trapezoid_box)
        Panel2.Controls.Add(CyberButton7)
        Panel2.Controls.Add(triangle_box)
        Panel2.Controls.Add(circle_box)
        Panel2.Controls.Add(rectangle_box)
        Panel2.Controls.Add(square_box)
        Panel2.Controls.Add(CyberButton3)
        Panel2.Controls.Add(CyberButton2)
        Panel2.Controls.Add(rectangle)
        Panel2.Controls.Add(square)
        Panel2.Location = New Point(1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(830, 431)
        Panel2.TabIndex = 1
        ' 
        ' cube_box
        ' 
        cube_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        cube_box.Image = My.Resources.Resources.rubik
        cube_box.Location = New Point(24, 219)
        cube_box.Name = "cube_box"
        cube_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        cube_box.Size = New Size(127, 130)
        cube_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        cube_box.TabIndex = 29
        cube_box.TabStop = False
        cube_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' CyberButton6
        ' 
        CyberButton6.Alpha = 20
        CyberButton6.BackColor = Color.Transparent
        CyberButton6.Background = True
        CyberButton6.Background_WidthPen = 4F
        CyberButton6.BackgroundPen = True
        CyberButton6.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        CyberButton6.ColorBackground_1 = Color.Transparent
        CyberButton6.ColorBackground_2 = Color.Transparent
        CyberButton6.ColorBackground_Pen = Color.White
        CyberButton6.ColorLighting = Color.White
        CyberButton6.ColorPen_1 = Color.Transparent
        CyberButton6.ColorPen_2 = Color.Transparent
        CyberButton6.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberButton6.Effect_1 = True
        CyberButton6.Effect_1_ColorBackground = Color.White
        CyberButton6.Effect_1_Transparency = 25
        CyberButton6.Effect_2 = True
        CyberButton6.Effect_2_ColorBackground = Color.White
        CyberButton6.Effect_2_Transparency = 20
        CyberButton6.Font = New Font("Rubik SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        CyberButton6.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberButton6.Lighting = False
        CyberButton6.LinearGradient_Background = False
        CyberButton6.LinearGradientPen = False
        CyberButton6.Location = New Point(11, 353)
        CyberButton6.Name = "CyberButton6"
        CyberButton6.PenWidth = 15
        CyberButton6.Rounding = True
        CyberButton6.RoundingInt = 35
        CyberButton6.Size = New Size(154, 43)
        CyberButton6.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton6.TabIndex = 28
        CyberButton6.Tag = "Cyber"
        CyberButton6.TextButton = "الــمــكــعــب"
        CyberButton6.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton6.Timer_Effect_1 = 5
        CyberButton6.Timer_RGB = 300
        ' 
        ' ball_box
        ' 
        ball_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        ball_box.Image = My.Resources.Resources.beach_ball
        ball_box.Location = New Point(225, 219)
        ball_box.Name = "ball_box"
        ball_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        ball_box.Size = New Size(143, 130)
        ball_box.SizeMode = PictureBoxSizeMode.CenterImage
        ball_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        ball_box.TabIndex = 27
        ball_box.TabStop = False
        ball_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' CyberButton5
        ' 
        CyberButton5.Alpha = 20
        CyberButton5.BackColor = Color.Transparent
        CyberButton5.Background = True
        CyberButton5.Background_WidthPen = 4F
        CyberButton5.BackgroundPen = True
        CyberButton5.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        CyberButton5.ColorBackground_1 = Color.Transparent
        CyberButton5.ColorBackground_2 = Color.Transparent
        CyberButton5.ColorBackground_Pen = Color.White
        CyberButton5.ColorLighting = Color.White
        CyberButton5.ColorPen_1 = Color.Transparent
        CyberButton5.ColorPen_2 = Color.Transparent
        CyberButton5.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberButton5.Effect_1 = True
        CyberButton5.Effect_1_ColorBackground = Color.White
        CyberButton5.Effect_1_Transparency = 25
        CyberButton5.Effect_2 = True
        CyberButton5.Effect_2_ColorBackground = Color.White
        CyberButton5.Effect_2_Transparency = 20
        CyberButton5.Font = New Font("Rubik SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        CyberButton5.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberButton5.Lighting = False
        CyberButton5.LinearGradient_Background = False
        CyberButton5.LinearGradientPen = False
        CyberButton5.Location = New Point(218, 353)
        CyberButton5.Name = "CyberButton5"
        CyberButton5.PenWidth = 15
        CyberButton5.Rounding = True
        CyberButton5.RoundingInt = 35
        CyberButton5.Size = New Size(154, 43)
        CyberButton5.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton5.TabIndex = 26
        CyberButton5.Tag = "Cyber"
        CyberButton5.TextButton = "الـــكـــرة"
        CyberButton5.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton5.Timer_Effect_1 = 5
        CyberButton5.Timer_RGB = 300
        ' 
        ' parallelogram_box
        ' 
        parallelogram_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        parallelogram_box.Image = My.Resources.Resources.parallelogram
        parallelogram_box.Location = New Point(454, 278)
        parallelogram_box.Name = "parallelogram_box"
        parallelogram_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        parallelogram_box.Size = New Size(142, 72)
        parallelogram_box.SizeMode = PictureBoxSizeMode.CenterImage
        parallelogram_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        parallelogram_box.TabIndex = 25
        parallelogram_box.TabStop = False
        parallelogram_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' CyberButton4
        ' 
        CyberButton4.Alpha = 20
        CyberButton4.BackColor = Color.Transparent
        CyberButton4.Background = True
        CyberButton4.Background_WidthPen = 4F
        CyberButton4.BackgroundPen = True
        CyberButton4.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        CyberButton4.ColorBackground_1 = Color.Transparent
        CyberButton4.ColorBackground_2 = Color.Transparent
        CyberButton4.ColorBackground_Pen = Color.White
        CyberButton4.ColorLighting = Color.White
        CyberButton4.ColorPen_1 = Color.Transparent
        CyberButton4.ColorPen_2 = Color.Transparent
        CyberButton4.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberButton4.Effect_1 = True
        CyberButton4.Effect_1_ColorBackground = Color.White
        CyberButton4.Effect_1_Transparency = 25
        CyberButton4.Effect_2 = True
        CyberButton4.Effect_2_ColorBackground = Color.White
        CyberButton4.Effect_2_Transparency = 20
        CyberButton4.Font = New Font("Rubik SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CyberButton4.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberButton4.Lighting = False
        CyberButton4.LinearGradient_Background = False
        CyberButton4.LinearGradientPen = False
        CyberButton4.Location = New Point(448, 353)
        CyberButton4.Name = "CyberButton4"
        CyberButton4.PenWidth = 15
        CyberButton4.Rounding = True
        CyberButton4.RoundingInt = 35
        CyberButton4.Size = New Size(154, 43)
        CyberButton4.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton4.TabIndex = 24
        CyberButton4.Tag = "Cyber"
        CyberButton4.TextButton = "مـتـوازي الأضـلاع"
        CyberButton4.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton4.Timer_Effect_1 = 5
        CyberButton4.Timer_RGB = 300
        ' 
        ' trapezoid_box
        ' 
        trapezoid_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        trapezoid_box.Image = My.Resources.Resources.trapezoid
        trapezoid_box.Location = New Point(670, 277)
        trapezoid_box.Name = "trapezoid_box"
        trapezoid_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        trapezoid_box.Size = New Size(142, 73)
        trapezoid_box.SizeMode = PictureBoxSizeMode.CenterImage
        trapezoid_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        trapezoid_box.TabIndex = 23
        trapezoid_box.TabStop = False
        trapezoid_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' CyberButton7
        ' 
        CyberButton7.Alpha = 20
        CyberButton7.BackColor = Color.Transparent
        CyberButton7.Background = True
        CyberButton7.Background_WidthPen = 4F
        CyberButton7.BackgroundPen = True
        CyberButton7.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        CyberButton7.ColorBackground_1 = Color.Transparent
        CyberButton7.ColorBackground_2 = Color.Transparent
        CyberButton7.ColorBackground_Pen = Color.White
        CyberButton7.ColorLighting = Color.White
        CyberButton7.ColorPen_1 = Color.Transparent
        CyberButton7.ColorPen_2 = Color.Transparent
        CyberButton7.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberButton7.Effect_1 = True
        CyberButton7.Effect_1_ColorBackground = Color.White
        CyberButton7.Effect_1_Transparency = 25
        CyberButton7.Effect_2 = True
        CyberButton7.Effect_2_ColorBackground = Color.White
        CyberButton7.Effect_2_Transparency = 20
        CyberButton7.Font = New Font("Rubik SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CyberButton7.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberButton7.Lighting = False
        CyberButton7.LinearGradient_Background = False
        CyberButton7.LinearGradientPen = False
        CyberButton7.Location = New Point(663, 353)
        CyberButton7.Name = "CyberButton7"
        CyberButton7.PenWidth = 15
        CyberButton7.Rounding = True
        CyberButton7.RoundingInt = 35
        CyberButton7.Size = New Size(154, 43)
        CyberButton7.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton7.TabIndex = 19
        CyberButton7.Tag = "Cyber"
        CyberButton7.TextButton = "شـبـه الـمـنـحـرف"
        CyberButton7.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton7.Timer_Effect_1 = 5
        CyberButton7.Timer_RGB = 300
        ' 
        ' triangle_box
        ' 
        triangle_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        triangle_box.Image = My.Resources.Resources.triangle
        triangle_box.Location = New Point(21, 12)
        triangle_box.Name = "triangle_box"
        triangle_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        triangle_box.Size = New Size(130, 129)
        triangle_box.SizeMode = PictureBoxSizeMode.CenterImage
        triangle_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        triangle_box.TabIndex = 18
        triangle_box.TabStop = False
        triangle_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' circle_box
        ' 
        circle_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        circle_box.Image = My.Resources.Resources.circle
        circle_box.Location = New Point(229, 12)
        circle_box.Name = "circle_box"
        circle_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        circle_box.Size = New Size(139, 128)
        circle_box.SizeMode = PictureBoxSizeMode.CenterImage
        circle_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        circle_box.TabIndex = 17
        circle_box.TabStop = False
        circle_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' rectangle_box
        ' 
        rectangle_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        rectangle_box.Image = My.Resources.Resources.rectangle
        rectangle_box.Location = New Point(460, 34)
        rectangle_box.Name = "rectangle_box"
        rectangle_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        rectangle_box.Size = New Size(132, 109)
        rectangle_box.SizeMode = PictureBoxSizeMode.CenterImage
        rectangle_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        rectangle_box.TabIndex = 16
        rectangle_box.TabStop = False
        rectangle_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' square_box
        ' 
        square_box.BackColor = Color.FromArgb(CByte(192), CByte(196), CByte(204))
        square_box.Image = My.Resources.Resources.square
        square_box.Location = New Point(675, 12)
        square_box.Name = "square_box"
        square_box.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        square_box.Size = New Size(130, 131)
        square_box.SizeMode = PictureBoxSizeMode.CenterImage
        square_box.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        square_box.TabIndex = 15
        square_box.TabStop = False
        square_box.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' CyberButton3
        ' 
        CyberButton3.Alpha = 20
        CyberButton3.BackColor = Color.Transparent
        CyberButton3.Background = True
        CyberButton3.Background_WidthPen = 4F
        CyberButton3.BackgroundPen = True
        CyberButton3.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        CyberButton3.ColorBackground_1 = Color.Transparent
        CyberButton3.ColorBackground_2 = Color.Transparent
        CyberButton3.ColorBackground_Pen = Color.White
        CyberButton3.ColorLighting = Color.White
        CyberButton3.ColorPen_1 = Color.Transparent
        CyberButton3.ColorPen_2 = Color.Transparent
        CyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberButton3.Effect_1 = True
        CyberButton3.Effect_1_ColorBackground = Color.White
        CyberButton3.Effect_1_Transparency = 25
        CyberButton3.Effect_2 = True
        CyberButton3.Effect_2_ColorBackground = Color.White
        CyberButton3.Effect_2_Transparency = 20
        CyberButton3.Font = New Font("Rubik SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        CyberButton3.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberButton3.Lighting = False
        CyberButton3.LinearGradient_Background = False
        CyberButton3.LinearGradientPen = False
        CyberButton3.Location = New Point(11, 147)
        CyberButton3.Name = "CyberButton3"
        CyberButton3.PenWidth = 15
        CyberButton3.Rounding = True
        CyberButton3.RoundingInt = 35
        CyberButton3.Size = New Size(154, 43)
        CyberButton3.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton3.TabIndex = 14
        CyberButton3.Tag = "Cyber"
        CyberButton3.TextButton = "الــمــثــلــث"
        CyberButton3.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton3.Timer_Effect_1 = 5
        CyberButton3.Timer_RGB = 300
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
        CyberButton2.Location = New Point(218, 147)
        CyberButton2.Name = "CyberButton2"
        CyberButton2.PenWidth = 15
        CyberButton2.Rounding = True
        CyberButton2.RoundingInt = 35
        CyberButton2.Size = New Size(154, 43)
        CyberButton2.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberButton2.TabIndex = 13
        CyberButton2.Tag = "Cyber"
        CyberButton2.TextButton = "الــدائــرة"
        CyberButton2.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberButton2.Timer_Effect_1 = 5
        CyberButton2.Timer_RGB = 300
        ' 
        ' rectangle
        ' 
        rectangle.Alpha = 20
        rectangle.BackColor = Color.Transparent
        rectangle.Background = True
        rectangle.Background_WidthPen = 4F
        rectangle.BackgroundPen = True
        rectangle.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        rectangle.ColorBackground_1 = Color.Transparent
        rectangle.ColorBackground_2 = Color.Transparent
        rectangle.ColorBackground_Pen = Color.White
        rectangle.ColorLighting = Color.White
        rectangle.ColorPen_1 = Color.Transparent
        rectangle.ColorPen_2 = Color.Transparent
        rectangle.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        rectangle.Effect_1 = True
        rectangle.Effect_1_ColorBackground = Color.White
        rectangle.Effect_1_Transparency = 25
        rectangle.Effect_2 = True
        rectangle.Effect_2_ColorBackground = Color.White
        rectangle.Effect_2_Transparency = 20
        rectangle.Font = New Font("Rubik SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        rectangle.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        rectangle.Lighting = False
        rectangle.LinearGradient_Background = False
        rectangle.LinearGradientPen = False
        rectangle.Location = New Point(448, 147)
        rectangle.Name = "rectangle"
        rectangle.PenWidth = 15
        rectangle.Rounding = True
        rectangle.RoundingInt = 35
        rectangle.Size = New Size(154, 43)
        rectangle.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        rectangle.TabIndex = 12
        rectangle.Tag = "Cyber"
        rectangle.TextButton = "الـمـسـتـطـيـل"
        rectangle.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        rectangle.Timer_Effect_1 = 5
        rectangle.Timer_RGB = 300
        ' 
        ' square
        ' 
        square.Alpha = 20
        square.BackColor = Color.Transparent
        square.Background = True
        square.Background_WidthPen = 4F
        square.BackgroundPen = True
        square.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        square.ColorBackground_1 = Color.Transparent
        square.ColorBackground_2 = Color.Transparent
        square.ColorBackground_Pen = Color.White
        square.ColorLighting = Color.White
        square.ColorPen_1 = Color.Transparent
        square.ColorPen_2 = Color.Transparent
        square.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        square.Effect_1 = True
        square.Effect_1_ColorBackground = Color.White
        square.Effect_1_Transparency = 25
        square.Effect_2 = True
        square.Effect_2_ColorBackground = Color.White
        square.Effect_2_Transparency = 20
        square.Font = New Font("Rubik SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        square.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        square.Lighting = False
        square.LinearGradient_Background = False
        square.LinearGradientPen = False
        square.Location = New Point(663, 147)
        square.Name = "square"
        square.PenWidth = 15
        square.Rounding = True
        square.RoundingInt = 35
        square.Size = New Size(154, 43)
        square.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        square.TabIndex = 11
        square.Tag = "Cyber"
        square.TextButton = "الــمــربــع"
        square.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        square.Timer_Effect_1 = 5
        square.Timer_RGB = 300
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 512)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mz Calculator | الـــهـــنـــدســـة"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(cube_box, ComponentModel.ISupportInitialize).EndInit()
        CType(ball_box, ComponentModel.ISupportInitialize).EndInit()
        CType(parallelogram_box, ComponentModel.ISupportInitialize).EndInit()
        CType(trapezoid_box, ComponentModel.ISupportInitialize).EndInit()
        CType(triangle_box, ComponentModel.ISupportInitialize).EndInit()
        CType(circle_box, ComponentModel.ISupportInitialize).EndInit()
        CType(rectangle_box, ComponentModel.ISupportInitialize).EndInit()
        CType(square_box, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CyberButton3 As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents CyberButton2 As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents rectangle As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents square As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents circle_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents rectangle_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents square_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents trapezoid_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents CyberButton7 As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents triangle_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents parallelogram_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents CyberButton4 As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents cube_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents CyberButton6 As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents ball_box As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents CyberButton5 As ReaLTaiizor.Controls.CyberButton
End Class
