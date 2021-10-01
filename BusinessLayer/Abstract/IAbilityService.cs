using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IAbilityService
    {
        void Add(Ability ability );
        void Delete(Ability ability);
        void Update(Ability ability);
        List<Ability> GetList();
        Ability GetById(int id);
    }
}
