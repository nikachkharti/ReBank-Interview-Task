using NetworkManagementAPI.Entities;
using NetworkManagmentAPI.Helper;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class AddPersonalIdentifierDTO
    {
        [Column(TypeName = "nvarchar(50)")]
        [EnumDataType(typeof(IdentityDocumentType))]
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
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        [ExpireDate(nameof(ReleaseDate))]
        public DateTime ExpireDate { get; set; }

        [MaxLength(100)]
        public string IssuingAuthority { get; set; }

        //[ForeignKey(nameof(Distributor))]
        //[Required]
        //public int DistributorId { get; set; }
        //public virtual Distributor Distributor { get; set; }
    }
}
