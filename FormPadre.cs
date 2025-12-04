using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace AppModeloCapas
{
    public partial class FrmPadre : Form
    {
        public FrmPadre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Cerrar la Aplicacion?", "Autorizar ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            Application.Exit();
            

        }

        // Método genérico para abrir formularios hijos
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (formulario != null)
            {
                // Si el formulario ya está abierto, se trae al frente
                formulario.Activate();
            }
            else
            {
                // Si no está abierto, se crea una nueva instancia
                formulario = new T();
                formulario.MdiParent = this;
                formulario.Show();
            }
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroEstudiante>();
        }

        private void cursosAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroAsignatura>();
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmInscripcion>();
        }
    }
}
