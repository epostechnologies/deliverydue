using DeliveryDude.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDude
{
    class Program
    {
        static void Main(string[] args)
        {
            createTask();
        }

        private async static void createTask()
        {
            var client = new RestClient("https://api.deliverydude.uk");
            var request = new RestRequest("/api/v1.0/task/create",Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "<API Key>");

            TaskDTO task = new TaskDTO();

            request.AddParameter("application/json", JsonConvert.SerializeObject(task), ParameterType.RequestBody);
            RestResponse<int> response = await client.ExecutePostAsync<int>(request);
            Console.WriteLine(response.Content);
        }
    }
}
