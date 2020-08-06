using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopManagerAPI.Models
{
    [Table("TA_MAT_WAREHOSE")]
    public class TaMatWarehouse
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("T_Name")]
        public string Name { get; set; }
        [Column("T_Info_01")]
        public string Info01 { get; set; }
        [Column("T_Info_02")]
        public string Info02 { get; set; }
        [Column("I_Per_Manager")]
        public int? PerManagerId { get; set; }


        // principal entity
        [NotMapped]
        public TaPerPerson PerManager { get; set; }


        // related entity

        // [ForeignKey("WarehouseId")]
        // public ICollection<MatStockIoModel> StockIos { get; set; }
        [ForeignKey("MatWarehouseId")]
        public ICollection<TaMatStock> MatStocks { get; set; }
    }
}
