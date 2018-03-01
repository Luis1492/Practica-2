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

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Boolean BMP(FileStream archivo)
        {
            char bit_primario;
            char bit_secundario;
            BinaryReader bin = new BinaryReader(archivo);
            bin.BaseStream.Seek(0, SeekOrigin.Begin);
            bit_primario = Convert.ToChar(bin.ReadByte());
            bin.BaseStream.Seek(1, SeekOrigin.Begin);
            bit_secundario = Convert.ToChar(bin.ReadByte());
            if(bit_primario=='B' && bit_secundario == 'M')
            {
                return true;
            }
            else
            {
                bin.Close();
                archivo.Close();
                txtimagen.Text += "No es un archivo .BMP";
                return false;
            }
        }
        private int tamaño (FileStream archivo_bytes )
        {
            int bytes;
            BinaryReader real = new BinaryReader(archivo_bytes);
            real.BaseStream.Seek(2, SeekOrigin.Begin);
            bytes = real.ReadInt32();
            txtimagen.Text += "Tamaño en Bytes= " + bytes + " B";
            return bytes;
        }
        private int alto_ancho (FileStream img)
        {
            int ancho;
            int alto;
            BinaryReader pr = new BinaryReader(img);
            pr.BaseStream.Seek(18, SeekOrigin.Begin);
            ancho = pr.ReadInt32();
            txtimagen.Text += Environment.NewLine + "Ancho de imagen= " + ancho + " An";
            alto = pr.ReadInt32();
            txtimagen.Text += Environment.NewLine + "Alto de imagen= " + alto + " Al" ;
            return ancho + alto;
        }
        private int Pixeles_por_bits(FileStream pix)
        {
            int bit_px;
            BinaryReader px = new BinaryReader(pix);
            px.BaseStream.Seek(28, SeekOrigin.Begin);
            bit_px = px.ReadInt16();
            txtimagen.Text += Environment.NewLine + "Pixeles por bit= " + bit_px + " px";
            return bit_px;
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            opfabrir.ShowDialog();
            FileStream img = new FileStream(opfabrir.FileName, FileMode.Open);
            if (BMP(img) == true)
            {
                tamaño(img);
                alto_ancho(img);
                Pixeles_por_bits(img);
            }
            img.Close();

        }

        private void cmdxml_Click(object sender, EventArgs e)
        {
            XML formula = new XML();
            this.Hide();
            formula.ShowDialog();
        }
    }
}
