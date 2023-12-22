using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkManagementAPI.Entities
{
    public class Distributor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Male - 1
        /// Female - 2
        /// Other - 3
        /// </summary>
        [Required]
        public Gender Gender { get; set; }

        public string Image { get; set; }

        public int RecomendatorId { get; set; }

        public virtual ICollection<PersonalIdentifier> PersonalIdentifiers { get; set; }

        public virtual ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
