using BikeStoreApi.Entities;
using BikeStoreApi.Entities.Production;
using BikeStoreApi.Repositories.Production;
using BikeStoreApi.Services.Production;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreApi.Controllers
{
    [Route("api/production")]
    [ApiController]
    public class ProductionController : Controller
    {
        private readonly IProductionService _productionService;

        public ProductionController(IProductionService productionService) {
            _productionService = productionService;
        }

        [HttpGet("test")]
        public IActionResult test()
        {
            var data = new { Message = "Api is working" };
            return Ok(data);
        }

        [HttpGet("getAllBrands")]
        public IActionResult getAllBrands()
        {
            GenericResponse<Brand> response = this._productionService.GetAllBrands();
            return Ok(response);
        }

        [HttpGet("getAllCategories")]
        public IActionResult getAllCategories()
        {
            GenericResponse<Category> response = this._productionService.GetAllCategories();
            return Ok(response);
        }

        [HttpGet("getAllProducts")]
        public IActionResult getAllProducts()
        {
            GenericResponse<Product> response = this._productionService.GetAllProducts();
            return Ok(response);
        }

    }
}
