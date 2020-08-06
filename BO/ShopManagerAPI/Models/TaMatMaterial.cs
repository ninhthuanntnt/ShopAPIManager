using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShopManagerAPI.Models;

namespace ShopManagerAPI.Models
{
    [Table("TA_MAT_MATERIAL")]
    public class TaMatMaterial
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("I_Status")]
        public int? Status { get; set; }

        [Column("I_Type_01")]
        public int? Type01 { get; set; }

        [Column("I_Type_02")]
        public int? Type02 { get; set; }

        [Column("I_Type_03")]
        public int? Type03 { get; set; }

        [Column("I_Name_01")]
        public string Name01 { get; set; }

        [Column("I_Name_02")]
        public string Name02 { get; set; }

        [Column("I_Code_01")]
        public string Code01 { get; set; }

        [Column("I_Code_02")]
        public string Code02 { get; set; }

        [Column("I_Code_03")]
        public string Code03 { get; set; }

        [Column("I_Code_04")]
        public string Code04 { get; set; }

        [Column("I_Code_05")]
        public string Code05 { get; set; }

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

        [Column("D_Date_03")]
        public DateTime? Date03 { get; set; }

        [Column("I_Per_Manager")]
        public int? PerManagerId { get; set; }

        [Column("I_Per_Person_01")]
        public int? PerPerson01Id { get; set; }

        [Column("I_Per_Person_02")]
        public int? PerPerson02Id { get; set; }


        // related entity
        [ForeignKey("MatMaterialId")]
        public ICollection<TaMatPricing> MatPricings {get; set;}

        [ForeignKey("MatMaterialId")]
        public ICollection<TaMatStock> MatStocks { get; set; }
        [ForeignKey("MatMaterialId")]
        public ICollection<TaSorOrderDetail> SorOrderDetails { get; set; }


        // principal entity
        //public PerPersonModel Manager { get; set; }
        //public PerPersonModel Person01 { get; set; }
        //public PerPersonModel Person02 { get; set; }
    }
}
