Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)

        If ProgressBar1.Value = 10 Then
            Timer1.Interval = 80
        End If

        If ProgressBar1.Value = 25 Then
            Timer1.Interval = 300
        End If

        If ProgressBar1.Value = 50 Then
            Timer1.Interval = 100
        End If

        If ProgressBar1.Value = 75 Then
            Timer1.Interval = 500
        End If

        If ProgressBar1.Value = 85 Then
            Timer1.Interval = 150
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
        End If

    End Sub
End Class
