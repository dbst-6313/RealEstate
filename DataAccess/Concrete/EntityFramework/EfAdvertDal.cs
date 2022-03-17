using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdvertDal : EfEntityRepositoryBase<Advert, RealEstateContext>, IAdvertDal
    {
        public List<AdvertDetailDto> GetAdvertDetails(Expression<Func<Advert, bool>> filter = null)
        {
            using(var context = new RealEstateContext())
            {
                var result = from a in filter == null ? context.adverts : context.adverts.Where(filter)
                             join c in context.advert_categories
                             on a.AdvertCategoryId equals c.Id
                             select new AdvertDetailDto
                             {
                                 ShortDescription = a.ShortDescription,
                                 AdvertCategoryId = a.AdvertCategoryId,
                                 Description = a.Description,
                                 DetailDescription = a.DetailDescription,
                                 AdvertCategoryName = c.Name,
                                 BuildTime = a.BuildTime,
                                 City = a.City,
                                 Id = a.Id,
                                 Images = (from i in context.advert_images where i.AdvertId == a.Id select i.ImagePath).ToList(),
                                 LikeCount = a.LikeCount,
                                 Location = a.Location,
                                 Price = a.Price
                                 ,
                                 Title = a.Title,
                                 YoutubeVideoLink = a.YoutubeVideoLink
                             };
                return result.ToList();
            }
        }
        public List<AdvertDetailDto> GetAdvertDetailsById(int id)
        {
            using (var context = new RealEstateContext())
            {
                var result = from a in context.adverts
                             where a.Id == id
                             join c in context.advert_categories
                             on a.AdvertCategoryId equals c.Id
                             select new AdvertDetailDto
                             {
                                 ShortDescription = a.ShortDescription,
                                 AdvertCategoryId = a.AdvertCategoryId,
                                 Description = a.Description,
                                 DetailDescription = a.DetailDescription,
                                 AdvertCategoryName = c.Name,
                                 BuildTime = a.BuildTime,
                                 City = a.City,
                                
                                 Id = a.Id,
                                 Images = (from i in context.advert_images where i.AdvertId == a.Id select i.ImagePath).ToList(),
                                 LikeCount = a.LikeCount,
                                 Location = a.Location,
                                 Price = a.Price
                                 ,
                                 Title = a.Title,
                                 YoutubeVideoLink = a.YoutubeVideoLink
                             };
                return result.Where(a => a.Id == id).ToList();
            }
        }
    }
}
