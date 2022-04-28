<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroTrackBar1 = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile9 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile7 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile8 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.LectureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoltageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VibrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkyRockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioVinciAutoroutesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NRJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NostalgieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTrackBar1
        '
        Me.MetroTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.MetroTrackBar1.Location = New System.Drawing.Point(231, 13)
        Me.MetroTrackBar1.Name = "MetroTrackBar1"
        Me.MetroTrackBar1.Size = New System.Drawing.Size(75, 23)
        Me.MetroTrackBar1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTrackBar1.TabIndex = 2
        Me.MetroTrackBar1.Text = "MetroTrackBar1"
        Me.MetroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.MetroTile9)
        Me.MetroPanel1.Controls.Add(Me.PictureBox1)
        Me.MetroPanel1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.MetroPanel1.Controls.Add(Me.MetroTile2)
        Me.MetroPanel1.Controls.Add(Me.MetroTrackBar1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 380)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(760, 50)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroTile9
        '
        Me.MetroTile9.ActiveControl = Nothing
        Me.MetroTile9.Location = New System.Drawing.Point(5, 8)
        Me.MetroTile9.Name = "MetroTile9"
        Me.MetroTile9.Size = New System.Drawing.Size(32, 32)
        Me.MetroTile9.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile9.TabIndex = 9
        Me.MetroTile9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile9.TileImage = Global.WebRadioPlayer.My.Resources.Resources.icons8_paramètres_filled_50
        Me.MetroTile9.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile9.UseSelectable = True
        Me.MetroTile9.UseTileImage = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(445, 12)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(141, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "WebRadioPlayer"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WebRadioPlayer.My.Resources.Resources.volume1
        Me.PictureBox1.Location = New System.Drawing.Point(185, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(742, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(18, 50)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(353, 0)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(50, 50)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile2.TabIndex = 4
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile2.TileImage = Global.WebRadioPlayer.My.Resources.Resources.play50
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.AutoScroll = True
        Me.MetroPanel2.Controls.Add(Me.MetroTile6)
        Me.MetroPanel2.Controls.Add(Me.MetroTile7)
        Me.MetroPanel2.Controls.Add(Me.MetroTile8)
        Me.MetroPanel2.Controls.Add(Me.MetroTile5)
        Me.MetroPanel2.Controls.Add(Me.MetroTile3)
        Me.MetroPanel2.Controls.Add(Me.MetroTile4)
        Me.MetroPanel2.Controls.Add(Me.MetroTile1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbar = True
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(760, 314)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroPanel2.TabIndex = 6
        Me.MetroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel2.VerticalScrollbar = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = True
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroTile6
        '
        Me.MetroTile6.ActiveControl = Nothing
        Me.MetroTile6.Location = New System.Drawing.Point(639, 3)
        Me.MetroTile6.Name = "MetroTile6"
        Me.MetroTile6.Size = New System.Drawing.Size(100, 100)
        Me.MetroTile6.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile6.TabIndex = 9
        Me.MetroTile6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile6.TileImage = Global.WebRadioPlayer.My.Resources.Resources.Nostalgie
        Me.MetroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile6.UseSelectable = True
        Me.MetroTile6.UseTileImage = True
        '
        'MetroTile7
        '
        Me.MetroTile7.ActiveControl = Nothing
        Me.MetroTile7.Location = New System.Drawing.Point(427, 3)
        Me.MetroTile7.Name = "MetroTile7"
        Me.MetroTile7.Size = New System.Drawing.Size(100, 100)
        Me.MetroTile7.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile7.TabIndex = 7
        Me.MetroTile7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile7.TileImage = Global.WebRadioPlayer.My.Resources.Resources.Forum
        Me.MetroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile7.UseSelectable = True
        Me.MetroTile7.UseTileImage = True
        '
        'MetroTile8
        '
        Me.MetroTile8.ActiveControl = Nothing
        Me.MetroTile8.Location = New System.Drawing.Point(533, 3)
        Me.MetroTile8.Name = "MetroTile8"
        Me.MetroTile8.Size = New System.Drawing.Size(100, 100)
        Me.MetroTile8.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile8.TabIndex = 8
        Me.MetroTile8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile8.TileImage = Global.WebRadioPlayer.My.Resources.Resources.NRJ
        Me.MetroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile8.UseSelectable = True
        Me.MetroTile8.UseTileImage = True
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.Location = New System.Drawing.Point(321, 3)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(100, 100)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile5.TabIndex = 6
        Me.MetroTile5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile5.TileImage = CType(resources.GetObject("MetroTile5.TileImage"), System.Drawing.Image)
        Me.MetroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile5.UseSelectable = True
        Me.MetroTile5.UseTileImage = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Location = New System.Drawing.Point(109, 3)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(100, 100)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile3.TabIndex = 4
        Me.MetroTile3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile3.TileImage = Global.WebRadioPlayer.My.Resources.Resources.Vibration
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.Location = New System.Drawing.Point(215, 3)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(100, 100)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile4.TabIndex = 5
        Me.MetroTile4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile4.TileImage = Global.WebRadioPlayer.My.Resources.Resources.SkyRock
        Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.UseSelectable = True
        Me.MetroTile4.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(3, 3)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(100, 100)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile1.TabIndex = 0
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile1.TileImage = Global.WebRadioPlayer.My.Resources.Resources.Voltage
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.MetroContextMenu1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "WebRadioPlayer"
        Me.NotifyIcon1.Visible = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LectureToolStripMenuItem, Me.PauseToolStripMenuItem, Me.RadioToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(114, 92)
        '
        'LectureToolStripMenuItem
        '
        Me.LectureToolStripMenuItem.Name = "LectureToolStripMenuItem"
        Me.LectureToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LectureToolStripMenuItem.Text = "Lecture"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'RadioToolStripMenuItem
        '
        Me.RadioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoltageToolStripMenuItem, Me.VibrationToolStripMenuItem, Me.SkyRockToolStripMenuItem, Me.RadioVinciAutoroutesToolStripMenuItem, Me.ForumToolStripMenuItem, Me.NRJToolStripMenuItem, Me.NostalgieToolStripMenuItem})
        Me.RadioToolStripMenuItem.Name = "RadioToolStripMenuItem"
        Me.RadioToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RadioToolStripMenuItem.Text = "Radio"
        '
        'VoltageToolStripMenuItem
        '
        Me.VoltageToolStripMenuItem.Name = "VoltageToolStripMenuItem"
        Me.VoltageToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VoltageToolStripMenuItem.Text = "Voltage"
        '
        'VibrationToolStripMenuItem
        '
        Me.VibrationToolStripMenuItem.Name = "VibrationToolStripMenuItem"
        Me.VibrationToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VibrationToolStripMenuItem.Text = "Vibration"
        '
        'SkyRockToolStripMenuItem
        '
        Me.SkyRockToolStripMenuItem.Name = "SkyRockToolStripMenuItem"
        Me.SkyRockToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SkyRockToolStripMenuItem.Text = "SkyRock"
        '
        'RadioVinciAutoroutesToolStripMenuItem
        '
        Me.RadioVinciAutoroutesToolStripMenuItem.Name = "RadioVinciAutoroutesToolStripMenuItem"
        Me.RadioVinciAutoroutesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RadioVinciAutoroutesToolStripMenuItem.Text = "Radio Vinci Autoroutes"
        '
        'ForumToolStripMenuItem
        '
        Me.ForumToolStripMenuItem.Name = "ForumToolStripMenuItem"
        Me.ForumToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ForumToolStripMenuItem.Text = "Forum"
        '
        'NRJToolStripMenuItem
        '
        Me.NRJToolStripMenuItem.Name = "NRJToolStripMenuItem"
        Me.NRJToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NRJToolStripMenuItem.Text = "NRJ"
        '
        'NostalgieToolStripMenuItem
        '
        Me.NostalgieToolStripMenuItem.Name = "NostalgieToolStripMenuItem"
        Me.NostalgieToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NostalgieToolStripMenuItem.Text = "Nostalgie"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "WebRadioPlayer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTrackBar1 As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile7 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile8 As MetroFramework.Controls.MetroTile
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents LectureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoltageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VibrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SkyRockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioVinciAutoroutesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NRJToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NostalgieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroTile9 As MetroFramework.Controls.MetroTile
End Class
