using BikeStoreApi.Entities.Production;
using BikeStoreApi.Repositories.Production;

namespace BikeStoreApi.Services.Production
{
    public class ProductionService : IProductionService
    {
        private readonly IProductionRepository _productionRepository;
        public ProductionService(IProductionRepository productionRepository) {
            this._productionRepository = productionRepository;
        }

        public Task<List<Brand>> GetAllBrands()
        {
            return _productionRepository.GetAllBrands();
        }

        public Task<List<Category>> GetAllCategories()
        {
            return _productionRepository.GetAllCategories();
        }

        public Task<List<Product>> GetAllProducts()
        {
            return _productionRepository.GetAllProducts();
        }
    }
}
