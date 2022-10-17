using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCoreBackEnd.Models
{
    [Table("tr_bpkb", Schema = "dbo")]
    public class Trbpkb
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string agreement_number { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string bpkb_no { get; set; }
        
        [Column(TypeName = "varchar(10)")]
        public string branch_id { get; set; }
        
        [Column(TypeName = "datetime")]
        public string bpkb_date { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string faktur_no { get; set; }
        
        [Column(TypeName = "datetime")]
        public string faktur_date { get; set; }

        [ForeignKey("Msstoragelocation")]
        [Column(TypeName = "varchar(10)")]
        public string location_id { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string police_no { get; set; }
        
        [Column(TypeName = "datetime")]
        public string bpkb_date_in { get; set; }

        public virtual Msstoragelocation Msstoragelocation { get; set; }
    }
}
