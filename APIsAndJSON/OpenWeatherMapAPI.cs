using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void WeatherApp()
        {

            var client = new HttpClient();

            Console.WriteLine("Please enter your API key");

            var apiKey = Console.ReadLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter your city name:");

                var cityName = Console.ReadLine();
                var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={apiKey}";

                var weatherResponse = client.GetStringAsync(weatherURL).Result;

                var formattedResponse = JObject.Parse(weatherResponse).GetValue("main").ToString();

                Console.WriteLine("----");

                Console.WriteLine($"{formattedResponse}");

                Console.WriteLine("Would you like to choose a different city? yes or no");
                var userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "no")
                {
                    Console.WriteLine("Goodbye then!");
                    break;
                }

            }
        }
    }
}
