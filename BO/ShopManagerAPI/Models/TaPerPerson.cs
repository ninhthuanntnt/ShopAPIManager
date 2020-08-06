using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace ShopManagerAPI.Models
{
    [Table("TA_PER_PERSON")]
    public class TaPerPerson
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
        [Column("T_Name_01")]
        public string Name01 { get; set; }
        [Column("T_Name_02")]
        public string Name02 { get; set; }
        [Column("T_Code_01")]
        public string Code01 { get; set; }
        [Column("T_Code_02")]
        public string Code02 { get; set; }
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
        [Column("I_Manager")]
        public int? PerManageId { get; set; }


        //related entity
        //[ForeignKey("ManagerId")]
        //public ICollection<MatMaterialModel> ManagerMaterials { get; set; }
        //[ForeignKey("Person01Id")]
        //public ICollection<MatMaterialModel> Person01Materials { get; set; }
        //[ForeignKey("Person02Id")]
        //public ICollection<MatMaterialModel> Person02Materials { get; set; }

        [ForeignKey("PerManagerId")]
        public ICollection<TaMatWarehouse> ManagerMatWarehouses { get; set; }

        [ForeignKey("PerManagerId")]
        public ICollection<TaMatUnit> ManagerMatUnits { get; set; }

        [ForeignKey("PerManagerId")]
        public ICollection<TaMatStock> ManagerMatStocks { get; set; }

        [ForeignKey("PerManagerId")]
        public ICollection<MatStockIoModel> ManagerMatStockIos { get; set; }

        [ForeignKey("PerManagerId")]
        public ICollection<TaAutUser> AutUsers { get; set; }

        [ForeignKey("PerManagerId")]
        public ICollection<TaSorOrder> ManagerSorOrders { get; set; }

        [ForeignKey("PerPerson01Id")]
        public ICollection<TaSorOrder> Person01SorOrders { get; set; }

        [ForeignKey("PerPerson02Id")]
        public ICollection<TaSorOrder> Person02SorOrders { get; set; }

        [ForeignKey("PerPerson03Id")]
        public ICollection<TaSorOrder> Person03SorOrders { get; set; }

        //[ForeignKey("Id")]
        //public PerPersonModel Manager { get; set; }
    }
}
