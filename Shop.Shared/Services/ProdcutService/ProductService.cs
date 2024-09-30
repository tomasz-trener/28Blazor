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
        private readonly AppSettings _appSettings;

        public ProductService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<ServiceReponse<Product>> CreateProductService(Product newProduct)
        {
            var response = await _httpClient.PostAsJsonAsync(_appSettings.ProductEndpoint.CreateProduct, newProduct);
            var result = await response.Content.ReadFromJsonAsync<ServiceReponse<Product>>();
            return result;
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
                var reponse = await _httpClient.GetAsync(_appSettings.ProductEndpoint.GetProducts);
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

        public async Task<ServiceReponse<List<Product>>> SearchProdutsAsync(string text, int page, int pageSize)
        {
            try
            {
                string searchUrl = _appSettings.ProductEndpoint.SearchProduct;
                string query = string.IsNullOrEmpty(text) ? "" : $"{text}/";
                query += $"{page}/{pageSize}";

                var response = await _httpClient.GetAsync($"{searchUrl}/{query}");

                if (!response.IsSuccessStatusCode)
                {
                    return new ServiceReponse<List<Product>>()
                    {
                        Success = false,
                        Message = "Failed to load products"
                    };
                }

                var json = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<ServiceReponse<List<Product>>>(json);
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ServiceReponse<Product>> UpdateProductAsync(Product product)
        {

            try
            {
                var response = await _httpClient.PutAsJsonAsync(_appSettings.ProductEndpoint.UpdateProduct, product);
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
