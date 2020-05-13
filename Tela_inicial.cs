using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicação_Desktop
{
    public partial class Tela_inicial : Form
    {
        public Tela_inicial()
        {
            InitializeComponent();
        }

        private void testeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iptvDataSet);

        }

        private void Tela_inicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'iptvDataSet.teste'. Você pode movê-la ou removê-la conforme necessário.
            this.testeTableAdapter.Fill(this.iptvDataSet.teste);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
