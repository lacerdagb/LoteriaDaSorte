using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NumerosDaSorte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lista com todos os Labels
            Label[] labels = { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, label15, n16, n17, n18, n19, n20 };

            // Define o texto inicial de todos os labels como vazio
            foreach (Label lbl in labels)
            {
                lbl.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int quantidade = int.Parse(comboBox1.SelectedItem.ToString()); // Pega o valor selecionado

                List<int> numerosGerados = GerarNumerosAleatorios(quantidade, 1, 60);

                // Lista com todos os Labels do formulário
                Label[] labels = { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, label15, n16, n17, n18, n19, n20 };

                // Limpa todos os labels antes de gerar novos números
                foreach (Label lbl in labels)
                {
                    lbl.Text = "";
                }

                // Preenche apenas a quantidade necessária
                for (int i = 0; i < numerosGerados.Count; i++)
                {
                    labels[i].Text = numerosGerados[i].ToString();
                }
            }
            else
            {
                MessageBox.Show("Nenhum item foi selecionado!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;  // Remove a seleção do ComboBox
                                           // Lista com todos os Labels
            Label[] labels = { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, label15, n16, n17, n18, n19, n20 };

            // Limpa o texto de todos os labels
            foreach (Label lbl in labels)
            {
                lbl.Text = "";
            }


        }

        private void n1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private List<int> GerarNumerosAleatorios(int quantidade, int minimo, int maximo)
        {
            Random random = new Random();
            HashSet<int> numeros = new HashSet<int>();

            while (numeros.Count < quantidade)
            {
                int numero = random.Next(minimo, maximo + 1);
                numeros.Add(numero);  // HashSet não permite repetição
            }

            return numeros.ToList();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void n5_Click(object sender, EventArgs e)
        {

        }

        private void n18_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }

}

