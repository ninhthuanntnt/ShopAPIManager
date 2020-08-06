
Option Strict On
Option Explicit On

Namespace My
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared userOverrides() As String = { _
            "pharmacySQLConnectionString", _
            "factManagementConnectionString", _
            "posprinterConnectionString"
        }
        'pharmacySQLConnectionStringUserOverride
        'factManagementConnectionStringUserOverride
        'posprinterConnectionStringUserOverride

        Private Shared userOverrideSuffix As String = "UserOverride"

        Public Sub SetUserOverride(ByVal [property] As String, ByVal value As String)
            Me([property]) = value
        End Sub

       
        Private Sub userOverride_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            Dim userProperty As String
            For Each appProperty As String In userOverrides
                userProperty = appProperty & userOverrideSuffix
                If CType(Me(userProperty), String).Length > 0 Then
                    Me(appProperty) = AESTool.decrypt(Me(userProperty).ToString, SysConfig.commonPass)
                End If
            Next
        End Sub

        Private Sub userOverride_SettingsSaving(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.SettingsSaving
            Dim userProperty As String
            For Each appProperty As String In userOverrides
                userProperty = appProperty & userOverrideSuffix
                Me(userProperty) = AESTool.encrypt(Me(appProperty).ToString, SysConfig.commonPass)
            Next
        End Sub
    End Class
End Namespace

