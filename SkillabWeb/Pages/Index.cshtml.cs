using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SkillabWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace SkillabWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Employee> Employees { get; set; }

        public async Task OnGetAsync()
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };


            var httpClient = new HttpClient(handler);

            //var requestUriString = "https://10.4.0.117:32774/Employee/GetAll";

            var requestUriString = "http://api/Employee/GetEmployees";

            var requestUri = new Uri(requestUriString);

            var response = await httpClient.GetAsync(requestUri);
            var employees = await response.Content.ReadAsStringAsync();

            Employees = JsonConvert.DeserializeObject<List<Employee>>(employees);
            
        }
    }
}
