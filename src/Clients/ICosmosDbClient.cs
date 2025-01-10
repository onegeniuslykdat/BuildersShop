using Microsoft.Azure.Cosmos;

namespace BlazorAppWithCosmosDb.Clients
{
    public interface ICosmosDbClient
    {
        public CosmosClient GetClient();
    }
}