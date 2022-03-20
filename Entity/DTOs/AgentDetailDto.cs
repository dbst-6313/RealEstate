using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class AgentDetailDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string OfficeNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedinLink { get; set; }
        public string InstagramLink { get; set; }
        public string YoutubeLink { get; set; }
        public string Description { get; set; }
        public int AdvertId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string CategoryName { get; set; }
        public List<string> Images { get; set; }
    }
}
