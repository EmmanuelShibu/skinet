using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class CustomerBasketDTO
    {
        [Required]
        public string Id { get; set; }


        public List<BasketItemDTO> Items { get; set; }
    }
}