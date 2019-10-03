using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace ValidacaoEtiquetas
{
    public partial class Contador : Form
    {
        public Contador()
        {
            InitializeComponent();
            conexao.abrirConexao();
        }
        int contador = 0;
        Connection conexao = new Connection();
        

        private void button1_Click(object sender, EventArgs e)
        {
             
            
            
            

            if (leituraCodigoBarras.Text.Length == 32)
            {
                int produto = int.Parse(leituraCodigoBarras.Text.Substring(0, 10));
                int etiqueta = int.Parse(leituraCodigoBarras.Text.Substring(10));
                conexao.recebeEtiqueta(produto, etiqueta);
                lista.Items.Add(leituraCodigoBarras.Text);
                contador = int.Parse(label2.Text) + 1;
                label2.Text = contador.ToString();
            }
            else
            {
                MessageBox.Show("Verificar código Bipado Menor do que 32");
            }

            
            
            leituraCodigoBarras.Clear();
            leituraCodigoBarras.Focus();
            leituraCodigoBarras.Select();

        }

        private void leituraCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 )
            {
                button1_Click(LerEtiqueta, new EventArgs());
                
            }
        }

        private void Contador_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexao.fechaConexao();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "0";
            lista.Items.Clear();
            leituraCodigoBarras.Focus();
            leituraCodigoBarras.Select();
        }
    }
}
