using NetworkManagementAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class AddContactInfoDTO
    {
        [Column(TypeName = "nvarchar(50)")]
        [EnumDataType(typeof(ContactType))]
        [Required]
        /// <summary>
        /// Telephone - 1
        /// Mobile - 2
        /// Email - 3
        /// Fax - 4
        /// </summary>
        public ContactType ContactType { get; set; }

        [Required]
        [MaxLength(100)]
        public string ContactNumber { get; set; }

        //[ForeignKey(nameof(Distributor))]
        //[Required]
        //public int DistributorId { get; set; }
        //public virtual Distributor Distributor { get; set; }
    }
}
