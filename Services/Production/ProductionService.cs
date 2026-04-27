using BikeStoreApi.Entities;
using BikeStoreApi.Entities.Production;
using BikeStoreApi.Repositories.Production;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BikeStoreApi.Services.Production
{
    public class ProductionService : IProductionService
    {
        private readonly IProductionRepository _productionRepository;
        public ProductionService(IProductionRepository productionRepository) {
            this._productionRepository = productionRepository;
        }

        public GenericResponse<Brand> GetAllBrands()
        {
            var response = new GenericResponse<Brand>();

            var dbResult = _productionRepository.GetAllBrands();

            if (dbResult.IsFaulted)
            {
                response.Message = "Server error.";
                response.DataList = null;
                return response;
            }
            response.DataList = dbResult.Result;

            if (response.DataList.Count() == 0)
            {
                response.Message = "Not data found";
                return response;
            }
            response.Message = "Data found!";
            return response;
        }

        public GenericResponse<Category> GetAllCategories()
        {
            var response = new GenericResponse<Category>();

            var dbResult = _productionRepository.GetAllCategories();

            if (dbResult.IsFaulted)
            {
                response.Message = "Server error.";
                response.DataList = null;
                return response;
            }
            response.DataList = dbResult.Result;

            if (response.DataList.Count() == 0)
            {
                response.Message = "Not data found";
                return response;
            }
            response.Message = "Data found!";
            return response;
        }

        public GenericResponse<Product> GetAllProducts()
        {
            var response = new GenericResponse<Product>();

            var dbResult = _productionRepository.GetAllProducts();

            if (dbResult.IsFaulted)
            {
                response.Message = "Server error.";
                response.DataList = null;
                return response;
            }
            response.DataList = dbResult.Result;

            if (response.DataList.Count() == 0)
            {
                response.Message = "Not data found";
                return response;
            }
            response.Message = "Data found!";
            return response;
        }
    }
}
