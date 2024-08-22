using System;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (radioButtonCelsiusToFahrenheit.Checked)
            {
                ConvertCelsiusToFahrenheit();
            }
            else if (radioButtonFahrenheitToCelsius.Checked)
            {
                ConvertFahrenheitToCelsius();
            }
        }

        private void ConvertCelsiusToFahrenheit()
        {
            if (double.TryParse(textBoxCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                textBoxFahrenheit.Text = fahrenheit.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido en Celsius.");
            }
        }

        private void ConvertFahrenheitToCelsius()
        {
            if (double.TryParse(textBoxFahrenheit.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                textBoxCelsius.Text = celsius.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido en Fahrenheit.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            
            textBoxCelsius.Clear();
            textBoxFahrenheit.Clear();

           
            radioButtonCelsiusToFahrenheit.Checked = false;
            radioButtonFahrenheitToCelsius.Checked = false;
        }

        private void textBoxCelsius_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("PictureBox clicked!");
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            
            textBoxCelsius.Clear();
            textBoxFahrenheit.Clear();

            
            radioButtonCelsiusToFahrenheit.Checked = false;
            radioButtonFahrenheitToCelsius.Checked = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void radioButtonFahrenheitToCelsius_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCelsiusToFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
