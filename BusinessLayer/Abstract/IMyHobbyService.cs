using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IMyHobbyService
    {
        void Add(MyHobby myHobby);
        void Delete(MyHobby myHobby);
        void Update(MyHobby myHobby);
        List<MyHobby> GetList();
        MyHobby GetById(int id);
    }
}
