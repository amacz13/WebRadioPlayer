Imports MetroFramework.Controls
Imports NAudio.MediaFoundation
Imports NAudio.Wave

Public Class Form1

    Dim isPlaying As Boolean = False
    Dim radiosPicture As New Dictionary(Of String, Image)
    Dim radiosUrls As New Dictionary(Of String, String)
    Dim radiosControls As New Dictionary(Of String, MetroTile)
    'Dim mf As MediaFoundationReader
    'Dim wo As WaveOutEvent

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MetroTrackBar1.Value = AxWindowsMediaPlayer1.settings.volume

        LectureToolStripMenuItem.Enabled = False
        PauseToolStripMenuItem.Enabled = False

        radiosUrls.Add("Voltage", "http://start-voltage.ice.infomaniak.ch/start-voltage-high.mp3")
        radiosControls.Add("Voltage", MetroTile1)
        radiosUrls.Add("Vibration", "http://vibration.ice.infomaniak.ch/vibration-high.mp3")
        radiosControls.Add("Vibration", MetroTile3)
        radiosUrls.Add("SkyRock", "http://icecast.skyrock.net/s/natio_mp3_128k")
        radiosControls.Add("SkyRock", MetroTile4)
        radiosUrls.Add("Radio Vinci Autoroutes Centre Ouest", "http://str0.creacast.com/radio_vinci_autoroutes_1")
        radiosControls.Add("Radio Vinci Autoroutes Centre Ouest", MetroTile5)
        radiosUrls.Add("Forum", "http://start-forum.ice.infomaniak.ch/start-forum-high.mp3")
        radiosControls.Add("Forum", MetroTile7)
        radiosUrls.Add("NRJ", "http://cdn.nrjaudio.fm/audio1/fr/30001/mp3_128.mp3?origine=fluxradios")
        radiosControls.Add("NRJ", MetroTile8)
        radiosUrls.Add("Nostalgie", "http://cdn.nrjaudio.fm/audio1/fr/30601/mp3_128.mp3?origine=fluxradios")
        radiosControls.Add("Nostalgie", MetroTile6)
        MetroLabel1.Text = ""
    End Sub

    'SetPlaying : Update Tiles, send notification and set labels

    Private Sub SetPlaying(radio As String)
        If isPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
        'mf = New MediaFoundationReader(radiosUrls.Item(radio))
        'wo = New WaveOutEvent()
        'wo.Init(mf)
        'wo.Play()
        AxWindowsMediaPlayer1.URL = radiosUrls.Item(radio)
        For Each iter In radiosControls
            If iter.Key = radio Then
                iter.Value.Style = MetroFramework.MetroColorStyle.White
                iter.Value.Refresh()
            Else
                iter.Value.Style = MetroFramework.MetroColorStyle.Yellow
                iter.Value.Refresh()
            End If
        Next
        NotifyIcon1.ShowBalloonTip(10000, "WebRadioPlayer", "Vous écoutez : " + radio, ToolTipIcon.Info)
        MetroTile2.TileImage = My.Resources.pause50
        MetroTile2.Refresh()
        isPlaying = True
        MetroLabel1.Text = radio
        LectureToolStripMenuItem.Enabled = False
        PauseToolStripMenuItem.Enabled = True
    End Sub

    'Volume
    Private Sub MetroTrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles MetroTrackBar1.ValueChanged
        AxWindowsMediaPlayer1.settings.volume = MetroTrackBar1.Value
    End Sub

    'Voltage
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        SetPlaying("Voltage")
    End Sub

    'Vibration
    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        SetPlaying("Vibration")
    End Sub

    'Radio Vinci Autoroutes - Ouest
    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        SetPlaying("Radio Vinci Autoroutes Centre Ouest")
    End Sub

    'SkyRock
    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        SetPlaying("SkyRock")
    End Sub

    'Forum
    Private Sub MetroTile7_Click(sender As Object, e As EventArgs) Handles MetroTile7.Click
        SetPlaying("Forum")
    End Sub

    'NRJ
    Private Sub MetroTile8_Click(sender As Object, e As EventArgs) Handles MetroTile8.Click
        SetPlaying("NRJ")
    End Sub

    'Nostalgie
    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        SetPlaying("Nostalgie")
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        If isPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            MetroTile2.TileImage = My.Resources.play50
            isPlaying = False
            LectureToolStripMenuItem.Enabled = True
            PauseToolStripMenuItem.Enabled = False
        ElseIf AxWindowsMediaPlayer1.URL IsNot "" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            MetroTile2.TileImage = My.Resources.pause50
            isPlaying = True
            LectureToolStripMenuItem.Enabled = False
            PauseToolStripMenuItem.Enabled = True
        End If
    End Sub



    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MetroTrackBar1_MouseHover(sender As Object, e As EventArgs) Handles MetroTrackBar1.MouseHover
        MetroToolTip1.ToolTipTitle = "Volume"
        MetroToolTip1.SetToolTip(MetroTrackBar1, MetroTrackBar1.Value)
    End Sub

    Private Sub LectureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LectureToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        MetroTile2.TileImage = My.Resources.pause50
        isPlaying = True
        LectureToolStripMenuItem.Enabled = False
        PauseToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click

        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        MetroTile2.TileImage = My.Resources.play50
        isPlaying = False
        LectureToolStripMenuItem.Enabled = True
        PauseToolStripMenuItem.Enabled = False
    End Sub
End Class
