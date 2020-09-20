using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tree.DataAccess;
using Tree.Models;
using Tree.ViewModel;
using Newtonsoft.Json;

namespace Tree.Controllers
{
    public class HomeController : Controller
    {
        TreeviewContext tc = new TreeviewContext();
        // GET: Home
        public ActionResult Index()
        {
           var list = tc.Categories.ToList();

            var Tree =  FillRecursive(list, null);

            ViewBag.Tree = Json(new { flag = "1", data = Tree });
            
            return View();
        }
        
        [NonAction]
        private static List<TreeNode> FillRecursive(List<Categories> flatObjects, int? parentId = null)
        {
            return flatObjects.Where(x => x.ParentCategoryId.Equals(parentId)).Select(item => new TreeNode
            {


                CategoryName = item.CategoryName,
                CategoryId = item.CategoryId,
                Children = FillRecursive(flatObjects, item.CategoryId)
            }).ToList();
        }

    }
}