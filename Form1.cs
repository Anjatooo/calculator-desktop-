using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        bool signChanged = false;
        public List<int> plus_ = new List<int>();
        public string a = "0";

        void FitTextToTextBox()
        {
            using (Graphics g = textBox1.CreateGraphics())
            {
                float font = textBox1.Font.Size;

                Font currentFont = textBox1.Font;
                SizeF size = g.MeasureString(textBox1.Text, textBox1.Font);
                while (size.Width > textBox1.ClientSize.Width && font > 20)
                {
                    font -= 0.5f;
                    currentFont = new Font(textBox1.Font.FontFamily, font);
                    size = g.MeasureString(textBox1.Text, currentFont);
                }

                textBox1.Font = currentFont;

            }
        }

        void Var(ref bool signChanged)

        {


            if (textBox1.Text.Length != 0)
            {

                if (textBox1.Text.Length == 1)
                {

                    if (textBox1.Text[0] == '(')
                    {

                        textBox1.Text += '-';
                        signChanged = true;
                    }
                    else
                    {

                        textBox1.Text = textBox1.Text.Insert(0, "-");
                        signChanged = true;

                    }

                }

                if (!signChanged)
                {

                    for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                    {


                        if (textBox1.Text[i] == '(')
                        {

                            textBox1.Text = textBox1.Text.Insert(i + 1, "-");
                            signChanged = true;

                            break;
                        }
                        else if ("+-*/%".Contains(textBox1.Text[i]))
                        {

                            textBox1.Text = textBox1.Text.Insert(i + 1, "(-");
                            signChanged = true;
                            break;
                        }



                    }
                }
                if (!signChanged)
                {

                    textBox1.Text = textBox1.Text.Insert(0, "-");
                    signChanged = true;

                }



            }
            else
            {

                textBox1.Text += "(-";
                signChanged = true;
            }

        }
        void Pup()
        {
            if (textBox1.Text == a)
            {
                textBox1.Clear();
            }

        }
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Pup();
            Font av = new Font("Microsoft Sans Serif", 35);
            textBox1.Font = av;
            textBox1.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Pup();
            sas();

            textBox1.Text += button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pup();
            sas();
            textBox1.Text += button4.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Pup();
            sas();
            textBox1.Text += button13.Text;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            sas();
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            FitTextToTextBox();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sas();
            Pup();

            textBox1.Text += button15.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sas();
            Pup();
            var a = new Dictionary<char, char>()
            {
                {'(', ')'}
            };
            int Open = textBox1.Text.Count(a.ContainsKey);
            int Close = textBox1.Text.Count(a.ContainsValue);
            if (Open > Close)
            {
                textBox1.Text += ")";
            }
            else
            {
                textBox1.Text += "(";
            }

            //textBox1.Text += button2.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sas();
            Pup();
            textBox1.Text += button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sas();
            Pup();
            textBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sas();
            Pup();
            textBox1.Text += button11.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sas();
            Pup();
            textBox1.Text += button5.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sas();
            Pup();

            textBox1.Text += button12.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sas();
            Pup();
            textBox1.Text += button14.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {


            sas();
            Pup();
            textBox1.Text += button6.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            sas();
            Pup();

            textBox1.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sas();
            Pup();

            textBox1.Text += button17.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sas();
            Pup();
            textBox1.Text += Suma.Text;


            /*int plus = Int32.Parse(textBox1.Text);
            plus_.Add(plus);
            textBox1.Clear();
            int a = plus_.Sum();
            plus_.Clear();
            plus_.Add(a);*/

        }

        private void button18_Click(object sender, EventArgs e)
        {

            sas();
            Pup();


            if (!signChanged)
            {
                Var(ref signChanged);
            }
            else
            {
                //MessageBox.Show("Привет");
                if (textBox1.Text.Contains("(-"))
                {
                    int index = textBox1.Text.LastIndexOf("(-");
                    if (index >= 0)
                    {
                        // Убираем "(-" из строки
                        textBox1.Text = textBox1.Text.Remove(index, 2);
                        signChanged = false;
                    }
                }
                else if (textBox1.Text.Length > 0 && textBox1.Text[0] == '-')
                {

                    textBox1.Text = textBox1.Text.Remove(0, 1);
                    signChanged = false;
                }


            }








        }

        private void button20_Click(object sender, EventArgs e)
        {
            sas();
            Pup();

            textBox1.Text += button20.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Pup();

            textBox1.Text += button19.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sas();
            try
            {
                
                object a = new DataTable().Compute(textBox1.Text, null);
                textBox1.Clear();
                double a1 = Convert.ToDouble(a);
                textBox1.Text += a1;
            }
            catch
            {
                
                textBox1.Text = "Использован недопустимый формат";
                

            }



            /*string result = String.Join(", ", plus_);
            textBox1 .Text += result;
            plus_.Clear();*/

            //textBox1.Text += result;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void sas()
        {
            if (textBox1.Text == "Использован недопустимый формат")
            {

                foreach (Control control in this.Controls)
                {
                    if (control is Button btn && btn != button1)
                    {

                        btn.Enabled = false;
                    }
                }


            }
            else if (textBox1.Text != "Использован недопустимый формат")
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button btn && btn != button1)
                    {
                        btn.Enabled = true;

                    }

                }
            }
        }
    }
}
