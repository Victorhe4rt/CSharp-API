namespace webApiCrud.Models
{
    public interface IProductDescriptionRepository
    {
        void add(ProductDescription description);
        List<ProductDescription> GetAll();

        ProductDescription GetDescById(int id);

        bool DeleteProductById(int id);

        ProductDescription UpdateProductById(int productId,string description); 
    }
}
