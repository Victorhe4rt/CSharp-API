using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
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
        [Authorize]
        [HttpPost("CreateProduct")]
        public IActionResult Add(ProductDescriptionViewModel productDescriptionView)
        {
            var productDescriptionConstructor = new ProductDescription(
              productDescriptionView.Description,
              productDescriptionView.Rowguid,
              productDescriptionView.ModifiedDate
        
             );

            try
            {
                _productDescriptionRepository.add(productDescriptionConstructor);
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
         
        }


        //[Authorize]
        [HttpGet("GetAllProducts")]
        public IActionResult GetAll()
        {
            try
            {
                var productDescription = _productDescriptionRepository.GetAll();
                return Ok(productDescription);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
          
        }

        [HttpGet("GetProductById")]
        public IActionResult GetDescById(int id)
        {
            try
            {
                var productDescription = _productDescriptionRepository.GetDescById(id);
                return Ok(productDescription);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete("DeleteProductById/{id}")]
        public IActionResult DeleteProductById(int id)
        {
            var result = _productDescriptionRepository.DeleteProductById(id);

            if (result ==true)
            {
                return Ok(result);
            }
            return BadRequest("Error deleting product or product not found");
        }



        [HttpPut("UpdateProductById/{id}")]
        public IActionResult UpdateProductById(int id, UpdateDescription updatedProductDescription)
        {
            var updatedProduct = _productDescriptionRepository.UpdateProductById(id,updatedProductDescription.newDescription);
            if (updatedProduct != null)
            {
                return Ok(updatedProduct);
            }
            return BadRequest("Error updating product or product not found");
        }






    }
}
