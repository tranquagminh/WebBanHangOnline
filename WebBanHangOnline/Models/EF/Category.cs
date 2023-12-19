using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("Category")]
    public class Category : CommonAbstract
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriptiond { get; set; }
        public int Position { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set;}
        public string SeoKeyWords { get; set; }
    }
}