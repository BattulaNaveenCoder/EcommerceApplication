using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    [Table("SocialProfiles")]
    public class SocialProfiles
    {
        #region Constants
        public const int PROFILELENGTH = 200;
        public const int PLATFORMUSERLENGTH = 200;
        public const int IDLENGTH = 100;
        #endregion

        #region Properties
        [Key]
        [Column(TypeName = "INT")]
        [StringLength(IDLENGTH)]
        public int SocialProfileId { get; set; }

        [Required]
        public Platform platform { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(PLATFORMUSERLENGTH)]
        public string? PlatformUser { get;set; }

        public DateTime? CreatedAt { get; set;}

        [ForeignKey("FkUserId")]
        public Users? Users { get;set; }
        public int? FkUserId { get;set; }
        #endregion
    }

    public enum Platform
    {
        google=1,
        facebook,
        tweeter,
        email,
        instagram
    }
}
