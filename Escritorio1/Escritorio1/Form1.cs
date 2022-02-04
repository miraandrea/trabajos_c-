using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio1
{
    public partial class Form1 : Form
    {
        CAprendiz aprendiz = new CAprendiz();

        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            aprendiz.nombre = tbNombre.Text;
            aprendiz.apellido = tbApellido.Text;
            aprendiz.edad = Convert.ToInt32(tbEdad.Text);

            tbApellido.Text = "";
            tbNombre.Text = "";
            tbEdad.Text = "";
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            string restultado = aprendiz.nombre + " " + aprendiz.apellido + " " + aprendiz.edad;
            MessageBox.Show(restultado);

            MessageBox.Show(aprendiz.mostrarDatos());
        }
    }
}
