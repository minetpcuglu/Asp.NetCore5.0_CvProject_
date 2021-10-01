using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IExperienceService
    {
        void Add(Experience experience);
        void Delete(Experience experience);
        void Update(Experience experience);
        List<Experience> GetList();
        Experience GetById(int id);
    }
}
