using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Shop.Shared.Configuration;
using Shop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Shared.Services.ProdcutService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettngs;

        public ProductService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettngs = appSettings.Value;
        }

        public Task<ServiceReponse<Product>> CreateProductServiceReponse(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceReponse<bool>> DeleteProductAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceReponse<bool>>();
            return result;
        }

        public async Task<ServiceReponse<Product>> GetProductAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceReponse<Product>>();
            return result;
        }

        public async Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            try
            {
                var reponse = await _httpClient.GetAsync(_appSettngs.ProductEndpoint.GetProducts);
                reponse.EnsureSuccessStatusCode();
                var json = await reponse.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<ServiceReponse<List<Product>>>(json);
                return products;
            }
            catch (HttpRequestException ex)
            {
                return new ServiceReponse<List<Product>>()
                {
                    Success = false,
                    Message = "Failed to load products:" + ex.Message
                };
            }
            catch (Exception ex)
            {
                return new ServiceReponse<List<Product>>()
                {
                    Success = false,
                    Message = "Failed to load products:" + ex.Message
                };  
            }
        }

        public Task<ServiceReponse<List<Product>>> SearchProcutsAsync(string text, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceReponse<Product>> UpdateProductAsync(Product product)
        {

            try
            {
                var response = await _httpClient.PutAsJsonAsync(_appSettngs.ProductEndpoint.UpdateProduct, product);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var updatedProduct = JsonConvert.DeserializeObject<ServiceReponse<Product>>(json);
                return updatedProduct;
            }
            catch (HttpRequestException ex)
            {
                return new ServiceReponse<Product>()
                {
                    Success = false,
                    Message = "Failed to load products:" + ex.Message
                };
            }
            catch (Exception ex)
            {
                return new ServiceReponse<Product>()
                {
                    Success = false,
                    Message = "Failed to load products:" + ex.Message
                };
            }
        }
    }
}
