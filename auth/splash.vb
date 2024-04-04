Imports System.Runtime
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Splash
    Private WithEvents timer As New System.Timers.Timer()
    Private WithEvents loginTimer As New System.Timers.Timer()


    Dim loadRose As Image = My.Resources.loginloadingrose
    Dim loadBlue As Image = My.Resources.loginloadingblue

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Image Load
        Me.Load1.Image = loadRose
        Me.Load2.Image = loadRose
        Me.Load3.Image = loadRose
        Me.PictureSplash.Image = My.Resources.man
        Me.PictureLogo.Image = My.Resources._4ufashion
        Me.iconMustache.Image = My.Resources.moustache
        timer.Interval = 200
        timer.Start()
        Timer1.Interval = 4000
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Start()



    End Sub
    Dim loadInc = 1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Load1.Click
        If loadInc = 1 Then
            Load1.Image = loadBlue
            loadInc += 1
        Else
            Load1.Image = loadRose
            loadInc += 1
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles Load2.Click
        If loadInc = 3 Then
            Load2.Image = loadBlue
            loadInc += 1
        Else
            Load2.Image = loadRose
            loadInc += 1
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Load3.Click
        If loadInc = 5 Then
            Load3.Image = loadBlue
            loadInc += 1
        Else
            Load3.Image = loadRose
            loadInc = 1
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As ElapsedEventArgs) Handles timer.Elapsed
        If loadInc = 1 Or loadInc = 2 Then
            PictureBox2_Click(sender, e)
        ElseIf loadInc = 3 Or loadInc = 4 Then
            PictureBox4_Click(sender, e)
        Else
            PictureBox3_Click(sender, e)
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Close()

    End Sub

    Private Sub PictureSplash_Click(sender As Object, e As EventArgs) Handles PictureSplash.Click

    End Sub
End Class

