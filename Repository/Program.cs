using Repository.Models;
using Repository.Repositories;

Product product = new Product() { Id = 1 };

ProductRepository productRepository = new ProductRepository();
var products = productRepository.Products();
productRepository.AddProduct(product);
var existingProduct = productRepository.GetProductById(product.Id);
productRepository.UpdateProduct(product);
productRepository.DeleteProduct(product);
productRepository.DeleteProductById(product.Id);


User user = new User() { Id = 1 };

UserRepository userRepository = new UserRepository();
var user = userRepository
