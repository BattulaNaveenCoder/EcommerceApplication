using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Products
    {
        #region Constants
        public const int TITLELENGTH= 200;
        public const int PICTURELENGTH = 500;
        public const int SUMMERYLENGTH = 2000;
        public const int PRICLENGTH = 50;
        public const int IDLENGTH = 100;
        #endregion

        public Products() 
        {
            CartItems =new List<CartItems>();
            OrderLines = new List<OrderLines>();
            Tags=new List<string>();
        }

        #region Properties
        [Key]
        [Column(TypeName = "INT")]
        [StringLength(IDLENGTH)]
        public int ProductId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(TITLELENGTH)]
        public string Title { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(PICTURELENGTH)]
        public string Picture { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(SUMMERYLENGTH)]
        public string Summery { get; set; }        
        public decimal Price { get;set; }
        public DiscountType DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
        public List<string> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        [ForeignKey("FkCategoryId")]
        public Categories Categories { get; set; }
        public int FkCategoryId { get; set; }


        [InverseProperty("Products")]
        public IList<CartItems> CartItems { get; set; }

        [InverseProperty("Products")]
        public IList<OrderLines> OrderLines { get; set; }

        [InverseProperty("Products")]
        public IList<Reviews> Reviews { get; set; }

        #endregion
    }
    public enum DiscountType
    {
        none=1,
        percentage,
        amount
        
    }
}
