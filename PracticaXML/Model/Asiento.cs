using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaXML.Model
{
    public class Asiento
    {
        public Asiento()
        {
            Detalles = new List<Detalle>();
        }
        public string Banco { get; set; }
        public string Beneficiario { get; set; }
        public string Caja { get; set; }
        public string CentroCosto { get; set; }
        public List<Detalle> Detalles { get; set; }
        public DateTime Fecha { get; set; }
        public int Identificador { get; set; }
        public string Moneda { get; set; }
        public decimal Monto { get; set; }
        public string Suplidor { get; set; }
        public decimal Tasa { get; set; }
    }
}
