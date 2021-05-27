using System.Collections.Generic;
using HondaWmiApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HondaWmiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HondaWmiController : ControllerBase
    {
        private readonly IHondaWmiService _hondaWmiService;
        public HondaWmiController(IHondaWmiService hondaWmiService)
        {
            _hondaWmiService = hondaWmiService;
        }

        [HttpGet]
        public IEnumerable<HondaWmiModel> Get()
        {
            var hondaWmiList = _hondaWmiService.GetList();
            return hondaWmiList;
        }
    }
}