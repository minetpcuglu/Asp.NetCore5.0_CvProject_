using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IEducationLifeService
    {
        void Add(EducationLife educationLife);
        void Delete(EducationLife educationLife);
        void Update(EducationLife educationLife);
        List<EducationLife> GetList();
        EducationLife GetById(int id);
    }
}
