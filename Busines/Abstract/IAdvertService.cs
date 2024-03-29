﻿using Core.Utilities.Results;
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

        IDataResult<List<AdvertDetailDto>> GetAllDetailsByBuildTime(int buildTime);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByCityAndMinMax(string city,int min,int max);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByMinMax(int min,int max);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByCityAndMinMaxAndBuildTime(string city,int min,int max,int buildTime);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByMinMaxAndBuildTime(int min,int max,int buildTime);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByBuildTimeAndCity(int buildTime,string city);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByCity(string city);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsByCategoryId(int categoryId);
        IDataResult<List<AdvertDetailDto>> GetAllAdvertsByDsc();
        IDataResult<Advert> GetById(int Id);
        IDataResult<List<AdvertDetailDto>> GetAllDetailsById(int id);
    }
}
