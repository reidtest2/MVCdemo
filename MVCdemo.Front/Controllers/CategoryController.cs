using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using MVCdemo.Front.Models;
//using MVCdemo.Front.Repositories;
using MVCdemo.Front.Services;

namespace MVCdemo.Front.Controllers
{
    public class CategoryController : Controller
    {
        //private readonly NorthwindContext context;
        //private readonly CategoryRepository repository;
        private readonly CategoryService service;

        public CategoryController()
        {
            //this.context = new NorthwindContext();
            //repository = new CategoryRepository();
            service = new CategoryService();
        }

        public IActionResult ListAll()//多筆
        {
            List<Category> categories =
                //Lv1
                //this.context.Categories

                //Lv2
                //repository.GetAll()

                //Lv3
                service.GetAllCategory()

                    .ToList();

            //return Content(""); //加中斷點
            return base.Json(categories); //轉JSON字串
        }

        public IActionResult Details(int id = 1) //單筆
        {
            Category category =
                //Lv1
                //context.Categories
                //    .First(x => x.CategoryId == id);

                //Lv2
                //repository.GetAll()
                //    .First(x => x.CategoryId == id);

                //Lv3
                service.GetOneCategory(id); //業務邏輯 集中到service

            return Json(category);
        }
    }
}
