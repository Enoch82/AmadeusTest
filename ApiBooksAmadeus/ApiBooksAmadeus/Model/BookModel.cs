using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBooksAmadeus.Model
{
    [Table(name: "Book")]
    public class BookModel
    {
        [Key]
        public int bookId { get; set; }
        [Column(TypeName = "varchar(200)"),
         Required(ErrorMessage = "The title is required")]
        public string title { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string subtitle { get; set; }
        
        [Column(TypeName = "varchar(200)"), Required(ErrorMessage = "The author is required")]
        public string authors { get; set; }
        
        [Column(TypeName = "varchar(200)"), Required(ErrorMessage = "The publishes is required")]
        public string publisher { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string isbn10 { get; set; }

        [Column(TypeName = "bigint")]
        public Int64 isbn13 { get; set; }

        [Column(TypeName = "int")]
        public int pages { get; set; }
        
        [Column(TypeName = "int"), Required(ErrorMessage = "The year is required")]
        public int year { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal rating { get; set; }
        
        [Column(TypeName = "varchar(2000)"), Required(ErrorMessage = "The description is required")]
        public string description { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal price { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string urlImage { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string url { get; set; }


        public int storeId { get; set; }
        public StoreModel Store { get; set; }
    }
}
