using BikeStoreApi.Entities.Production;

namespace BikeStoreApi.Repositories.Production
{
    public interface IProductionRepository
    {
        Task<List<Products>> GetAllProducts();

        Task<List<Brands>> GetAllBrands();
        Task<List<Categories>> GetAllCategories();
    }
}
