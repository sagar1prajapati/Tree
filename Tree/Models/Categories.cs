using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tree.Models
{
    public class Categories
    {
        [Key]
        public int  CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId  { get; set; }
        public string Remarks  { get; set; }
        
    }
}