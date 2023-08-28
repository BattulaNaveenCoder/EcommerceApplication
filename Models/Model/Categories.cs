using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Categories
    {
        #region Constants
        public const int NAMELENGTH = 500;
        public const int DESCRIPTIONLENTH = 2000;
        public const int IDLENGTH = 100;

        #endregion

        public Categories() 
        {
            Products =new List<Products>();
            Tags = new List<string>();      
        }

        [Key]
        [Column(TypeName = "INT")]
        [StringLength(IDLENGTH)]
        public int CategoryId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(NAMELENGTH)]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(DESCRIPTIONLENTH)]
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

        [ForeignKey("FkCategoryId")]
        public Categories Category { get; set; }
        public int FkCategoryId { get; set; }


        [InverseProperty("Categories")]
        public IList<Products> Products { get; set; }


    }
}
