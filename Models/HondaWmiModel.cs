using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HondaWmiApi.Models
{
    public class HondaWmiModel
    {
        public string Country {get; set;}
        public string CreatedOn {get; set;}
        public string DateAvailableToPublic {get; set;}
        public int Id {get; set;}
        public string Name {get; set;}
        public string UpdatedOn {get; set;}
        public string VehicleType {get; set;}
        public string WMI {get; set;}
    }
}