using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagerAPI.Models
{
    [Table("TA_AUT_USER")]
    public class TaAutUser
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("I_Status")]
        public int? Status { get; set; }

        [Column("T_Login")]
        public string Login { get; set; }

        [Column("T_Pass")]
        public string Pass { get; set; }

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

        [Column("D_Date_01")]
        public DateTime? Date02 { get; set; }

        [Column("I_Per_Manager")]
        public int? PerManagerId { get; set; }

        public TaPerPerson PerManager { get; set; }

        [ForeignKey("AutUserId")]
        public ICollection<TaAutAuthorization> Authorizations { get; set; }

        [ForeignKey("AutUserId")]
        public ICollection<TaSysLock> SysLocks { get; set; }
        [ForeignKey("AutUser01Id")]
        public ICollection<TaSorOrder> AutUser01SorOrders { get; set; }
    }
}
