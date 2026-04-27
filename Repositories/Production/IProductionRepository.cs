using BikeStoreApi.Entities.Production;

namespace BikeStoreApi.Repositories.Production
{
    public interface IProductionRepository
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Brand>> GetAllBrands();
        Task<List<Category>> GetAllCategories();
    }
}
