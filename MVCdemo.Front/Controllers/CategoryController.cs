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

        //對資料庫進行CRUD(增讀改刪)， 
        //其中R是唯一一個不會改變資料的，入門最容易
        //此僅以R為例，以了解分層

        public IActionResult ListAll() //多筆
        {
            List<Category> categories =
            //Lv1
            //context.Categories

            //Lv2
            repository.GetAll()

            //Lv3

                
            
            .ToList();

            //return Content(""); //加中斷點看
            return Json(categories);
        }

        public IActionResult Details(int id = 1) //單筆
        {
            Category category =
            //Lv1 
            //context.Categories
            //  .First(ca => ca.CategoryId == id);

            //Lv2
            repository.GetAll()
                .First(ca => ca.CategoryId == id);

            //Lv3



            //return Content(""); //加中斷點看
            return Json(category);
        }
    }
}
