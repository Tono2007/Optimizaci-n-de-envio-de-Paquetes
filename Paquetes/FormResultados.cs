﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Paquetes
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }
        private void btnGuardarResultados_Click(object sender, EventArgs e)
        {
            int index = 0;
            string ruta = System.AppDomain.CurrentDomain.BaseDirectory + @"Resultados\Resultados" + index + ".pdf";
            while(true)
            {
                if (File.Exists(ruta))
                {
                    index++;
                    ruta = System.AppDomain.CurrentDomain.BaseDirectory + @"Resultados\Resultados" + index + ".pdf";
                }
                else
                { break; }
            }
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream(@ruta, FileMode.Create));
            doc.AddTitle("Resultados-Paquetes que se deben de enviar");
            doc.AddCreator("Antonio Ayola Cortes");
            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos la imagen y le ajustamos el tamaño
            iTextSharp.text.Image imagen= iTextSharp.text.Image.GetInstance(Properties.Resources.logistica, System.Drawing.Imaging.ImageFormat.Png); 
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);
            doc.Add(imagen);
            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Resultados-Paquetes que se deben de enviar"));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph(Convert.ToString(DateTime.Today)));
            doc.Add(Chunk.NEWLINE);
            PdfPTable tblResultados = new PdfPTable(1);
            tblResultados.WidthPercentage = 100;
            PdfPCell clResultado = new PdfPCell(new Phrase("Nombre del paquete:", _standardFont));
            clResultado.BorderWidth = 0;
            clResultado.BorderWidthBottom = 0.75f;
            tblResultados.AddCell(clResultado);
            foreach (ListViewItem item in lbResultados.Items)
            {
                tblResultados.AddCell(item.Text);
            }
            doc.Add(tblResultados);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Peso Total: "+lbPesoTotal.Text));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Ganancia Total: "+lbGananciaTotal.Text));
            doc.Add(Chunk.NEWLINE);
            doc.Close();
            writer.Close();
            System.Diagnostics.Process.Start(ruta);


        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            lbResultados.Items.Clear();
            this.Close();
        }
    }
}
