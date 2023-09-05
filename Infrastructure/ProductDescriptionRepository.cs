using webApiCrud.Models;
using webApiCrud.Infrastructure;
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

        public List<ProductDescription> Get()
        {
            return _connectionContext.ProductDescriptions.ToList();
        }
    }
}
