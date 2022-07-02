using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace realWorldBE.Entities
{
    public class User
    {
        [Key]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        public string Image { get; set; }
        public string Bio { get; set; }



    }
}
