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
    public class AbilityManager : IAbilityService
    {
        IAbilityDal _abilityDal;

        public AbilityManager(IAbilityDal abilityDal)
        {
            _abilityDal = abilityDal;
        }

        public void Add(Ability ability)
        {
            _abilityDal.Add(ability);
        }

        public void Delete(Ability ability)
        {
            _abilityDal.Delete(ability);
        }

        public Ability GetById(int id)
        {
            return _abilityDal.GetById(id);
        }

        public List<Ability> GetList()
        {
          return  _abilityDal.GetAll();
        }

        public void Update(Ability ability)
        {
            _abilityDal.Update(ability);
        }
    }
}
