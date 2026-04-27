using BikeStoreApi.Entities;
using BikeStoreApi.Entities.Production;

namespace BikeStoreApi.Services.Production
{
    public interface IProductionService
    {
        GenericResponse<Product> GetAllProducts();

        GenericResponse<Brand> GetAllBrands();
        GenericResponse<Category> GetAllCategories();
    }
}
