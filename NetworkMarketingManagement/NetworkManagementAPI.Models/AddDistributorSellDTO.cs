using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class AddDistributorSellDTO
    {
        public int DistributorId { get; set; }
        public DateTime SellDate { get; set; }

        public int ProductId { get; set; }
        [Required]
        public int SellsCount { get; set; }
    }
}
