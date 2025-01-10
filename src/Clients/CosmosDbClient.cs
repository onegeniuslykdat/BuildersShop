using Microsoft.Azure.Cosmos;

namespace BlazorAppWithCosmosDb.Clients
{
    public class CosmosDbClient : ICosmosDbClient
    {
        private readonly IConfiguration configuration;
        public CosmosDbClient(IConfiguration _configuration)
        {
                configuration = _configuration;
        }

        public CosmosClient GetClient()
        {
            string pk = configuration.GetValue<string>("CosmosDb:Pk");
            string docUrl = configuration.GetValue<string>("CosmosDb:DocUrl");
            return new CosmosClient(docUrl, pk);
        }
    }
}
