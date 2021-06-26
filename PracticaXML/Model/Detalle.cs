using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaXML.Model
{
    public class Detalle
    {
        public string CentroCosto { get; set; }
        public decimal Credito { get; set; }
        public string Cuenta { get; set; }
        public decimal Debito { get; set; }
        public string Proyecto { get; set; }
        public string SubcentroCosto { get; set; }
    }
}
