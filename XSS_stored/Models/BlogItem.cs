using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XSS_stored.Models
{
    public class BlogItem
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime createdDate { get; set; }
        [Required]
        [MinLength(10)]
        public string description { get; set; }
        [Required]
        public string author { get; set; }


    }
}

