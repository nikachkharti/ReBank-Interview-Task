using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkManagementAPI.Entities
{
    public class ContactInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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

        [ForeignKey(nameof(Distributor))]
        [Required]
        public int DistributorId { get; set; }
        public virtual Distributor Distributor { get; set; }
    }
}
