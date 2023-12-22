﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkManagementAPI.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        /// <summary>
        /// Actual - 1
        /// Legal - 2
        /// </summary>
        public AddressType AddressType { get; set; }

        [Required]
        [MaxLength(100)]
        public string AddressName { get; set; }
    }
}