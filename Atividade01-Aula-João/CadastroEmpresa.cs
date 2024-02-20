using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01_Aula_João
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_fantasia_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fantasia = (tx_fantasia.Text);
            string razsocial = (tx_razsocial.Text);
            string cnpj = (mb_cnpj.Text);
            string sitcad = (cb_situacao.Text);
            string regime = ("");
            string datainicio = (tx_dtinicio.Text);
            string telefone = (tx_tel.Text);
            string capital = (tx_capsocial.Text);
            string endereco = (tx_endereco.Text);
            string tipo = ("");
            string porte = ("");
            string natjuridica = (comboBox1.Text);
            string nome = (tx_nomeprop.Text);
            string cpf = (tx_cpfprop.Text);

            if (radioButton1.Checked == true)
            {
                regime = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                sitcad = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                porte = radioButton3.Text;
            }

            string txt = @"C:\Users\2022102020064\Desktop\AULA01\AULA01.txt";
            using StreamWriter sw = new StreamWriter(txt);
            {
                sw.WriteLine(MessageBox.Show($"CNPJ = {cnpj}\n" + $"Razão Social:{razsocial}\n" + $"Nome fantasia:{fantasia}\n" + $"Situação:{sitcad}\n" +
                $"Regime Tributário{regime}\n" + $"Data de início:{datainicio}\n" + $"Telefone:{telefone}\n" + $"Capital:{capital}\n" +
                $"Endereço:{endereco}\n" + $"Tipo:{tipo}\n" + $"Porte da Empresa:{porte}\n" + $"Jurídica:{natjuridica}\n" +
                $"Proprietário:{nome}\n" + $"Cpf Proprietário:{cpf}\n"));

            }

        }
    }
}
