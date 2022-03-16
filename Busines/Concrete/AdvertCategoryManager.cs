using Busines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class AdvertCategoryManager : IAdvertCategoryService
    {

        IAdvertCategoryDal _advertDal;

        public AdvertCategoryManager(IAdvertCategoryDal advertDal)
        {
            _advertDal = advertDal;
        }
        public IResult Add(AdvertCategory advert)
        {
            _advertDal.Add(advert);
            return new SuccessResult();
        }

        public IResult Delete(AdvertCategory advert)
        {
            _advertDal.Delete(advert);
            return new SuccessResult();
        }

        public IDataResult<List<AdvertCategory>> GetAll()
        {
            return new SuccessDataResult<List<AdvertCategory>>(_advertDal.GetAll());
        }

        public IDataResult<AdvertCategory> GetById(int Id)
        {
            return new SuccessDataResult<AdvertCategory>(_advertDal.Get(p => p.Id == Id));
        }

        public IResult Update(AdvertCategory advert)
        {
            _advertDal.Update(advert);
            return new SuccessResult();
        }
    }
}
