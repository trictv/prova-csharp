using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado =0,km,distancia =0;
            string mostracomofez = "";


           

            if (!double.TryParse(txtDistancia.Text,out km))
            {
                MessageBox.Show("apenas numeros");
                txtDistancia.Text = "";
                return;
            }
            if (chkViagemnoturna.Checked)
            {
                resultado += 0.25 * km;
                mostracomofez += "\n adicional noturno: R$ " + (0.25 * km);
            }
            if (chkHospedagem.Checked && km > 300)
            {
                resultado += 200;
                mostracomofez += "\n hospedagem: R$ 200";
            }
           
            if (radioButton1.Checked)
            {
                for(int i = 0;i <= km; i++)
                {
                    resultado += 1.5;
                    distancia += 1.5;
                }
                mostracomofez += "\n distância percorrida: R$ " + distancia;
            }
            if (radioButton2.Checked)
            {
                for (int i = 0; i <= km; i++)
                {
                    resultado += 2.50;
                    distancia += 2.50;
                }
                mostracomofez += "\n distância percorrida: R$ " + distancia;
            }
            if (radioButton3.Checked)
            {
                
                for (int i = 0; i <= km; i++)
                {
                    resultado += 3.50;
                    distancia += 3.50;
                }
                mostracomofez += "\n distância percorrida: R$ " + distancia;
            }
            mostracomofez += "\n TOTAL: R$ " + resultado;
            MessageBox.Show(mostracomofez);
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double km;
            if(double.TryParse(txtDistancia.Text,out km))
            {

            }
            if(radioButton3.Checked && km > 500)
            {
                chkViagemnoturna.Visible = true;
            }
            
            if(radioButton3.Checked == false)
            {
                chkViagemnoturna.Visible = false;
            }
            
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            double km;
            if (double.TryParse(txtDistancia.Text, out km))
            {

            }
            if (km > 500 && radioButton3.Checked)
            {
                chkViagemnoturna.Visible = true;
            }
            if(km < 500 && radioButton3.Checked)
            {
                chkViagemnoturna.Visible = false;
                chkViagemnoturna.Checked = false;
            }

            if (radioButton3.Checked == false)
            {
                chkViagemnoturna.Visible = false;
                chkViagemnoturna.Checked = false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Apenas letras!");
                e.Handled = true;


            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //double km;
            //if (!double.TryParse(txtDistancia.Text, out km))
            //{
            //    MessageBox.Show("APENAS NUMEROS!");
            //    txtDistancia.Text = "";
            //    //return;
            //}
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chkHospedagem.Checked = chkViagemnoturna.Checked = false;
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
            txtDistancia.Text = txtNome.Text = "";
        }

        private void chkHospedagem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
