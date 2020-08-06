Imports System.IO
Imports MyApplication.pharmacyDataSetTableAdapters
Imports MyApplication.factManagementDataSetTableAdapters

Public Class LangTool
    '0: vi , 1: fr, 2: en
    Private Shared win_lang = SchedulerSwitchLocale.CultureSwitcher.APP_LANG

    Shared Sub New()
         Select Case (win_lang)
            Case SchedulerSwitchLocale.CultureSwitcher.LANG_VI_ID
                 initLang(msg_vi)
            Case SchedulerSwitchLocale.CultureSwitcher.LANG_FR_ID
                 initLang(msg_fr)
            Case SchedulerSwitchLocale.CultureSwitcher.LANG_EN_ID
                 initLang(msg_vi)            
            Case Else
                 initLang(msg_vi)
        End Select 
        
       
    End Sub


    Private Shared ReadOnly MSG_TITLE_MAX = 2
    Public Shared ReadOnly MSG_TITLE_INF = 0
    Public Shared ReadOnly MSG_TITLE_EXCL = 1 'exclamation
    Public Shared ReadOnly MSG_TITLE_ERR = 2

    Private Shared tooltipMsg As String(,) = {
        {"Thông báo"    , "Chú ý"       , "Lỗi"},
        {"Information"  , "Attention"   , "Erreur"},
        {"Information"  , "Warning"     , "Error"}}
    
    Private Shared Sub setLang(ByVal lang As Integer)
        win_lang = lang
        If (lang < 0 Or lang > 1) Then lang = 0
    End Sub

    Public Shared Function reqMsgBoxTitle(ByVal type As Integer) As String
        If (type > MSG_TITLE_MAX Or type < 0) Then type = 0
        Return tooltipMsg(win_lang, type)
    End Function
     
    
    Private Shared _lang As New Dictionary(Of String, String)
    Public Shared Function reqText(ByVal key As String) As String
        Dim value = ""
        _lang.TryGetValue(key, value)
        If IsNothing (value) then value = key
        Return value
    End Function

    Private Shared Sub initLang(ByVal  msg As String(,))
        For i =0 to msg.GetLength(0)-1
            Dim key As string  = msg(i,0)
            If (key.IndexOf("---")>=0) then 
               Continue For 
            End If           
            Try
                _lang.Add(key,msg(i,1))
            Catch ex As Exception

            End Try  
        Next   
    End Sub


    Private Shared msg_vi As String(,) = {
        {"msg_err_generic", "Có lỗi phát sinh : "},
        {"msg_err_line_select", "Hãy chọn một dòng"},
        {"msg_err_db_conn", "Có lỗi kết nối, đợi vài giây rồi làm lại"},
        {"msg_confirm_title", "Chú ý"},
        {"msg_generic_currency", "đ"},
        {"-------------------------------------", "-------------------------------------"},
        {"msg_confirm_invoice_del", "Hóa đơn được chọn sẽ bị xóa vĩnh viễn, bạn thật sự muốn xóa?"},
        {"msg_err_invoice_del", "Hóa đơn được chọn không thể xóa, phải xóa các dòng trong hóa đơn trước."},
        {"msg_inf_invoice_del", "Hóa đơn đã được xóa"},
        {"msg_err_invoice_get", "Có lỗi khi lấy thông tin hóa đơn, SHH không tồn tại, hãy kiểm tra lại"},
        {"msg_err_invoice_mod", "Có lỗi khi cập nhật nội dung cũ của hóa đơn"},
        {"msg_err_invoice_unit_import", "Cần cho biết đơn vị nhập kho"},
        {"msg_err_invoice_quant_price_tax", "Xem lại việc nhập số lượng, giá thuốc và VAT"},
        {"msg_err_invoice_productName", "Cần nhập tên thuốc"},
        {"msg_err_invoice_producer", "Cần nhập hãng sản xuất"},
        {"msg_confirm_invoice_product_new", "Thông tin thuốc này chưa có trong danh mục thuốc, bạn thật sự muốn thêm vào?"},
        {"msg_err_invoice_line_ref", "Dòng nhập này chưa thêm vào bất kỳ hóa đơn nào nên không chuyển được"},
        {"msg_err_invoice_quant_change", "Đã có xuất trên dòng nhập này, không thể thay đổi số lượng đơn vị quá "},
        {"msg_inf_invoice_save", "Hóa đơn đã được lưu trữ thành công"},
        {"msg_err_invoice_product_import", "Không xác định được thuốc cần nhập"},
        {"msg_err_invoice_number_supplier", "Cần nhập số hóa đơn và nhà cung cấp"},
        {"msg_err_invoice_number_exist", "Số hóa đơn này đã tồn tại, hãy kiểm tra lại"},
        {"msg_confirm_invoice_new", "Hãy kiểm tra trước khi tiếp tục, nếu đồng ý tiếp tục, thông tin điền ở đây sẽ không thể sửa đổi sau đó để đảm bảo tính an toàn! Tiếp tục hay không?"},
        {"msg_exclam_invoice_unit_import", "Chỉ được phép chọn đơn vị trong danh mục vì thuốc này đã từng được nhập! Nếu lần nhập này có đv nhỏ hơn thì hãy tìm cách đổi cho ngang bằng"},
        {"-------------------------------------", "-------------------------------------"},
        {"msg_err_price_ratio", "Tỉ lệ chia nhỏ phải lớn hơn hoặc bằng 1, nếu là 1 thì đơn vị bán nên cùng loại với đơn vị nhập hàng"},
        {"msg_err_price_profit_negative", "Lợi nhuận không thể âm"},
        {"msg_err_price_del", "Không xóa được vì giá này đã từng được áp dụng bán"},
        {"-------------------------------------", "-------------------------------------"},
        {"msg_err_selling_price", "Thuốc này chưa áp dụng giá bán"},
        {"msg_err_selling_unit", "Cần chọn lại đơn vị bán ra"},
        {"msg_err_selling_quantity", "Không được phép bán với số lượng này"},
        {"msg_err_selling_price_ratio", "Không tìm thấy thông tin với giá và tỷ lệ bán của sản phẩm"},
        {"msg_err_selling_process", "Đang bán hàng, dữ liệu chưa lưu trữ không thể kết thúc"},
        {"msg_confirm_selling_save", "Nếu kết thúc sẽ không được sửa chữa?"},
        {"msg_confirm_selling_cancel", "Thật sự có muốn bỏ qua tất cả?"},
        {"msg_confirm_selling_discount", "Bạn muốn áp dụng khuyến mãi cho {0}? Cho phép khuyến mãi tối đa: {1} đ/{2} và nhân lên là: {3}đ/ {4} {5}"},
        {"msg_err_selling_generic", "Có lỗi, vui lòng kiểm tra lại đơn vị và số lượng cần bán"},
        {"msg_lab_selling_with_receipt", "In hóa đơn"},
        {"msg_lab_selling_without_receipt", "Không in HĐ"}
    }


    Private Shared msg_fr As String(,) = {
        {"msg_err_generic"                          , "Erreur inconnu : "},
        {"msg_err_line_select"                      , "Sélectionnez une ligne"},
		{"msg_err_db_conn"                      	, "Erreur de connexion, essayez ultérieurement"},
        {"msg_confirm_title"                        , "Attention"},
		{"msg_generic_currency"                     , "E"},
        {"-------------------------------------"    , "-------------------------------------"},
        {"msg_confirm_invoice_del"                  , "La facture sera supprimée, voulez-vous continuer?"},
        {"msg_err_invoice_del"                      , "Impossible de supprimer cette facture. Assurez-vous que cette facture soit vide"},
        {"msg_inf_invoice_del"                      , "La facture est supprimée"},
        {"msg_err_invoice_get"                      , "Erreur inconnu, impossible de récupérer les données de la facture"},
        {"msg_err_invoice_mod"                      , "Erreur inconnu, impossible de mettre à jour la facture"},
        {"msg_err_invoice_unit_import"              , "L'unité d'import est obligatoire"},
        {"msg_err_invoice_quant_price_tax"          , "Vérifiez la quantité, le prix et le tax"},
        {"msg_err_invoice_productName"              , "Le nom du produit est obligatoire"}, 
        {"msg_err_invoice_producer"                 , "Le produteur/lieu de production est obligatoire"},
        {"msg_confirm_invoice_product_new"          , "Ce produit n'existe pas encore, voulez-vous créer le nouveau?"},
        {"msg_err_invoice_line_ref"                 , "Cette ligne de données n'appartient à aucune facture, impossible de la transférer"},
        {"msg_err_invoice_quant_change"             , "Il y a déjà les opérations concernant cette ligne, impossible de modifier la quantité plus que "},
        {"msg_inf_invoice_save"                     , "La facture est sauvegardée"},
        {"msg_err_invoice_product_import"           , "Impossible de déterminer le produit"}, 
        {"msg_err_invoice_number_supplier"          , "Le numéro de la facture et le fournisseur sont les données obligatoires"},  
        {"msg_err_invoice_number_exist"             , "Ce numéro de la facture existe déjà"},  
        {"msg_confirm_invoice_new"                  , "Vérifiez l'entête de la facture. Voulez-vous créer une nouvelle facture?"},          
        {"msg_exclam_invoice_unit_import"           , "Impossible de sélectionner un autre unité d'import, recalculez la quantité d'import en se basant sur cet unité"},
        {"-------------------------------------"    , "-------------------------------------"},
        {"msg_err_price_ratio"                      , "Le ratio le plus petit est 1"},
        {"msg_err_price_profit_negative"            , "Le bénéfice ne peut pas être négatif"},
		{"msg_err_price_del"            			, "Immpossible de supprimer ce prix quand il était déjà appliqué dans une vente précédente"},
		{"-------------------------------------"    , "-------------------------------------"},
		{"msg_err_selling_price"            		, "Le prix de vente n'est pas encore appliqué à ce produit"},
		{"msg_err_selling_unit"            			, "Il faut selectioner l'unité de vente"},
		{"msg_err_selling_quantity"            		, "Cette quantité de vente est invalide, vérifiez le stock"},
		{"msg_err_selling_price_ratio"            	, "Impossible de retrouver l'information du prix et du ratio de vente"},
		{"msg_err_selling_process"            		, "Impossible de fermer la fenêtre, il faut terminer/annuler la vente actuelle"},
		{"msg_confirm_selling_save"                 , "Finir cette vente et la sauvegarder?"},
		{"msg_confirm_selling_cancel"               , "Voulez-vous annuler cette vente?"},
		{"msg_confirm_selling_discount"             , "Voulez-vous appliquer un discount pour {0}? Possibilité de discount : {1}E/{2} et en multiplication: {3}E/ {4} {5}"},
		{"msg_err_selling_generic"            		, "Un erreur généré, veuillez vérifier les données comme la quantité, l'unité de vente"},
        {"msg_lab_selling_with_receipt"            	, "Avec reçu"},
	    {"msg_lab_selling_without_receipt"          , "Non reçu"}
	}
End Class
