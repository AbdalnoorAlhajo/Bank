using System;
using System.Data;
using System.Net.Http.Json;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExchangeRate_Online_API
{
    /// <summary>
    /// Data Transfer Object (DTO) for currency rates information.
    /// </summary>
    public class clsCurrencyDTO
    {
        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public int time_last_update_unix { get; set; }
        public string time_last_update_utc { get; set; }
        public int time_next_update_unix { get; set; }
        public string time_next_update_utc { get; set; }
        public string base_code { get; set; }
        public Dictionary<string, double> conversion_rates { get; set; }
    }

    /// <summary>
    /// Data Transfer Object (DTO) for currency pair conversion information.
    /// </summary>
    public class clsPairConversionDTO
    {
        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public int time_last_update_unix { get; set; }
        public string time_last_update_utc { get; set; }
        public int time_next_update_unix { get; set; }
        public string time_next_update_utc { get; set; }
        public string base_code { get; set; }
        public string target_code { get; set; }
        public double conversion_rate { get; set; }
    }


    /// <summary>
    /// This class handles online API interactions with the ExchangeRate API.
    /// </summary>
    public class clsRates
    {
        // Static HttpClient instance for making API requests.
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Static constructor to initialize the base address for the HttpClient.
        /// </summary>
        static clsRates()
        {
            // Base address of the API endpoint for ExchangeRate_OnlineAPI operations.
            _httpClient.BaseAddress = new Uri("https://v6.exchangerate-api.com/v6/7506f79b554ae28e66a4c9d675/");
        }

        /// <summary>
        /// Imports the latest currency rates based on USD as the base currency.
        /// </summary>
        /// <returns>A <see cref="clsCurrencyDTO"/> containing the latest currency rates, or null if an error occurs.</returns>
        public async static Task<clsCurrencyDTO> Import()
        {
            try
            {
                var response = await _httpClient.GetAsync($"latest/USD");
                if(response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsCurrencyDTO>();
                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


        /// <summary>
        /// Imports the conversion rate between two specified currencies.
        /// </summary>
        /// <param name="base_code">The base currency code (e.g., "USD").</param>
        /// <param name="target_code">The target currency code (e.g., "EUR").</param>
        /// <returns>A <see cref="clsPairConversionDTO"/> containing the conversion rate, or null if an error occurs.</returns>
        public async static Task<clsPairConversionDTO> Import(string base_code, string target_code)
        {
            try
            {
                var response = await _httpClient.GetAsync($"pair/{base_code}/{target_code}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsPairConversionDTO>();
                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
