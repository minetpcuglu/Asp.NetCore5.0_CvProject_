using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Ability
    {
        [Key]
        public int AbilityId { get; set; }

        [StringLength(150)]
        public string MyAbility { get; set; }
    }
}
