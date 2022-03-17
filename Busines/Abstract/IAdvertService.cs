using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IAdvertService
    {
        IResult Add(Advert advert);
        IResult Update(Advert advert);
        IResult Delete(Advert advert);
        IDataResult<List<Advert>> GetAll();
        IDataResult<List<AdvertDetailDto>> GetAllAdvertsByAsc();
        IDataResult<List<AdvertDetailDto>> GetAllDetails();
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByCategoryId(int categoryId);
        IDataResult<List<AdvertDetailDto>> GetAllAdvertsByDsc();
        IDataResult<Advert> GetById(int Id);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsById(int id);
    }
}
