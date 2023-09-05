namespace webApiCrud.Models
{
    public interface IProductDescriptionRepository
    {
        void add(ProductDescription description);

        List<ProductDescription> Get();
    }
}
