using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_YairGonzalez_01_26_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            MessageBox.Show("Hola bievenido: "+nombre, "Mensaje de Inicio", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


    }
}
