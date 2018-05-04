using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalPortfolio.Models
{
    [Table("Blogs")]
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}