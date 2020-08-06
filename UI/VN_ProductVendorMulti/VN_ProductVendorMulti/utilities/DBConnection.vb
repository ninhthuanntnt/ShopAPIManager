Public Class DBConnection
    Private Shared sErr As String
    Private Shared sCont = FileReader.GetFileContents("path.bin", sErr)

    Public Shared Function getStringConnection(ByVal sConnection) As String
        Return sConnection.Replace("1234567890", "chauhue")
    End Function
End Class
