using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(70)]
        public string SurName { get; set; }

        [StringLength(270)]
        public string ImagePath { get; set; }

        [StringLength(150),Required(), DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [DisplayName("Şifre:") ,Required(),MinLength(5),MaxLength(15),DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrarı:"),Required(),MinLength(5),MaxLength(15),DataType(DataType.Password), Compare(nameof(Password))]
        public string AgainPassword { get; set; }

        [StringLength(250)]
        public string Adress { get; set; }

        [StringLength(11)]
        public string TelephoneNumber { get; set; }

        [StringLength(700)]
        public string DipNot { get; set; }
        
    }
}
