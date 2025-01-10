namespace BlazorAppWithCosmosDb.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSupplier { get; set; }
        public string ProductUrl { get; set; }
    }
}
