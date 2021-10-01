using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EducationLifeManager : IEducationLifeService
    {
        IEducationLifeDal _educationLifeDal;

        public EducationLifeManager(IEducationLifeDal educationLifeDal)
        {
            _educationLifeDal = educationLifeDal;
        }

        public void Add(EducationLife educationLife)
        {
            _educationLifeDal.Add(educationLife);
        }

        public void Delete(EducationLife educationLife)
        {
            _educationLifeDal.Delete(educationLife);
        }

        public EducationLife GetById(int id)
        {
            return _educationLifeDal.GetById(id);
        }

        public List<EducationLife> GetList()
        {
          return  _educationLifeDal.GetAll();
        }

        public void Update(EducationLife educationLife)
        {
            _educationLifeDal.Update(educationLife);
        }
    }
}
