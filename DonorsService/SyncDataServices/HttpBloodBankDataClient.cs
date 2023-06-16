using Donors.API.Models.Dtos;
using System.Text;
using System.Text.Json;

namespace Donors.API.SyncDataServices
{
    public class HttpBloodBankDataClient : IBloodBankDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public HttpBloodBankDataClient(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        public async Task BloodRequest(BloodReadDto blood)
        {
            var httpContent = new StringContent(JsonSerializer.Serialize(blood), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_config["BloodBankService"], httpContent);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("-> Sync POST to BloodBank was OK!");
            }
            else { Console.WriteLine("-> Sync POST to BloodBank was NOT ok!"); }
        }
    }
}
