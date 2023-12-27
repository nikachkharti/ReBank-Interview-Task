using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class AddDistributorSellDTO
    {
        //[ForeignKey(nameof(Distributor))]
        public int DistributorId { get; set; }
        //public AddDistributorDTO Distributor { get; set; }
        public DateTime SellDate { get; set; }

        //[ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        //public AddProductDTO Product { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public int SellsCount { get; set; }
    }
}
