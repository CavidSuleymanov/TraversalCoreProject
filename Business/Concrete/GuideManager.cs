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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public Guide GetById(int id)
        {
            return _guideDal.GetByID(id);
        }

        public void TAdd(Guide entity)
        {
            _guideDal.Insert(entity);
        }

        public void TChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void TDelete(Guide entity)
        {
            _guideDal.Delete(entity);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetAll();      
        }

        public void TUpdate(Guide entity)
        {
           _guideDal.Update(entity);
        }
    }
}
