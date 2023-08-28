using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    [Table("Reviews")]
    public class Reviews
    {
        #region Constants
        public const int COMMENTLENGTH = 5000;
        public const int IDLENGTH = 100;
        #endregion
        [Key]
        [Column(TypeName = "INT")]
        [StringLength(IDLENGTH)]
        public int ReviewId { get;set; }
        public int Rating { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(COMMENTLENGTH)]
        public string? Comment { get; set; }

        public DateTime CreatedAt { get;set; }

        [ForeignKey("FkUserId")]
        public Users Users { get; set; }
        public int FkUserId { get; set; }


    }
}
