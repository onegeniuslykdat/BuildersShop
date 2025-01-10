using BlazorAppWithCosmosDb.Clients;
using Microsoft.Azure.Cosmos;

namespace BlazorAppWithCosmosDb.Data
{
    public class ProductService : IProductService
    {
        private readonly Container cosmosContainer;
        public ProductService(ICosmosDbClient _cosmosDbClient, IConfiguration configuration)
        {
            string productsDbId = configuration.GetValue<string>("CosmosDb:Database");
            string containerId = configuration.GetValue<string>("CosmosDb:ProductsContainer");
            cosmosContainer = _cosmosDbClient.GetClient().GetContainer(productsDbId, containerId);
        }
        public async Task<Product> GetProduct(int productId)
        {
            var products = await GetProducts();
            if(products == null || products.Count == 0)
            {
                return null!;
            } else
            {
                return products.FirstOrDefault(p => p.ProductId == productId)!;
            }
        }

        public async Task<List<Product>> GetProducts()
        {
            var items = await cosmosContainer!.GetItemQueryIterator<Product>().ReadNextAsync();
            var products = items?.ToList();
            return products ?? new();
        }
    }
}
