using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactTracingProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string G;
        string C1;
        string C2;
        string C3;
        string C4;
        string C5;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult iSubmit;
                iSubmit = MessageBox.Show("Confirm if you want to submit", "Tracing App",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (iSubmit == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Data\\" +
                    textBox1.Text + "," + textBox3.Text + "" + ".txt");
                    sw.WriteLine(label2.Text + "" + textBox1.Text);
                    sw.WriteLine(label3.Text + "" + textBox3.Text);
                    sw.WriteLine(label4.Text + "" + textBox2.Text);
                    sw.WriteLine(label6.Text + "" + textBox4.Text);
                    sw.WriteLine(label7.Text + "" + textBox5.Text);
                    sw.WriteLine(label10.Text + "" + textBox7.Text);
                    sw.WriteLine(label8.Text + "" + textBox6.Text);
                    sw.WriteLine(label9.Text + "" + G);
                    sw.WriteLine("I have the following:");
                    if (checkBox1.Checked==true)
                    { sw.WriteLine(C1); }
                    if (checkBox2.Checked == true)
                    { sw.WriteLine(C2); }
                    if (checkBox3.Checked == true)
                    { sw.WriteLine(C3); }
                    if (checkBox4.Checked == true)
                    { sw.WriteLine(C4); }
                    if (checkBox5.Checked == true)
                    { sw.WriteLine(C5); }

                    sw.Close();
                    MessageBox.Show("Thank you!", "Success!", MessageBoxButtons.OK);

                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox6.Text = "";
                    radioButton2.Checked = false;
                    radioButton1.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;

                }

                else if (iSubmit == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Click OK to submit!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                G = "Female";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                G = "Male";
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar))
            && e.KeyChar != 64 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                C3 = "I have travel history outside the country.";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                C4 = "I have history of getting covid-19.";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                C1 = "I have symptoms like coughing ,fever, sneezing and headache.";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                C2 = "I have first dose of vaccine.";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                C5 = "I am fully vaccinated.";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
