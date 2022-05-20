using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConsultaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(null, null);
            }
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro ", "Atenção ", MessageBoxButtons.YesNo) == DialogResult.No)
                // if (MessageBox.Show("? ", " ", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);
            usuarioBLL.Excluir(id);
            usuarioBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso");
        }
    }
    
}
