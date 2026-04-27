using BikeStoreApi.Data;
using BikeStoreApi.Entities.Production;
using BikeStoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeStoreApi.Repositories.Production
{
    public class ProductionRepository : IProductionRepository
    {
        private readonly DBContextSqlServer _devDBContext;
        public ProductionRepository(DBContextSqlServer devDBContext)
        {
            this._devDBContext = devDBContext;
        }
        public async Task<List<Brand>> GetAllBrands()
        {
            var brands = this._devDBContext.Brands.ToListAsync();
            return await brands;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            var categories = this._devDBContext.Categories.ToListAsync();
            return await categories;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = this._devDBContext.Products.ToListAsync();
            return await products;
        }
    }
}


