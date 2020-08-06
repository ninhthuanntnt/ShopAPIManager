using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagerAPI.Models
{
    [Table("TA_MAT_STOCK")]
    public class TaMatStock
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("I_Material")]
        public int? MatMaterialId { get; set; }
        [Column("I_Warehouse")]
        public int? MatWarehouseId { get; set; }
        [Column("I_Per_Manager")]
        public int? PerManagerId { get; set; }
        [Column("I_Status")]
        public int? Status { get; set; }
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
        [Column("T_Info_01")]
        public string Info01 { get; set; }
        [Column("T_Info_01")]
        public string Info02 { get; set; }
        [Column("D_Date_01")]
        public DateTime? Date01 { get; set; }
        [Column("D_Date_02")]
        public DateTime? Date02 { get; set; }
        [Column("D_Date_03")]
        public DateTime? Date03 { get; set; }
        [Column("D_Date_04")]
        public DateTime? Date04 { get; set; }

        // principal entity
        public TaPerPerson PerManager{ get; set; }
        public TaMatMaterial MatMaterial{ get; set; }
        public TaMatWarehouse MatWareHouse{ get; set; }
    }
}
