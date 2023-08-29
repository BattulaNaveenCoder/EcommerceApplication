using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    [Table("CartItems")]
    public class CartItems
    {
        #region Constant
        public const int PRICELENGTH = 200;
        public const int IDLENGTH = 100;
        #endregion
        [Key]
        [Column(TypeName = "INT")]
        public int CartId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(PRICELENGTH)]
        public decimal Price { get;set; }

        [Column(TypeName = "INT")]
        [StringLength(IDLENGTH)]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey("FkCartId")]
        public Carts carts { get; set; }
        public int FkCartId { get; set; }

        [ForeignKey("FkProductId")]
        public Products Products { get;set; }
        public int FkProductId { get; set; }


    }
}
