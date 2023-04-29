using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class saldoESaque : Form
    {
        public saldoESaque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double saque = 10.0;
            saldo = (saldo - saque); // faz a variável armazenar o valor de saldo pós
                                     // saque.
            
            MessageBox.Show("O saldo atual da conta é: R$"+ saldo); 
        }
    }
}
