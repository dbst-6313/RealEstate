using Busines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busines.Concrete
{
    public class AdvertManager : IAdvertService
    {
        IAdvertDal _advertDal;

        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;
        }

        public IResult Add(Advert advert)
        {
            _advertDal.Add(advert);
            return new SuccessResult();
        }

        public IResult Delete(Advert advert)
        {
            _advertDal.Delete(advert);
            return new SuccessResult();
        }

        public IDataResult<List<Advert>> GetAll()
        {
            return new SuccessDataResult<List<Advert>>(_advertDal.GetAll());
        }
        public IDataResult<List<AdvertDetailDto>> GetAllDetailsById(int id)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetailsById(id));
        }
        public IDataResult<List<AdvertDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails());
        }

        public IDataResult<Advert> GetById(int Id)
        {
            return new SuccessDataResult<Advert>(_advertDal.Get(p=>p.Id==Id));
        }

        public IResult Update(Advert advert)
        {
            _advertDal.Update(advert);
            return new SuccessResult();
        }

        public IDataResult<List<AdvertDetailDto>> GetAllAdvertsByAsc()
        {
            var allDatas = _advertDal.GetAdvertDetails();
           allDatas.Sort((a, b) => b.Price.CompareTo(a.Price));

            return new SuccessDataResult<List<AdvertDetailDto>>(allDatas);
        }
        public IDataResult<List<AdvertDetailDto>> GetAllAdvertsByDsc()
        {
            var allDatas = _advertDal.GetAdvertDetails();
            allDatas.Sort((a, b) => a.Price.CompareTo(b.Price));

            return new SuccessDataResult<List<AdvertDetailDto>>(allDatas);
        }
        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetailsByCategoryId(categoryId));
        }

        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByBuildTime(int buildTime)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails(a => a.BuildTime == buildTime));
        }

        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByCityAndMinMax(string city, int min, int max)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails(a => a.Price >= min && a.Price <= max && a.City == city));
        }
    

        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByCityAndMinMaxAndBuildTime(string city, int min, int max, int buildTime)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails(a => a.Price >= min && a.Price <= max && a.BuildTime == buildTime && a.City == city));
        }

        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByMinMaxAndBuildTime(int min, int max, int buildTime)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails(a => a.Price >= min && a.Price <= max &&a.BuildTime == buildTime));
        }

        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByBuildTimeAndCity(int buildTime, string city)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails(a => a.BuildTime == buildTime && a.City == city));
        }

        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByCity(string city)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails(a => a.City == city));
        }

        public IDataResult<List<AdvertDetailDto>> GetAllDetailsByMinMax(int min, int max)
        {
            return new SuccessDataResult<List<AdvertDetailDto>>(_advertDal.GetAdvertDetails(a => a.Price >= min && a.Price <= max));
        }
    }
}
