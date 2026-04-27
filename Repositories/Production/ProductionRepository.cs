using BikeStoreApi.Entities.Production;

namespace BikeStoreApi.Repositories.Production
{
    public class ProductionRepository : IProductionRepository
    {
        public Task<List<Brands>> GetAllBrands()
        {
            return Task.FromResult(new List<Brands>()); // Empty data for testing
        }

        public Task<List<Categories>> GetAllCategories()
        {
            return Task.FromResult(new List<Categories>()); // Empty data for testing
        }

        public Task<List<Products>> GetAllProducts()
        {
            return Task.FromResult(new List<Products>()); // Empty data for testing
        }
    }
}
