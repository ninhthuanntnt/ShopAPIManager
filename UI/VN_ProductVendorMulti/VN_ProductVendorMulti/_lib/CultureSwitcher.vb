Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Namespace SchedulerSwitchLocale
    'de co the chager duoc localized tu thu muc con khac, phai thay doi app.config
    '<configuration>
    '  <runtime>
    '    <assemblyBinding xmlns = "urn:schemas-microsoft-com:asm.v1" >
    '        <probing privatePath="bin;bin2\subbin;bin3"/>
    '    </assemblyBinding>
    '  </runtime>
    '</configuration>


    Public NotInheritable Class CultureSwitcher
        Public Shared ReadOnly LANG_VI_ID = 0
        Public Shared ReadOnly LANG_FR_ID = 1
        Public Shared ReadOnly LANG_EN_ID = 2


        Public Shared ReadOnly LANG_VI = "vi"
        Public Shared ReadOnly LANG_FR = "fr"
        Public Shared ReadOnly LANG_EN = "en"


        Public Shared APP_LANG = 0

        Private Shared privateCultureId As String
        Public Shared Property CultureId() As String
            Get
                Return privateCultureId
            End Get
            Private Set(ByVal value As String)
                privateCultureId = value
            End Set
        End Property

        Private Sub New()
        End Sub
  
        'must be called from ApplicationEvents.startup
        Public Shared Sub RestoreCulture()
            CultureId = My.Settings.setting_sysLang 
            If CultureId is Nothing or CultureId="" then CultureId = LANG_VI         
         
            If CultureId = LANG_VI Then
                APP_LANG = LANG_VI_ID
            ElseIf CultureId = LANG_FR Then
                APP_LANG = LANG_FR_ID
            ElseIf CultureId = LANG_EN Then
                APP_LANG = LANG_EN_ID
            End If


            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(CultureId)
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(CultureId)
        End Sub
    End Class

End Namespace
