using Microsoft.AspNetCore.Mvc;
using webApiCrud.Models;
using webApiCrud.ViewModel;


namespace webApiCrud.Controllers
{
    [ApiController]
    [Route("api/v1/productDescription")]
    public class ProductDescriptionController : ControllerBase
    {
        private readonly IProductDescriptionRepository _productDescriptionRepository;

        public ProductDescriptionController(IProductDescriptionRepository productDescriptionRepository)
        {
            _productDescriptionRepository = productDescriptionRepository ?? throw new ArgumentNullException(nameof(productDescriptionRepository));
        }

        [HttpPost]
        public IActionResult Add(ProductDescriptionViewModel productDescriptionView)
        {
            var productDescriptionConstructor = new ProductDescription(
              productDescriptionView.Description,
              productDescriptionView.Rowguid,
              productDescriptionView.ModifiedDate
             );


            _productDescriptionRepository.add(productDescriptionConstructor);

            return Ok();

        }

        [HttpGet]

        public IActionResult Get()
        {
            var productDescription = _productDescriptionRepository.Get();

            return Ok(productDescription);

        }



    }
}
