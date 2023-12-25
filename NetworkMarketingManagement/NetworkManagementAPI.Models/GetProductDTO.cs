using NetworkManagementAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class GetProductDTO
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Title { get; set; }

        //[Required]
        //public decimal Price { get; set; }
        //public virtual ICollection<GetDistributorSellDTO> DistributorSells { get; set; }

    }
}
