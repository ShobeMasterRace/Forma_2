using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forma2_Data.Models
{
    public class MotorModel : IdModel
    {
        public string Proizvodac { get; set; }
        public string MarkaMotora { get; set; }
        public string Godiste { get; set; }
        public string potrošnja { get; set; }

    }
}
