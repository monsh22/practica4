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

namespace practica4
{
    public partial class Form1 : Form
    {
        private readonly string filePath = "registro.txt";
        public Form1()
        {
            InitializeComponent();

            butGUARDAR.Click += new EventHandler(btnGuardar_Click);
            butGUARDAR.Click += new EventHandler(btnGuardar_Click);
            CANCELAR.Click += new EventHandler(btnFinalizar_Click);

        }


        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(NOM.Text) ||
                string.IsNullOrWhiteSpace(APE.Text) ||
                string.IsNullOrWhiteSpace(TELE.Text) ||
                string.IsNullOrWhiteSpace(ESTA.Text) ||
                string.IsNullOrWhiteSpace(EDAD.Text) ||
                (!GENER.Checked && !GEN.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                GuardarDatos();
                MessageBox.Show("Datos guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GuardarDatos()
        {
            try
            {
                string genero = GENER.Checked ? "Masculino" : "Femenino";
                string datos = $"Nombre: {NOM.Text}\r\n" +
                             $"Apellidos: {APE.Text}\r\n" +
                             $"Teléfono: {TELE.Text}\r\n" +
                             $"Estatura: {ESTA.Text}\r\n" +
                             $"Edad: {EDAD.Text}\r\n" +
                             $"Género: {genero}\r\n" +
                             $"Fecha de registro: {DateTime.Now}\r\n" +
                             "----------------------------------------\r\n";

                File.AppendAllText(filePath, datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            NOM.Clear();
            APE.Clear();
            TELE.Clear();
            ESTA.Clear();
            EDAD.Clear();
            GENER.Checked = false;
            GEN.Checked = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                GuardarDatos();
                MessageBox.Show("Registro finalizado. Los datos han sido guardados.", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
