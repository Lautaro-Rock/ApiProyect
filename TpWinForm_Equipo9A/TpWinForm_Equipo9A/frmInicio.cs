using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpWinForm_Equipo9A
{
    public partial class titlePrincipal : Form
    {
        public titlePrincipal()
        {
            InitializeComponent();
        }


        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            frmMenu ventanaMenu = new frmMenu();
            ventanaMenu.ShowDialog();
        }

    }
}
