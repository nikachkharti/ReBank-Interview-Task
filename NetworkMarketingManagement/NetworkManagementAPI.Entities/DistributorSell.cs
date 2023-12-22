using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkManagementAPI.Entities
{
    public class DistributorSell
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey(nameof(Distributor))]
        public int DistributorId { get; set; }
        public Distributor Distributor { get; set; }

        public DateTime SellDate { get; set; }


        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public int SellsCount { get; set; }
    }
}
