using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class ADMINISTRACION : MetroForm
    {
        public ADMINISTRACION()
        {
            InitializeComponent();
        }

        private void ADMINISTRACION_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoCombo_Click(object sender, EventArgs e)
        {
            NuevoCombo frm = new NuevoCombo();
            frm.Show();
        }

        private void ma_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

        }
    }
}
