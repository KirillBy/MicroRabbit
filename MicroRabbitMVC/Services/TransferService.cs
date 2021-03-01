using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MicroRabbitMVC.Models.DTO;
using Newtonsoft.Json;

namespace MicroRabbitMVC.Services
{
    public class TransferService:ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task Transfer(TransferDTO transferDto)
        {
            var uri = "http://localhost:5000/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
                System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PutAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}