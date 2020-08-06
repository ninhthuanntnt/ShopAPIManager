using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagerAPI.Models
{ 

    [Table("TA_AUT_AUTHORIZATION")]
    public class TaAutAuthorization
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("I_User")]
        public int? AutUserId { get; set; }

        [Column("I_Role")]
        public int? RoleId { get; set; }

        [Column("I_R1")]
        public int? R1 { get; set; }

        [Column("I_R2")]
        public int? R2 { get; set; }

        [Column("I_R3")]
        public int? R3 { get; set; }

        [Column("I_R4")]
        public int? R4 { get; set; }
        
        public TaAutUser AutUser { get; set; }
    }
}
