Public Class ControlLocation
    Public Shared Function XPos(ByVal ctl As Control) As Integer
        If ctl.Parent Is Nothing Then
            Return ctl.Location.X
        Else
            Return ctl.Location.X + XPos(ctl.Parent)
        End If
    End Function

    Public Shared Function YPos(ByVal ctl As Control) As Integer
        If ctl.Parent Is Nothing Then
            Return ctl.Location.Y
        Else
            Return ctl.Location.Y + YPos(ctl.Parent)
        End If
    End Function
End Class
