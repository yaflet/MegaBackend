using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCoreBackEnd.Models
{
    [Table("ms_storage_location", Schema = "dbo")]
    public class Msstoragelocation
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string location_id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string location_name { get; set; }
    }
}
