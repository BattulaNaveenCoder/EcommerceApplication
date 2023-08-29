using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    [Table("OrderLines")]
    public class OrderLines
    {
        #region Constant
        public const int IDLENGTH = 100;
        public const int PRICELENGTH = 200;
        #endregion


        [Key]
        [Column(TypeName = "INT")]
        public int OrderLineId { get;set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(PRICELENGTH)]
        public decimal Price { get; set; }

        [Column(TypeName = "INT")]
        [StringLength(IDLENGTH)]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }



        [ForeignKey("FkOrderId")]
        public Orders Orders { get; set; }  
        public int FkOrderId { get; set; }


        [ForeignKey("FkProductId")]
        public Products Products { get; set; }
        public int FkProductId { get; set; }
    }
}
