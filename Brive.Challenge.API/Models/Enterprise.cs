using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Challenge.API.Models
{
    public class Enterprise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalVacants { get; set; }
        public DateTime CeateDate { get; set; }

    }
}
