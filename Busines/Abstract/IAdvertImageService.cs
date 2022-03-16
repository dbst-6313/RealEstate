using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IAdvertImageService
    {
        IDataResult<List<AdvertImage>> GetAll();
        IDataResult<AdvertImage> GetById(int Id);
        IResult Add(AdvertImage categoryImage, IFormFile file);
        IResult Update(IFormFile file, AdvertImage advertImage);
        IResult Delete(AdvertImage advertImage);
    }
}
