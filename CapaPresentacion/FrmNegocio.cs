﻿using CapaEntidad;
using CapaNegocia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmNegocio : Form
    {
        public FrmNegocio()
        {
            InitializeComponent();
        }
  
        
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void FrmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[ ] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                picklogo.Image = ByteToImage(byteimage);

            Negocio datos = new CN_Negocio().ObtenerDatos();
            txtnombre.Text = datos.Nombre;
            txtruc.Text = datos.RUC;
            txtdireccion.Text = datos.Direccion;
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //    string imagenpPath = oOpenFileDialog.FileName;
                //    Image image = Image.FromFile(imagenpPath);
                //    picklogo.Image = image;
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                 bool respuesta = new CN_Negocio().ActualizaLogo(byteimage, out mensaje);

            if (respuesta)
                picklogo.Image = ByteToImage(byteimage);

            else
                MessageBox.Show(mensaje, "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void guardabtn_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty ;
            Negocio obj = new Negocio()
            {
                Nombre = txtnombre.Text,
                RUC = txtruc.Text,
                Direccion = txtdireccion.Text,
            };
            bool respuesta = new CN_Negocio().GuardaData(obj, out mensaje);
            if (respuesta)
                MessageBox.Show("Los cambios han sido guardados exitosamente", "Mensaje",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Mensaje",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
