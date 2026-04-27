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
            List<Brand> brands = this._productionService.GetAllBrands().Result;
            if (brands.Count == 0)
            {
                var data = new { Message = "Not data" };
                return StatusCode(StatusCodes.Status203NonAuthoritative, data);
            }

            return Ok(brands);
        }

        [HttpGet("getAllCategories")]
        public IActionResult getAllCategories()
        {
            List<Category> categories = this._productionService.GetAllCategories().Result;
            if (categories.Count == 0)
            {
                var data = new { Message = "Not data" };
                return StatusCode(StatusCodes.Status203NonAuthoritative, data);
            }

            return Ok(categories);
        }

        [HttpGet("getAllProducts")]
        public IActionResult getAllProducts()
        {
            List<Product> products = this._productionService.GetAllProducts().Result;
            if(products.Count == 0)
            {
                var data = new { Message = "Not data" };
                return StatusCode(StatusCodes.Status203NonAuthoritative, data);
            }

            return Ok(products);
        }

    }
}
