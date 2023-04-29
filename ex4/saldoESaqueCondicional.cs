using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class saldoESaqueCondicional : Form
    {
        public saldoESaqueCondicional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double saque = 110.0;

            if(saldo >= saque) 
            { 
                saldo = (saldo - saque);
                MessageBox.Show($"Saque de R${saque} realizado, o saldo atual da sua conta é R${saldo}!");
            }

            else
            {
                MessageBox.Show($"Voce não pode sacar R${saque} pois só tem R${saldo} na conta!");
            }
        }
    }
}
