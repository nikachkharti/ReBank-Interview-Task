using NetworkManagementAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class GetDistributorSellDTO
    {
        public int Id { get; set; }

        //[ForeignKey(nameof(Distributor))]
        //public int DistributorId { get; set; }
        //public DistributorDTO Distributor { get; set; }

        public DateTime SellDate { get; set; }


        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public GetProductDTO Product { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public int SellsCount { get; set; }
    }
}
