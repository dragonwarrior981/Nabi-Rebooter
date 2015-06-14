Imports RegawMOD.Android.RegawMOD.Android
' ReSharper disable once ClassNeverInstantiated.Global
Public Class Main

#Region "Variables"
    Private Const NoDevice As String = "Please make sure your device is plugged in and the proper drivers are installed!"
    Private Const NoDeviceCap As String = "No device detected"
    Private _android As AndroidController
    Private _device As Device
    Private Const NewLine As String = ControlChars.CrLf
#End Region

#Region "Page Events"
    ' ReSharper disable once MemberCanBePrivate.Global
    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
        Icon = My.Resources.Icon
        Text += String.Format(" {0}", My.Application.Info.Version.ToString)
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Usually, you want to load this at startup, may take up to 5 seconds to initialize/set up resources/start server
        _android = AndroidController.Instance

        Dim serial As String
        Dim deviceState As String
        Dim hasRoot As String

        'Always call UpdateDeviceList() before using AndroidController on devices to get the most updated list
        _android.UpdateDeviceList()

        If _android.HasConnectedDevices Then
            serial = _android.ConnectedDevices(0)
            _device = _android.GetConnectedDevice(serial)
            If _device.State = 0 Then
                deviceState = "Online"
            ElseIf _device.State = 1 Then
                deviceState = "Offline"
            ElseIf _device.State = 2 Then
                deviceState = "Recovery"
            ElseIf _device.State = 3 Then
                deviceState = "Fastboot"
            Else
                deviceState = "Unknown"
            End If
            If Not _device.HasRoot Then
                hasRoot = "Rooted"
            Else
                hasRoot = "Not Rooted"
            End If
            lblPhoneConnect.Text = String.Format("{0}     {1}     {2}", _device.SerialNumber, deviceState, hasRoot)
            btnGo.Visible = True
        End If

    End Sub
    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CheckFor_()
        txtBody.AppendText("Starting adb server...")
        NewConLine()

        _android = New AndroidController()

        txtBody.AppendText("adb server started successfully...")
        NewConLine()

        timerCursor.Enabled = True
        timerPhone.Enabled = True

        timerCursor.Start()
        timerPhone.Start()
        If Not _android.HasConnectedDevices Then
            MessageBox.Show(NoDevice, NoDeviceCap, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
    End Sub
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _android.Dispose()
    End Sub
#End Region

#Region "Functions"
    Private Sub CheckFor_()
        If txtBody.Text.LastIndexOf("_"c) = txtBody.Text.Length - 1 Then
            txtBody.Text = txtBody.Text.Remove(txtBody.Text.LastIndexOf("_"c))
        End If
    End Sub
    Private Sub NewConLine()
        txtBody.AppendText(NewLine + NewLine & ">")
    End Sub
#End Region

#Region "Timers"
    Private Sub timerCursor_Tick(sender As Object, e As EventArgs) Handles timerCursor.Tick
        If txtBody.Text.LastIndexOf("_"c) = txtBody.Text.Length - 1 Then
            txtBody.Text = txtBody.Text.Remove(txtBody.Text.LastIndexOf("_"c))
        Else
            txtBody.AppendText("_")
        End If
    End Sub
    Private Sub timerPhone_Tick(sender As Object, e As EventArgs) Handles timerPhone.Tick
        _android.UpdateDeviceList()

        If Not _android.HasConnectedDevices Then
            _device = Nothing
            ' ReSharper disable once LocalizableElement
            lblPhoneConnect.Text = "Nabi Not Connected"
            btnGo.Visible = False
        ElseIf _device IsNot Nothing AndAlso _device.SerialNumber = _android.ConnectedDevices(0) Then
            Return
        Else
            Dim deviceState As String

            _device = _android.GetConnectedDevice()

            If _device.State = 0 Then
                deviceState = "Online"
            ElseIf _device.State = 1 Then
                deviceState = "Offline"
            ElseIf _device.State = 2 Then
                deviceState = "Recovery"
            ElseIf _device.State = 3 Then
                deviceState = "Fastboot"
            Else
                deviceState = "Unknown"
            End If

            lblPhoneConnect.Text = String.Format("{0} Connected in {1} Mode.", _device.SerialNumber, deviceState)
            btnGo.Visible = True

        End If
    End Sub
#End Region

#Region "Button Ckicked Events"
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        _device.Reboot()
    End Sub
#End Region

End Class
