namespace BlazorAppWithCosmosDb.Data
{
    public interface IProductService
    {
        public Task<List<Product>> GetProducts();
        public Task<Product> GetProduct(int productId);
    }
}