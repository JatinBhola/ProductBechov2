using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductBecho.DE.DataEntities
{
    public class User
    {
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)] 
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Phone]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
