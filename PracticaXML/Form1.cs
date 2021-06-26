using PracticaXML.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PracticaXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.asiento = new Asiento();
        }

        Asiento asiento;

        private void button1_Click(object sender, EventArgs e)
        {
            
            asiento.Banco = bancoTxt.Text;
            asiento.Beneficiario = beneficiarioTxt.Text;
            asiento.Caja = cajaTxt.Text;
            asiento.CentroCosto = centroCostoTxt.Text;
            asiento.Fecha = fechaDatePicker.Value;
            asiento.Identificador = (int)identificadorTxt.Value;
            asiento.Moneda = monedaTxt.Text;
            asiento.Monto = montoTxt.Value;
            asiento.Suplidor = suplidorTxt.Text;
            asiento.Tasa = tasaTxt.Value;
            
            SetDetalleToAsiento(asiento);

            using (XmlWriter writer = XmlWriter.Create("Asientos.xml"))
            {
                writer.WriteStartElement("asiento");
                
                writer.WriteElementString("banco", asiento.Banco);
                writer.WriteElementString("beneficiario", asiento.Beneficiario);
                writer.WriteElementString("caja", asiento.Caja);
                writer.WriteElementString("centroCosto", asiento.CentroCosto);
               
                writer.WriteStartElement("detalle");
                foreach (var detalle in asiento.Detalles)
                {
                    writer.WriteStartElement("element");
                    writer.WriteElementString("centro_costo", detalle.CentroCosto);
                    
                    writer.WriteStartElement("credito");
                    writer.WriteValue(detalle.Credito);
                    writer.WriteEndElement();

                    writer.WriteElementString("cuenta", detalle.Cuenta);

                    writer.WriteStartElement("debito");
                    writer.WriteValue(detalle.Debito);
                    writer.WriteEndElement();

                    writer.WriteElementString("proyecto", detalle.Proyecto);
                    writer.WriteElementString("subcentro_costo", detalle.SubcentroCosto);


                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteElementString("fecha", asiento.Fecha.ToString("dd/MM/yyyy"));

                writer.WriteStartElement("identificador");
                writer.WriteValue(asiento.Identificador);
                writer.WriteEndElement();

                writer.WriteElementString("moneda", asiento.Moneda);

                writer.WriteStartElement("monto");
                writer.WriteValue(asiento.Monto);
                writer.WriteEndElement();

                writer.WriteElementString("suplidor", asiento.Suplidor);

                writer.WriteStartElement("tasa");
                writer.WriteValue(asiento.Tasa);
                writer.WriteEndElement();


                writer.WriteEndElement();

                writer.Flush();
            }
        }

        private void SetDetalleToAsiento(Asiento asiento)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                asiento.Detalles.Add(new Detalle
                {
                    CentroCosto = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString(),
                    Credito = row.Cells[1].Value == null ? 0 : (decimal)row.Cells[1].Value,
                    Cuenta = row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString(),
                    Debito = row.Cells[3].Value == null ? 0 : (decimal)row.Cells[1].Value,
                    Proyecto = row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString(),
                    SubcentroCosto = row.Cells[5].Value == null ? "" : row.Cells[5].Value.ToString()
                });
            }            
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            asiento.Detalles.Add(new Detalle()
            {
                CentroCosto = detalleCentroCostoTxt.Text,
                Credito = decimal.Parse(detalleCreditoTxt.Text),
                Cuenta = detalleCuentaTxt.Text,
                Debito = detalleCreditoTxt.Text != "" ? 0 : decimal.Parse(detalleCreditoTxt.Text),
                Proyecto = detalleProyectoTxt.Text,
                SubcentroCosto = detalleSubCentroTxt.Text
            });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = asiento.Detalles;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
