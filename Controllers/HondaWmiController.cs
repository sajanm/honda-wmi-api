using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using HondaWmiApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HondaWmiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HondaWmiController : ControllerBase
    {
        private readonly ILogger<HondaWmiController> _logger;

        public HondaWmiController(ILogger<HondaWmiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<HondaWmiModel> Get()
        {
            var jsonString = System.IO.File.ReadAllText("Data/honda_wmi.json");
            var hondaWmiList = JsonSerializer.Deserialize<List<HondaWmiModel>>(jsonString);
            return hondaWmiList;
        }
    }
}