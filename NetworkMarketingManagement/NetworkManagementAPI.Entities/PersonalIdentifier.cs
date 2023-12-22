using NetworkManagmentAPI.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkManagementAPI.Entities
{
    public class PersonalIdentifier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// ID Card - 1
        /// Passport - 2
        /// </summary>
        [Required]
        public IdentityDocumentType DocumentType { get; set; }
        [MaxLength(50)]
        public string PersonalNumber { get; set; }

        [MaxLength(10)]
        public string DocumentSeries { get; set; }

        [MaxLength(10)]
        public string DocumentNumber { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [ExpireDate(nameof(ReleaseDate))]
        public DateTime ExpireDate { get; set; }

        [MaxLength(100)]
        public string IssuingAuthority { get; set; }

        [ForeignKey(nameof(Distributor))]
        [Required]
        public int DistributorId { get; set; }
        public virtual Distributor Distributor { get; set; }
    }
}
