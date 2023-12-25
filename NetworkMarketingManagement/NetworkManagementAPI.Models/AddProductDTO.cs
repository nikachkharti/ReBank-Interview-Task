using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class AddProductDTO
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
