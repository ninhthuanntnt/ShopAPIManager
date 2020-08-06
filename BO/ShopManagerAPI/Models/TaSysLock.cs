using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopManagerAPI.Models
{
    public class TaSysLock
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("I_Aut_User")]
        public int? AutUserId { get; set; }
        [Column("I_Val_01")]
        public int? Val01 { get; set; }
        [Column("I_Val_02")]
        public int? Val02 { get; set; }
        [Column("I_Status")]
        public int? Status { get; set; }
        [Column("D_Date_01")]
        public DateTime? Date01 { get; set; }
        [Column("D_Date_02")]
        public DateTime? Date02 { get; set; }

        // principal entity
        [NotMapped]
        public TaAutUser AutUser {get; set;}
    }
}
