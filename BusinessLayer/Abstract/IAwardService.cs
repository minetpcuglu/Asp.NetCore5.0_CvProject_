using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAwardService
    {
        void Add(Award award);
        void Delete(Award award);
        void Update(Award award);
        List<Award> GetList();
        Award GetById(int id);
    }
}
