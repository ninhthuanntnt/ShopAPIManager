Public Class LoginToManager
    Private myForm As MyForm
    Private myMenuItem As ToolStripMenuItem
    Private idFunction As Integer
    Private isAdmin, checked As Boolean

    Public Sub ShowMe(ByVal form As MyForm, ByVal menItem As ToolStripMenuItem, ByVal idF As Integer)
        myForm = form
        idFunction = idF
        myMenuItem = menItem
        Me.Show()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        login()
    End Sub

    Private Sub LoginToManager_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        checked = True
    End Sub
    Private Sub LoginToProductManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
    Private Sub login()
        checked = True
    End Sub

    Private Sub txtLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLogin.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtPass.Focus()
        End If
    End Sub

    Public Function verifyAdmin()
        idFunction = 1
        Me.Show()
        checked = False
        Return isAdmin
    End Function
  
    Private Sub LoginToManager_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.Focus()
    End Sub
End Class
