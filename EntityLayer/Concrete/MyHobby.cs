using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class MyHobby
    {
        [Key]
        public int HobbyId { get; set; }

        [StringLength(500)]
        public string Hobby { get; set; }
    }
}
