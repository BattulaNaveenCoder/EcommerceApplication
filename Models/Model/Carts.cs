using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    [Table("Carts")]
    public  class Carts
    {
        #region Constant
        public const int IDLENGTH = 100;
        #endregion

        public Carts() 
        {
            CartItems =new List<CartItems>();
        }

        [Key]
        [Column(TypeName = "INT")]
        public int CartId { get;set; }

        [Required]
        public Status Status { get;set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("FkuserId")]
        public Users Users { get; set; }
        public int FkuserId { get; set; }

        [InverseProperty("Carts")]
        public IList<CartItems> CartItems { get; set; }

    }
    public enum Status
    {
        active=1,
        ordered,
        abandonned
    }
}
