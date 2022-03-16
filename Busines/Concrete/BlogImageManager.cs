using Busines.Abstract;
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
    public class BlogImageManager : IBlogImageService
    {
        IBlogImageDal _BlogImageDal;

        public BlogImageManager(IBlogImageDal BlogImageDal)
        {
            _BlogImageDal = BlogImageDal;
        }

        public IResult Add(BlogImage BlogImage, IFormFile file)
        {
            var imageLımıt = _BlogImageDal.GetAll(c => c.BlogId == BlogImage.BlogId).Count;
            if (imageLımıt > 1)
            {
                return new ErrorResult();
            }
            var BlogImageResult = CategoryFileHelper.Upload(file);
            if (!BlogImageResult.Success)
            {
                return new ErrorResult(BlogImageResult.Message);
            }
            BlogImage.ImagePath = BlogImageResult.Message;
            _BlogImageDal.Add(BlogImage);
            return new SuccessResult("Basarili");

        }

        public IResult Delete(BlogImage BlogImage)
        {
            var image = _BlogImageDal.Get(d => d.Id == BlogImage.Id);
            if (image == null)
            {
                return new ErrorResult();
            }
            CategoryFileHelper.Delete(image.ImagePath);
            _BlogImageDal.Delete(BlogImage);
            return new SuccessResult();
        }

        public IDataResult<List<BlogImage>> GetAll()
        {
            return new SuccessDataResult<List<BlogImage>>(_BlogImageDal.GetAll());
        }

        public IDataResult<BlogImage> GetById(int Id)
        {
            return new SuccessDataResult<BlogImage>(_BlogImageDal.Get(d => d.Id == Id));
        }

        public IResult Update(IFormFile file, BlogImage BlogImage)
        {
            var image = _BlogImageDal.Get(d => d.Id == BlogImage.Id);
            if (image == null)
            {
                return new ErrorResult();
            }
            var updated = CategoryFileHelper.Update(file, image.ImagePath);
            if (!updated.Success)
            {
                return new ErrorResult(updated.Message);
            }
            BlogImage.ImagePath = updated.Message;
            _BlogImageDal.Update(BlogImage);
            return new SuccessResult();
        }
    }
}
