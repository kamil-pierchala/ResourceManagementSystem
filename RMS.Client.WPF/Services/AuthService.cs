using System.Net.Http;
using System.Net.Http.Json;

namespace RMS.Client.WPF.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri("http://localhost:5000/api/");
        }

        public async Task<string?> LoginAsync(string username, string password)
        {
            var loginData = new { Username = username, PasswordHash = password };

            var response = await _httpClient.PostAsJsonAsync("Auth/login", loginData);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
                return result?.Token;
            }

            return null;
        }
    }

    public class LoginResponse
    {
        public string Token { get; set; } = string.Empty;
    }
}