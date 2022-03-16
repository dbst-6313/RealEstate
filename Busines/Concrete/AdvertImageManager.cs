using Busines.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class AdvertImageManager : IAdvertImageService
    {
        IAdvertImageDal _AdvertImageDal;

        public AdvertImageManager(IAdvertImageDal AdvertImageDal)
        {
            _AdvertImageDal = AdvertImageDal;
        }

        public IResult Add(AdvertImage AdvertImage, IFormFile file)
        {
            var imageLımıt = _AdvertImageDal.GetAll(c => c.AdvertId == AdvertImage.AdvertId).Count;
            if (imageLımıt > 1)
            {
                return new ErrorResult();
            }
            var AdvertImageResult = CategoryFileHelper.Upload(file);
            if (!AdvertImageResult.Success)
            {
                return new ErrorResult(AdvertImageResult.Message);
            }
            AdvertImage.ImagePath = AdvertImageResult.Message;
            _AdvertImageDal.Add(AdvertImage);
            return new SuccessResult("Basarili");

        }

        public IResult Delete(AdvertImage AdvertImage)
        {
            var image = _AdvertImageDal.Get(d => d.Id == AdvertImage.Id);
            if (image == null)
            {
                return new ErrorResult();
            }
            CategoryFileHelper.Delete(image.ImagePath);
            _AdvertImageDal.Delete(AdvertImage);
            return new SuccessResult();
        }

        public IDataResult<List<AdvertImage>> GetAll()
        {
            return new SuccessDataResult<List<AdvertImage>>(_AdvertImageDal.GetAll());
        }

        public IDataResult<AdvertImage> GetById(int Id)
        {
            return new SuccessDataResult<AdvertImage>(_AdvertImageDal.Get(d => d.Id == Id));
        }

        public IResult Update(IFormFile file, AdvertImage AdvertImage)
        {
            var image = _AdvertImageDal.Get(d => d.Id == AdvertImage.Id);
            if (image == null)
            {
                return new ErrorResult();
            }
            var updated = CategoryFileHelper.Update(file, image.ImagePath);
            if (!updated.Success)
            {
                return new ErrorResult(updated.Message);
            }
            AdvertImage.ImagePath = updated.Message;
            _AdvertImageDal.Update(AdvertImage);
            return new SuccessResult();
        }
    }
}
