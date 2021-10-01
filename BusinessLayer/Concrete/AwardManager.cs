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
    public class AwardManager : IAwardService
    {
        IAwardDal _awardDal;

        public AwardManager(IAwardDal awardDal)
        {
            _awardDal = awardDal;
        }

        public void Add(Award award)
        {
            _awardDal.Add(award);
        }

        public void Delete(Award award)
        {
            _awardDal.Delete(award);
        }

        public Award GetById(int id)
        {
         return   _awardDal.GetById(id);
        }

        public List<Award> GetList()
        {
            return _awardDal.GetAll();
        }

        public void Update(Award award)
        {
            _awardDal.Update(award);
        }
    }
}
