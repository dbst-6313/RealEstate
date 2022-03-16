using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class BlogDetailDto:IDto
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public int View { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<string> Images { get; set; }
    }
}
