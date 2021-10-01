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
    public class MyHobbyManager : IMyHobbyService
    {
        IMyHobbyDal _myHobbyDal;

        public MyHobbyManager(IMyHobbyDal myHobbyDal)
        {
            _myHobbyDal = myHobbyDal;
        }

        public void Add(MyHobby myHobby)
        {
            _myHobbyDal.Add(myHobby);
        }

        public void Delete(MyHobby myHobby)
        {
            _myHobbyDal.Delete(myHobby);
        }

        public MyHobby GetById(int id)
        {
           return _myHobbyDal.GetById(id);
        }

        public List<MyHobby> GetList()
        {
            return _myHobbyDal.GetAll();
        }

        public void Update(MyHobby myHobby)
        {
            _myHobbyDal.Update(myHobby);
        }
    }
}
