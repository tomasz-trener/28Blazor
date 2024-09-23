using Shop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.ProdcutService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<ServiceReponse<Product>> CreateProductServiceReponse(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<Product>> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<Product>> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            try
            {
                var reponse = await _httpClient.GetAsync("api/product");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ServiceReponse<List<Product>>> SearchProcutsAsync(string text, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<Product>> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
