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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco1DataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.banco1DataSet.usuarios);

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Certeza certeza = new Certeza();
            certeza.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.banco1DataSet.usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
