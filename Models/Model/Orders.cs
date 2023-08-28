using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    [Table("Orders")]
    public class Orders
    {
        #region Constant
        public const int IDLENGTH = 100;
        #endregion
        [Key]
        [Column(TypeName = "INT")]
        [StringLength(IDLENGTH)]
        public int OrderIf { get;set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("FkUserId")]
        public Users Users { get; set; }
        public int FkUserId { get; set; }
    }
}
