using Design_Patterns.Structural.Repository.Models;
using System.Net;

namespace Design_Patterns.Structural.Repository.Repositories
{
    public class ProductRepository
    {
        public IEnumerable<Product> Products()
        {
            return new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Console.WriteLine("Adding new product.");
        }

        public Product GetProductById(int id)
        {
            Console.WriteLine("Returing product with id: " + id);
            return new Product();
        }

        public void UpdateProduct(Product product)
        {
            Console.WriteLine("Updating product.");
        }

        public void DeleteProduct(Product product)
        {
            Console.WriteLine("Adding new product.");
        }

        public void DeleteProductById(int id)
        {
            Console.WriteLine("Deleting product with id: " + id);
        }
    }
}
