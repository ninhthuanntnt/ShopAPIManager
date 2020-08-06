using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopManagerAPI.Models
{
    [Table("TA_MAT_UNIT")]
    public class TaMatUnit
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("T_Name")]
        public string Name { get; set; }
        [Column("T_Code")]
        public string Code { get; set; }
        [Column("I_Status")]
        public int? Status { get; set; }
        [Column("D_Date_01")]
        public DateTime? Date01 { get; set; }
        [Column("D_Date_01")]
        public DateTime? Date02 { get; set; }
        [Column("I_Per_Manager")]
        public int? PerManagerId { get; set; }


        // principal entity
        [NotMapped]
        public TaPerPerson PerManager { get; set; }

        // related entity
        [ForeignKey("MatUnitId")]
        public ICollection<TaMatMaterial> Pricings{ get; set; }
    }
}
