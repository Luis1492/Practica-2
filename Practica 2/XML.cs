using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Practica_2
{
    public partial class XML : Form
    {
        public XML()
        {
            InitializeComponent();
        }
        public void Xml(string filename, string nombre, string edad, string telefono, string domicilio, string lugar_natal)
        {
            XmlWriterSettings configuracion = new XmlWriterSettings();
            configuracion.Indent = true;
            configuracion.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create(filename, configuracion);
            writer.WriteStartDocument();
            writer.WriteStartElement("Agenda");
            writer.WriteStartElement("Nombre");
            writer.WriteString(nombre);
            writer.WriteEndElement();

            writer.WriteStartElement("Telefono");
            writer.WriteString(telefono);
            writer.WriteEndElement();
            writer.WriteStartElement("Edad");
            writer.WriteString(edad);
            writer.WriteEndElement();
            writer.WriteStartElement("Domicilio");
            writer.WriteString(domicilio);
            writer.WriteEndElement();
            writer.WriteStartElement("Lugar_de_Nacimeinto");
            writer.WriteString(lugar_natal);
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.Close();

        }

        private void cmdcrear_Click(object sender, EventArgs e)
        {
            sfdguardar.Filter = ".xml|*.xml";
            sfdguardar.ShowDialog(); 
            Xml(sfdguardar.FileName, txtnombre.Text, txtedad.Text, txttelefono.Text, txtdomicilio.Text, txtnacimiento.Text);
            
            txtnombre.Clear();
            txtedad.Clear();
            txttelefono.Clear();
            txtdomicilio.Clear();
            txtnacimiento.Clear();
        
        }
        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XML_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
