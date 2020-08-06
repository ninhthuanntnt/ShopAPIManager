Public Class MsgBoxTool
    Public Shared Sub doShowInfo(ByVal msg_key As String)
        MsgBox(LangTool.reqText(msg_key), MsgBoxStyle.Information, LangTool.reqMsgBoxTitle(LangTool.MSG_TITLE_INF) )
    End Sub
    Public Shared Sub doShowErr(ByVal msg_key As String)
        MsgBox(LangTool.reqText(msg_key), MsgBoxStyle.Critical, LangTool.reqMsgBoxTitle(LangTool.MSG_TITLE_ERR))
    End Sub
    Public Shared Sub doShowErr(ByVal msg_key As String, ByVal msg_other As String)
        MsgBox(LangTool.reqText(msg_key), MsgBoxStyle.Critical, LangTool.reqMsgBoxTitle(LangTool.MSG_TITLE_ERR))
    End Sub
    Public Shared Sub doShowExclam(ByVal msg_key As String)
        MsgBox(LangTool.reqText(msg_key), MsgBoxStyle.Exclamation, LangTool.reqMsgBoxTitle(LangTool.MSG_TITLE_EXCL))
    End Sub

    Public Shared Function reqMsgBox(ByVal msg_title_key As String, ByVal msg_content_key As String, ByVal msgBoxStyle As Integer)
        Return MsgBox(LangTool.reqText(msg_content_key), msgBoxStyle, LangTool.reqText(msg_title_key))
    End Function
     Public Shared Function reqMsgBox(ByVal msg_title_key As String, ByVal msg_content_key As String, ByVal msgBoxStyle As Integer,  ByVal ParamArray values() As String)
        Dim msg = LangTool.reqText(msg_content_key)
        msg = String.Format (msg,values )
        Return MsgBox(msg, msgBoxStyle, LangTool.reqText(msg_title_key))
    End Function
   
End Class
