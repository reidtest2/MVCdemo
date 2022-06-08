using MVCdemo.Front.Models;
using System.Linq;

namespace MVCdemo.Front.Repositories
{
    public class CategoryRepository 
        //只服務一個表 (bill叔明天 會示範 分層+泛型repo) 
    {
        private readonly NorthwindContext context;

        public CategoryRepository()
        {
            this.context = new NorthwindContext();
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories
                .OrderBy(x => x.CategoryId); //順手排個序
        }

        //還有其他 CUD...
    }
}
