using static System.Net.WebRequestMethods;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {RonVSKanyeAPI.KanyeQuote()}");
                Console.WriteLine($"Ron: {RonVSKanyeAPI.RonQuote()}");
            }

        }
    }
}
