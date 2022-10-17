using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        bool firstclick = false;
        int[] seq;
        public Form1()
        {
            InitializeComponent();
            seq = new int[50];
            seq[0] = seq[1] = 1;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (firstclick == false)
            {
                if (Convert.ToInt32(txtqnt.Text) >= 5)
                {
                    lstbNums.Items.Add(seq[0]);
                    lstbNums.Items.Add(seq[1]);
                    for (int i = 2; i < Convert.ToInt64(txtqnt.Text); i++)
                    {
                        seq[i] = seq[i - 1] + seq[i - 2];
                        lstbNums.Items.Add(seq[i]);
                    }
                    firstclick = true;
                    lblQnt.Text = "Ordem a apagar:";
                    btnIn.Text = "Apagar";
                }
                else
                    MessageBox.Show("O mínimo de números é 5.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtqnt.Text = "";
            }
            else
            {
                if (Convert.ToInt32(txtqnt.Text) > seq.Length)
                    MessageBox.Show("Posição não existente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("O número " + lstbNums.Items[Convert.ToInt32(txtqnt.Text) - 1] + " da ordem " + Convert.ToInt32(txtqnt.Text) + " foi apagado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstbNums.Items.RemoveAt(Convert.ToInt32(txtqnt.Text) - 1);
                }
                txtqnt.Text = "";
            }
        }

        private void txtqnt_TextChanged(object sender, EventArgs e)
        {
            if (txtqnt.Text.Length == 0)
                btnIn.Enabled = false;
            else
                btnIn.Enabled = true;
        }

        private void txtqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
    }
}
