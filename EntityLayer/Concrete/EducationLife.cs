using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class EducationLife
    {
        [Key]
        public int EducationId { get; set; }

        [StringLength(170)]
        public string Title { get; set; }

        [StringLength(70)]
        public string SubTitle { get; set; }

        [StringLength(6)]
        public string NoteAverage { get; set; }
        public string Date { get; set; }

    }
}
