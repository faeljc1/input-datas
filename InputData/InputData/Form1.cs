using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputData
{
    public partial class InputDatas : Form
    {
        public InputDatas()
        {
            InitializeComponent();
        }

        private void InputDatas_Load(object sender, EventArgs e)
        {
            this.txtFabricacao.Focus();
        }

        private void txtFabricacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCamposData(txtFabricacao, e);
        }

        private void txtVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCamposData(txtVencimento, e);
        }

        private void validaCamposData(TextBox txt, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (Char)Keys.Back))
            {
                e.Handled = true;

            }
            else if ((txt.Text.Length == 2 || txt.Text.Length == 5) && char.IsNumber(e.KeyChar))
            {

                txt.Text = txt.Text + "/";
                txt.Select(txt.Text.Length, 0);
            }
            else if (txt.Text.Length == 10 && (e.KeyChar != (Char)Keys.Back) && (e.KeyChar != (Char)Keys.Delete) && (e.KeyChar != (Char)Keys.Return))
            {
                e.Handled = true;
            }
        }
    }
}
