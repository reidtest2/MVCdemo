using MVCdemo.Front.Models;
using MVCdemo.Front.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MVCdemo.Front.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository repository;

        public CategoryService()
        {
            this.repository = new CategoryRepository();
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return repository.GetAll();
        }

        public Category GetOneCategory( int id) //重用性
        {
            //return repository.GetAll()
            return this.GetAllCategory()
                .First(ca => ca.CategoryId == id);
        }
    }
}
