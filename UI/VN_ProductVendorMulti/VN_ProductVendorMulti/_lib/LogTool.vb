Imports System
Imports System.IO
Public Class LogTool
    Friend Shared WithEvents Fact_UpdateInsertDeleteTableAdapter1 As Global.MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter = New Global.MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter()
    Public Shared Sub log(ByVal formName As String, ByVal formFunct As String, ByVal tabName As String, ByVal tabFunct As String, ByVal params As String, ByVal idLine As Integer)
        Try
            Fact_UpdateInsertDeleteTableAdapter1.Insert(formName, formFunct, tabName, tabFunct, params, Date.Now, idLine)
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub log(ByVal formName As String, ByVal formFunct As String, ByVal tabName As String, ByVal tabFunct As String, ByVal params As String, ByVal dt As Date, ByVal idLine As Integer)
        Try
            Fact_UpdateInsertDeleteTableAdapter1.Insert(formName, formFunct, tabName, tabFunct, params, dt, idLine)
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub Log(logMessage As String, filepath As String)
        Using w As StreamWriter = File.AppendText(filepath)
            log(logMessage, w)
        End Using
    End Sub

    Public Shared Sub Log(logMessage As String, w As TextWriter)
        'w.Write("Log Entry : ")
        w.Write("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString())
        w.WriteLine(" : {0}", logMessage)
        w.WriteLine("-------------------------------")
    End Sub
    Public Shared Sub DumpLog(filepath As String)
        Using r As StreamReader = File.OpenText(filepath)
            Dim line As String
            line = r.ReadLine()
            While Not (line Is Nothing)
                Console.WriteLine(line)
                line = r.ReadLine()
            End While
        End Using
    End Sub
    Public Shared Sub DumpLog(r As StreamReader)
        Dim line As String
        line = r.ReadLine()
        While Not (line Is Nothing)
            Console.WriteLine(line)
            line = r.ReadLine()
        End While
    End Sub

    Public Shared Sub Main()
        Using w As StreamWriter = File.AppendText("log.txt")
            Log("Test1", w)
            Log("Test2", w)
        End Using

        Using r As StreamReader = File.OpenText("log.txt")
            DumpLog(r)
        End Using
    End Sub
End Class


