using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6at2
{
    public partial class Form1 : Form
    {
        Random randNum = new Random();
        int i, j, temp;
        int[] value = new int[8];
        int[] value2 = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    value[i] = randNum.Next(0, 10);
                    value2[i] = value[i];
                }

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (value2[i] > value2[j])
                        {
                            temp = value2[i];
                            value2[i] = value2[j];
                            value2[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (value[i] < value[j])
                        {
                            temp = value[i];
                            value[i] = value[j];
                            value[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    listBox1.Items.Add(value[i]);
                    listBox2.Items.Add(value2[i]);
                    listBox3.Items.Add(value[i] * value2[i]);
                }
            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }
        }
    }
}
