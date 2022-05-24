using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Certeza : Form
    {
        public Certeza()
        {
            InitializeComponent();
        }

        private void btnsim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
