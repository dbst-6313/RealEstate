using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Advert:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int LikeCount { get; set; } = 0;
        public int Price { get; set; }
        public int BuildTime { get; set; }
        public string ShortDescription { get; set; }
        public int AdvertCategoryId { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string YoutubeVideoLink { get; set; }
        public string DetailDescription { get; set; }
    }
}
