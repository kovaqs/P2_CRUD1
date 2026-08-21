using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEstudiantes.UI.Forms
{
    public partial class FrmPrincipal : Form
    {
        private Form formularioActivo;

        private readonly FrmEstudiantes frmEstudiantes;
        private readonly FrmEstudianteEditor frmEstudianteEditor;
        public FrmPrincipal()
        {
            InitializeComponent();

            frmEstudiantes = new FrmEstudiantes();
            frmEstudianteEditor = new FrmEstudianteEditor();
        }
        private void MostrarFormulario(Form formulario)
        {
            if (formularioActivo == formulario)
                return;

            pnMain.SuspendLayout();

            try
            {
                if (formularioActivo != null)
                    formularioActivo.Hide();

                formularioActivo = formulario;

                if (!pnMain.Controls.Contains(formulario))
                {
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;

                    pnMain.Controls.Add(formulario);
                }

                formulario.BringToFront();
                formulario.Show();
            }
            finally
            {
                pnMain.ResumeLayout();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool maximizado = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!maximizado)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizado = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizado = false;

            }
        }

        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiantes.RefrescarDatos();

            MostrarFormulario(frmEstudiantes);
        }

        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmEstudianteEditor);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmEstudiantes.RefrescarDatos();
            MostrarFormulario(frmEstudiantes);
        }
    }
}
