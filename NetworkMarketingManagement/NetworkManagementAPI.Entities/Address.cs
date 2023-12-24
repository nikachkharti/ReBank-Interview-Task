using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkManagementAPI.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [EnumDataType(typeof(AddressType))]
        [Required]
        /// <summary>
        /// Actual - 1
        /// Legal - 2
        /// </summary>
        public AddressType AddressType { get; set; }

        [Required]
        [MaxLength(100)]
        public string AddressName { get; set; }


        [ForeignKey(nameof(Distributor))]
        [Required]
        public int DistributorId { get; set; }
        public virtual Distributor Distributor { get; set; }
    }
}
