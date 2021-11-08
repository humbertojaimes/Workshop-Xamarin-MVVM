using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WorkshopForms.Models;

namespace WorkshopForms.Services
{
    public class BranchApiClient
    {

        static HttpClient httpClient;

        public BranchApiClient()
        {
            httpClient = new HttpClient();
            //Escribe la url del API a consumir
            httpClient.BaseAddress = new Uri("url del api");
        }


        public async Task<IEnumerable<Branch>> GetBranches()
        {
            var json = await httpClient.GetStringAsync("/branches");
            var branches = JsonConvert.DeserializeObject<IEnumerable<Branch>>(json);
            return branches;
        }

    }
}
