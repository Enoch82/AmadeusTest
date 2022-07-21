using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBooksAmadeus.Model
{
    [Table(name: "Store")]
    public class StoreModel
    {
        [Key]
        public int storeId { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string branchName { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string adress { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string phone { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string openTime { get; set; }
        
        public bool parking { get; set; }

        public bool delivery { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string? phoneDelivery { get; set; }

        public List<BookModel> Books { get; set; }
    }
}
