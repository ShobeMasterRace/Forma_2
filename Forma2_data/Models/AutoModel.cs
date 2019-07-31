using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forma2_Data.Models
{
    public class AutoModel : IdModel
    {
        public string Proizvodac { get; set; }
        public string MarkaVozila { get; set; }
        public string Godiste { get; set; }

    }
}
