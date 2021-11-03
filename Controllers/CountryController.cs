using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AspNetCore.Swagger.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        List<Countries> _countries;

        public CountryController()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"restcountries.json");
            _countries = JsonConvert.DeserializeObject<List<Countries>>(json);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_countries);
        }
    }
}
