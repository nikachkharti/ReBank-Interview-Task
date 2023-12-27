using NetworkManagementAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace NetworkManagementAPI.Models
{
    public class AddDistributorDTO
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [EnumDataType(typeof(Gender))]
        /// <summary>
        /// Male - 1
        /// Female - 2
        /// Other - 3
        /// </summary>
        [Required]
        public Gender Gender { get; set; }
        public IFormFile ImageFile { get; set; }

        /// <summary>
        /// Who is recomendator of current distributor while registration.
        /// </summary>
        public int RecomendatorId { get; set; }
        public virtual ICollection<AddPersonalIdentifierDTO> PersonalIdentifiers { get; set; }
        public virtual ICollection<AddContactInfoDTO> ContactInfos { get; set; }
        public virtual ICollection<AddAddressDTO> Addresses { get; set; }
        //public virtual ICollection<AddDistributorSellDTO> DistributorSells { get; set; }
    }
}
