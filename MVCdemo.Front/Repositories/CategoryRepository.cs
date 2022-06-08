using MVCdemo.Front.Models;
using System.Linq;

namespace MVCdemo.Front.Repositories
{
    public class CategoryRepository 
        //只能對一個資料表(Bill 明天 教 泛型repository)
    {
        private readonly NorthwindContext context;
        public CategoryRepository()
        {
            this.context = new NorthwindContext();
        }

        public IQueryable<Category> GetAll()
        {
            IOrderedQueryable<Category> a = context.Categories
                .OrderBy(x=> x.CategoryId);//順手排個序

            return a;
        }

    }
}
