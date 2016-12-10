Imports System.Threading

Public Class mainForm
#Region "THREAD SAFE SET CONTROL"
    Delegate Sub SetTextCallback(ByVal [text] As String, ByVal tb As Control)
    Delegate Sub showControlCallback(flag As Boolean, ByVal tb As Control)

    Sub showControl(flag As Boolean, tb As Control)
        If tb.InvokeRequired Then
            Dim d As New showControlCallback(AddressOf showControl)
            Me.Invoke(d, New Object() {flag, tb})
        Else
            tb.Visible = flag
        End If
    End Sub
    Sub SetText(ByVal [text] As String, ByVal tb As Control)
        If tb.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text], tb})
        Else
            tb.Text = [text]
        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub cpUsername_Click(sender As Object, e As EventArgs) Handles cpUsername.Click
        Clipboard.SetText(tbUsername.Text)
    End Sub

    Private Sub cpPassword_Click(sender As Object, e As EventArgs) Handles cpPassword.Click
        Clipboard.SetText(tbPassword.Text)
    End Sub

    Private Sub btGenerate_Click(sender As Object, e As EventArgs) Handles btGenerate.Click
        Dim startThread As New Thread(AddressOf letsGen)
        startThread.Start()
    End Sub

#End Region

    Private Sub letsGen()
        showControl(True, pbLoading)
        If connTest("api.surfeasy.com") Then
            Dim opra As OprahProxy = New OprahProxy("se0306", "7502E43F3381C82E571733A350099BB5D449DD48311839C099ADC4631BA0CC04")
            opra.register_subscriber()
            opra.register_device()
            SetText(opra.getUsername, tbUsername)
            SetText(opra.getPassword, tbPassword)
        Else
            MessageBox.Show("Tidak bisa akses server VPN, pastikan koneksi internet terhubung", "Warning !!!")
        End If

        showControl(False, pbLoading)
    End Sub

    Private Function connTest(target As String) As Boolean
        Try
            If My.Computer.Network.Ping(target, 1000) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function


End Class
