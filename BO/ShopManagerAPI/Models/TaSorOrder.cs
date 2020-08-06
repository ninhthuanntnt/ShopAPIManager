using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopManagerAPI.Models
{
    [Table("TA_SOR_ORDER")]
    public class TaSorOrder
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("T_Code_01")]
        public double? Code01 { get; set; }
        [Column("T_Code_01")]
        public double? Code02 { get; set; }
        [Column("I_Status")]
        public int? Status { get; set; }
        [Column("I_Type_01")]
        public int? Type01 { get; set; }
        [Column("I_Type_02")]
        public int? Type02 { get; set; }
        [Column("I_Type_03")]
        public int? Type03 { get; set; }
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
        [Column("D_Date_03")]
        public DateTime? Date03 { get; set; }

        [Column("I_Per_Manager")]
        public int? PerManagerId { get; set; }

        [Column("I_Per_Person_01")]
        public int? PerPerson01Id { get; set; }

        [Column("I_Per_Person_02")]
        public int? PerPerson02Id { get; set; }

        [Column("I_Per_Person_03")]
        public int? PerPerson03Id { get; set; }

        [Column("I_Aut_User_01")]
        public int? AutUser01Id { get; set; }

        [Column("I_Aut_User_02")]
        public int? AutUser02Id { get; set; }


        //principal entity
        [InverseProperty("ManagerSorOrders")]
        public TaPerPerson PerManager {get; set; }
        [InverseProperty("Person01SorOrders")]
        public TaPerPerson PerPerson01 { get; set; }
        [InverseProperty("Person02SorOrders")]
        public TaPerPerson PerPerson02 { get; set; }
        [InverseProperty("Person03SorOrders")]
        public TaPerPerson PerPerson03 { get; set; }
        public TaAutUser AutUser01 {get; set;}

        // related entity
        [ForeignKey("SorOrderId")]
        public ICollection<MatStockIoModel> MatStockIos { get; set; }
        [ForeignKey("SorOrderId")]
        public ICollection<TaSorOrderDetail> SorOrderDetails { get; set; }
    }
}
