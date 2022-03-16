using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IAdvertCategoryService
    {
        IResult Add(AdvertCategory advert);
        IResult Update(AdvertCategory advert);
        IResult Delete(AdvertCategory advert);
        IDataResult<List<AdvertCategory>> GetAll();
        IDataResult<AdvertCategory> GetById(int Id);
    }
}
