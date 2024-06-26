using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal) {
        
            _aboutDal=aboutDal;
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About entity)
        {
           _aboutDal.Insert(entity);
        }

        public void TDelete(About entity)
        {
           _aboutDal.Delete(entity);
        }

        public List<About> TGetList()
        {
           return _aboutDal.GetAll();
        }

        public void TUpdate(About entity)
        {
           _aboutDal.Update(entity);
        }
    }
}
