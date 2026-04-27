using BikeStoreApi.Entities.Production;

namespace BikeStoreApi.Services.Production
{
    public interface IProductionService
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Brand>> GetAllBrands();
        Task<List<Category>> GetAllCategories();
    }
}
