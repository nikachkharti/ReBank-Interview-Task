using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Entities
{
    public class BonusHistory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Distributor")]
        public int DistributorId { get; set; }

        [ForeignKey("DistributorSell")]
        public int SaleId { get; set; }

        public decimal BonusAmount { get; set; }

        public DateTime DateCalculated { get; set; }

        public virtual Distributor Distributor { get; set; }
        public virtual DistributorSell DistributorSell { get; set; }
    }
}
