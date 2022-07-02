using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace realWorldBE.Entities
{
    public class Article
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Body { get; set; }

        public ICollection<String> Tag { get; set; }
            = new List<String>();


    }
}
