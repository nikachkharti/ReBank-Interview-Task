﻿using NetworkManagementAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkManagementAPI.Models
{
    public class DistributorDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [EnumDataType(typeof(Gender))]
        /// <summary>
        /// Male - 1
        /// Female - 2
        /// Other - 3
        /// </summary>
        [Required]
        public Gender Gender { get; set; }

        public string Image { get; set; }

        /// <summary>
        /// Who is recomendator of current distributor while registration.
        /// </summary>
        public int RecomendatorId { get; set; }

        /// <summary>
        /// How many recomendations distributor have.
        /// </summary>
        public int RecomendationsCount { get; set; }

        /// <summary>
        /// How many recomendations distributors children have max limit should be 121.
        /// </summary>
        /// 
        [Range(0, 121)]
        public int SubRecomendationsCount { get; set; }
        public virtual ICollection<GetAddressDTO> Addresses { get; set; }
        public virtual ICollection<GetContactInfoDTO> ContactInfos { get; set; }
        public virtual ICollection<GetPersonalIdentifierDTO> PersonalIdentifiers { get; set; }
        public virtual ICollection<GetDistributorSellDTO> DistributorSells { get; set; }

    }
}
