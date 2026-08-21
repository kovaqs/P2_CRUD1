using GestionEstudiantes.Core.Data;
using GestionEstudiantes.Core.Models;
using GestionEstudiantes.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionEstudiantes.UI.Forms
{

    public partial class FrmEstudiantes : Form
    {
        private readonly EstudianteService estudianteService;
        private readonly BindingSource estudiantesBinding;
        private bool cargandoDatosEditor = false;

        private int estudianteSeleccionadoId = 0;
        public FrmEstudiantes()
        {
            InitializeComponent();

            estudianteService = new EstudianteService();
            estudiantesBinding = new BindingSource();

            ConfigurarGrid();
            ConfigurarFiltros();
            ConfigurarEstados();
            ConfigurarEventos();

            mExpansionPanel1.Visible = false;
            mExpansionPanel1.ValidationButtonEnable = false;
        }

       
        private void ConfigurarEstados()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");

            cbEstado.SelectedIndex = 0;
        }
        private void AplicarFiltros()
        {
            try
            {
                estudiantesBinding.DataSource =
                    estudianteService.Buscar(
                        txtBusqueda.Text.Trim(),
                        cbEstadoFiltro.Text
                    );

                dgvEstudiantes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible realizar la búsqueda.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ConfigurarEventos()
        {
            // ExpansionPanel
            mExpansionPanel1.SaveClick += mExpansionPanel1_SaveClick;
            mExpansionPanel1.CancelClick += mExpansionPanel1_CancelClick;

            // ContextMenu
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;

            // Cambios en formulario de edición
            txtNombre.TextChanged += DatosEditor_Modificados;
            txtApellidos.TextChanged += DatosEditor_Modificados;
            txtCarnet.TextChanged += DatosEditor_Modificados;
            txtCorreo.TextChanged += DatosEditor_Modificados;
            txtNivel.TextChanged += DatosEditor_Modificados;

            cbEstado.SelectedIndexChanged += DatosEditor_Modificados;

            dtFecha.ValueChanged += DatosEditor_Modificados;
        }

        private void mExpansionPanel1_SaveClick(object sender, EventArgs e)
        {
            if (estudianteSeleccionadoId == 0)
                return;

            if (!mExpansionPanel1.ValidationButtonEnable)
                return;

            try
            {
                Estudiante estudiante = new Estudiante
                {
                    Id = estudianteSeleccionadoId,

                    Nombre = txtNombre.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Carnet = txtCarnet.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),

                    FechaNacimiento = dtFecha.Value.Date,

                    Estado = cbEstado.Text,
                    NivelAcademico = txtNivel.Text.Trim()
                };

                estudianteService.Actualizar(estudiante);

                MessageBox.Show(
                    "Estudiante actualizado correctamente.",
                    "Actualización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CerrarEditor();

                CargarEstudiantes();
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
                    "No fue posible actualizar el estudiante.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DatosEditor_Modificados(object sender, EventArgs e)
        {
            if (cargandoDatosEditor)
                return;

            if (!mExpansionPanel1.Visible)
                return;

            mExpansionPanel1.ValidationButtonEnable = true;
        }
        private void ConfigurarFiltros()
        {
            cbEstadoFiltro.Items.Clear();

            cbEstadoFiltro.Items.Add("Todos");
            cbEstadoFiltro.Items.Add("Activo");
            cbEstadoFiltro.Items.Add("Inactivo");

            cbEstadoFiltro.SelectedIndex = 0;
        }
        private void ConfigurarGrid()
        {
            dgvEstudiantes.AutoGenerateColumns = true;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;

            dgvEstudiantes.DataSource = estudiantesBinding;
        }
        private void CargarEstudiantes()
        {
            try
            {
                estudiantesBinding.DataSource =
                    estudianteService.ObtenerTodos();

                ConfigurarColumnas();

                dgvEstudiantes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los estudiantes.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void RefrescarDatos()
        {
            if (!string.IsNullOrWhiteSpace(txtBusqueda.Text) ||
                cbEstadoFiltro.Text != "Todos")
            {
                AplicarFiltros();
            }
            else
            {
                CargarEstudiantes();
            }
        }
        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
        private Estudiante ObtenerEstudianteSeleccionado()
        {
            if (dgvEstudiantes.SelectedRows.Count == 0)
                return null;

            return dgvEstudiantes.SelectedRows[0]
                                  .DataBoundItem as Estudiante;
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cbEstadoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dgvEstudiantes_CellMouseDown(object sender,
    DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0)
                return;

            dgvEstudiantes.ClearSelection();

            dgvEstudiantes.Rows[e.RowIndex].Selected = true;
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = ObtenerEstudianteSeleccionado();

            if (estudiante == null)
                return;

            estudianteSeleccionadoId = estudiante.Id;

            cargandoDatosEditor = true;

            try
            {
                txtNombre.Text = estudiante.Nombre;
                txtApellidos.Text = estudiante.Apellidos;
                txtCarnet.Text = estudiante.Carnet;
                txtCorreo.Text = estudiante.Correo;
                txtNivel.Text = estudiante.NivelAcademico;

                cbEstado.SelectedItem = estudiante.Estado;

                dtFecha.Value = estudiante.FechaNacimiento;
            }
            finally
            {
                cargandoDatosEditor = false;
            }

            mExpansionPanel1.ValidationButtonEnable = false;

            mExpansionPanel1.Visible = true;
            mExpansionPanel1.Collapse = false;
        }

        private void mExpansionPanel1_CancelClick(object sender, EventArgs e)
        {
            CerrarEditor();
        }

        private void CerrarEditor()
        {
            cargandoDatosEditor = true;

            try
            {
                estudianteSeleccionadoId = 0;

                txtNombre.Clear();
                txtApellidos.Clear();
                txtCarnet.Clear();
                txtCorreo.Clear();
                txtNivel.Clear();

                cbEstado.SelectedIndex = 0;

                dtFecha.Value = DateTime.Today;

                mExpansionPanel1.ValidationButtonEnable = false;

                mExpansionPanel1.Collapse = true;
                mExpansionPanel1.Visible = false;

                dgvEstudiantes.ClearSelection();
            }
            finally
            {
                cargandoDatosEditor = false;
            }
        }


        private void ConfigurarColumnas()
        {
            if (dgvEstudiantes.Columns["Id"] != null)
                dgvEstudiantes.Columns["Id"].Visible = false;

            if (dgvEstudiantes.Columns["FechaNacimiento"] != null)
                dgvEstudiantes.Columns["FechaNacimiento"].Visible = false;

            if (dgvEstudiantes.Columns["FechaRegistro"] != null)
                dgvEstudiantes.Columns["FechaRegistro"].Visible = false;

            if (dgvEstudiantes.Columns["NombreCompleto"] != null)
                dgvEstudiantes.Columns["NombreCompleto"].Visible = false;

            if (dgvEstudiantes.Columns["NivelAcademico"] != null)
                dgvEstudiantes.Columns["NivelAcademico"].HeaderText = "Nivel Académico";

            if (dgvEstudiantes.Columns["Edad"] != null)
                dgvEstudiantes.Columns["Edad"].HeaderText = "Edad";
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = ObtenerEstudianteSeleccionado();

            if (estudiante == null)
                return;

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de eliminar a {estudiante.NombreCompleto}?\n\n" +
                "Esta acción eliminará permanentemente el registro.",
                "Eliminar estudiante",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                estudianteService.Eliminar(estudiante.Id);

                MessageBox.Show(
                    "Estudiante eliminado correctamente.",
                    "Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CerrarEditor();
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible eliminar al estudiante.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void contextMenuStrip1_Opening(
    object sender,
    System.ComponentModel.CancelEventArgs e)
        {
            Estudiante estudiante = ObtenerEstudianteSeleccionado();

            if (estudiante == null)
            {
                e.Cancel = true;
                return;
            }

            if (estudiante.Estado == "Activo")
            {
                estadoToolStripMenuItem.Text = "Desactivar estudiante";
            }
            else
            {
                estadoToolStripMenuItem.Text = "Reactivar estudiante";
            }
        }


        private void activarReactivarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = ObtenerEstudianteSeleccionado();

            if (estudiante == null)
                return;

            try
            {
                string nuevoEstado =
                    estudiante.Estado == "Activo"
                        ? "Inactivo"
                        : "Activo";

                estudianteService.CambiarEstado(
                    estudiante.Id,
                    nuevoEstado
                );

                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cambiar el estado.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }


}
