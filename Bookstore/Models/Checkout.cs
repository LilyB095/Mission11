using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Checkout
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a zip")]
        [StringLength(5, MinimumLength =5, ErrorMessage ="Please enter a valid 5-digit zip code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please include something fun to bring a smile to whomever processes your order :)")]
        public string RandomFact { get; set; }

        [BindNever]
        public bool OrderReceived { get; set; }

    }
}
