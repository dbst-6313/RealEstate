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
    public class EfAgentDal : EfEntityRepositoryBase<Agent, RealEstateContext>, IAgentDal
    {
        public List<AgentDetailDto> GetAdvertDetails(Expression<Func<Agent, bool>> filter = null)
        {
            using (var context = new RealEstateContext())
            {
                var result = from a in filter == null ? context.agents : context.agents.Where(filter)
                             join advert in context.adverts
                             on a.Id equals advert.AgentId
                             join advertCat in context.advert_categories
                             on advert.AdvertCategoryId equals advertCat.Id
                             select new AgentDetailDto
                             {
                                 AdvertId = advert.Id,
                                 CategoryName = advertCat.Name,
                                 City = advert.City,
                                 Description = a.Description,
                                 Email = a.Description,
                                 Id = a.Id,
                                 Images = (from i in context.advert_images where i.AdvertId == a.Id select i.ImagePath).ToList(),
                                 InstagramLink = a.InstagramLink,
                                 LinkedinLink = a.LinkedinLink,
                                 Location = advert.Location,
                                 MobileNumber = a.MobileNumber,
                                 Name = a.Name,
                                 OfficeNumber = a.OfficeNumber,
                                 Price = advert.Price,
                                 Role = a.Role,
                                 Title = advert.Title,
                                 TwitterLink = a.TwitterLink,
                                 YoutubeLink = a.YoutubeLink
                             };
                return result.ToList();
                             


            }
        }
    }
}
