using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConstructoraLibrary.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "City")]

        public string Name { get; set; }

        //[JsonIgnore]
        //[NotMapped]
        public int IdCountry { get; set; }

        //[JsonIgnore]
        public Country Country { get; set; }
    }
}
