using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{

    [Table("Users")]
    public class Users
    {
        #region Constants
        public const int IDLENGTH = 100;
        public const int EMAILLENGTH = 200;
        public const int PHONELENGTH = 30;
        public const int NAMELENGTH = 200;
        public const int AVATARYRLLENGTH = 2000;
        public const int COMPANYLENTH = 200;
        public const int BIOLENGTH = 5000;
        #endregion

        public Users()
        {
            Carts = new List<Carts>();
            Orders=new List<Orders>();
            SocialProfiles=new List<SocialProfiles>();
        }

        #region Properties
        [Key]
        [Column(TypeName ="INT")]       
        public int UserId { get; set; }

        [Required]
        [Column(TypeName ="VARCHAR")]
        [StringLength(EMAILLENGTH)]
        public string? Email { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(NAMELENGTH)]
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(PHONELENGTH)]
        public string? PhoneNumber { get; set; }

        [Required]
        public User Role { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(AVATARYRLLENGTH)]
        public string? Avatar { get; set; }

        public DateTime CretedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(BIOLENGTH)]
        public string? Bio { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(BIOLENGTH)]
        public string? Comapany { get; set; }

        [InverseProperty("Users")]
        public IList<Carts> Carts { get; set; }

        [InverseProperty("Users")]
        public IList<Orders> Orders { get; set; }


        [InverseProperty("Users")]
        public IList<SocialProfiles> SocialProfiles { get; set; }

        [InverseProperty("Users")]
        public IList<Reviews> Reviews { get; set; }
        #endregion
    }

    public enum User
    {
        customer=1,
        staff,
        admin
    }
}
