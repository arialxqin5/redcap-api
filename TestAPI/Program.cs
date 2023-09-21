using System;
using Newtonsoft.Json;
using Redcap;
using Redcap.Models;

namespace RedcapApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redcap Api Demo Started!");
            // Use your own API Token here...
            var apiToken = "043CBADDEAA4172B1CD2DDBCA75124B9";
            var redcap_api = new RedcapApi("https://redcap.ualberta.ca/api/");

            Console.WriteLine("Exporting all records from project.");
            var result = redcap_api.ExportRecordsAsync(apiToken).Result;

            var data = JsonConvert.DeserializeObject(result);
            Console.WriteLine(data);
            Console.ReadLine();

        }
    }
}