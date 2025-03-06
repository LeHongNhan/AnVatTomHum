using AnVatTomHum.Data.Infrastructure;
using AnVatTomHum.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnVatTomHum.Model;
using Microsoft.SqlServer.Server;
using System.Linq;
namespace AnVatTomHum.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string Alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory) 
        {
            
        }

        public IEnumerable<ProductCategory> GetByAlias(string Alias)
        {
            return this.DbContext.ProductCategories.Where(c => c.Alias == Alias);
        }
    }
}
