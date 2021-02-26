using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Hangfire.Services
{
    public static class RunAsyncAPI
    {
        public static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://newsapi.org/v2/top-headlines?country=br&apiKey=703f531167264730aa29389e545ae9b2");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                var content = response.Content.ReadAsStringAsync().Result;
                var convertedToJson = JsonConvert.DeserializeObject(content);

                //Salva em arquivo .json no diretório especificado na variavel path
                //caso o diretorio nao exista será criado               
                var data = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                var path = $"C:\\dev\\hangfire\\{data}.json";
                System.IO.Directory.CreateDirectory("C:\\dev\\hangfire");

                using (var file = new StreamWriter(path))
                {
                    file.Write(convertedToJson);
                }
            }
        }
    }

}

