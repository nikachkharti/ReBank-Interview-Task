using NetworkManagementAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class AddAddressDTO
    {
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
        //[ForeignKey(nameof(Distributor))]
        //[Required]
        //public int DistributorId { get; set; }
        //public virtual Distributor Distributor { get; set; }
    }
}
