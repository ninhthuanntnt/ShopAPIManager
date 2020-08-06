using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopManagerAPI.Models
{
    [Table("TA_SOR_ORDER_DETAIL")]
    public class TaSorOrderDetail
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("I_Order")]
        public int? SorOrderId { get; set; }
        [Column("I_Priority")]
        public int? Priority { get; set; }
        [Column("I_Mat_Material")]
        public int? MatMaterialId { get; set; }
        [Column("I_SellingPrice")]
        public int? SellingPriceId { get; set; }
        [Column("F_Val_00")]
        public double? Val00 { get; set; }
        [Column("F_Val_01")]
        public double? Val01 { get; set; }
        [Column("F_Val_02")]
        public double? Val02 { get; set; }
        [Column("F_Val_03")]
        public double? Val03 { get; set; }
        [Column("F_Val_04")]
        public double? Val04 { get; set; }
        [Column("F_Val_05")]
        public double? Val05 { get; set; }
        [Column("F_Val_06")]
        public double? Val06 { get; set; }
        [Column("F_Val_07")]
        public double? Val07 { get; set; }
        [Column("F_Val_08")]
        public double? Val08 { get; set; }
        [Column("F_Val_09")]
        public double? Val09 { get; set; }
        [Column("F_Val_10")]
        public double? Val10 { get; set; }
        [Column("T_Info_01")]
        public string Info01 { get; set; }
        [Column("T_Info_02")]
        public string Info02 { get; set; }
        [Column("T_Info_03")]
        public string Info03 { get; set; }
        [Column("T_Info_04")]
        public string Info04 { get; set; }
        [Column("T_Info_05")]
        public string Info05 { get; set; }
        [Column("D_Date_01")]
        public DateTime? Date01 { get; set; }
        [Column("D_Date_02")]
        public DateTime? Date02 { get; set; }

        public TaSorOrder SorOrder { get; set; }
        public TaMatMaterial MatMaterial { get; set; }

        // related entity
        [ForeignKey("SorOrderDetailId")]
        public ICollection<MatStockIoModel> MatStockIos { get; set; }
    }
}
