using Ecommerce.Models.EntityModels;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace eShop.Database
{
    public class ApplicationDbContext
    {
        private readonly IMongoDatabase _database;
        private readonly MongoClient _dbClient;

        public ApplicationDbContext()
        {
            // Configure the MongoDB client and database here
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("eShop");
        }

        public IMongoCollection<Product> Products
        {
            get
            {
                return _database.GetCollection<Product>("Products");
            }
        }

        // Define other collections as needed, similar to the 'Products' collection
        // public IMongoCollection<Category> Categories
        // public IMongoCollection<ShoppingCartItem> ShoppingCartItems
    }
}
