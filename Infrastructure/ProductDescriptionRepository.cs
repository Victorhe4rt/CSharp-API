using webApiCrud.Models;
using webApiCrud.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace webApiCrud.Infrastructure
{
    public class ProductDescriptionRepository:IProductDescriptionRepository
    {
        private readonly ConnectionContextcs _connectionContext = new ConnectionContextcs();
        public void add(ProductDescription productDescription)
        {
            _connectionContext.Add(productDescription);
            _connectionContext.SaveChanges();
        }

        public List<ProductDescription> GetAll()
        {
            return _connectionContext.ProductDescriptions.ToList();
        }

        public ProductDescription GetDescById(int ID)
        {
            var productDescription = _connectionContext.ProductDescriptions.FirstOrDefault(x => x.ProductDescriptionId == ID);

            if (productDescription == null)
            {
                throw new Exception("ProductDescription not found for the given ID");
            }
            return productDescription;

        }

        public bool DeleteProductById (int ID)
        {
            try
            {
                var productToDelete = _connectionContext.ProductDescriptions.Where(x => x.ProductDescriptionId == ID);
                _connectionContext.ProductDescriptions.Remove(productToDelete);
                _connectionContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false; 
            }
           
        }

        public ProductDescription UpdateProductById(int productId, ProductDescription updatedProductDescription)
        {
            try
            {
                var productToUpdate = _connectionContext.ProductDescriptions.SingleOrDefault(x => x.ProductDescriptionId == productId);

                if (productToUpdate != null)
                {
                    productToUpdate.Property1 = updatedProductDescription.Property1;
                    productToUpdate.Property2 = updatedProductDescription.Property2;
                   _connectionContext.SaveChanges();
                    return productToUpdate;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
