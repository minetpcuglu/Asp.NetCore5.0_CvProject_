using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Award
    {
        [Key]
        public int AwardId { get; set; }

        [StringLength(300)]
        public string AwardName { get; set; }
    }
}
