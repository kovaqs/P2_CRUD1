using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEstudiantes.Core.Models;
using GestionEstudiantes.Core.Services;



namespace GestionEstudiantes.UI.Forms
{

    public partial class FrmEstudianteEditor : Form
    {
        private readonly EstudianteService estudianteService;

        private void ConfigurarFormulario()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");

            cbEstado.SelectedIndex = 0;

            dtFecha.MaxDate = DateTime.Today;
        }
        public FrmEstudianteEditor()
        {
            InitializeComponent();

            estudianteService = new EstudianteService();

            ConfigurarFormulario();
        }
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = new Estudiante
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Carnet = txtCarnet.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    FechaNacimiento = dtFecha.Value.Date,
                    Estado = cbEstado.Text,
                    NivelAcademico = txtNivel.Text.Trim()
                };

                estudianteService.Crear(estudiante);

                MessageBox.Show(
                    "Estudiante registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarFormulario();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Datos inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible registrar al estudiante.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCarnet.Clear();
            txtCorreo.Clear();
            txtNivel.Clear();

            cbEstado.SelectedIndex = 0;

            dtFecha.Value = DateTime.Today;

            txtNombre.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
        }
    }
}
