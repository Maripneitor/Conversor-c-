namespace Conversor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxCelsius = new TextBox();
            textBoxFahrenheit = new TextBox();
            radioButtonCelsiusToFahrenheit = new RadioButton();
            radioButtonFahrenheitToCelsius = new RadioButton();
            buttonConvert = new Button();
            labelResult = new Label();
            buttonClear = new Button();
            label1 = new Label();
            label2 = new Label();
            Salir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxCelsius
            // 
            textBoxCelsius.Location = new Point(172, 301);
            textBoxCelsius.Name = "textBoxCelsius";
            textBoxCelsius.Size = new Size(154, 27);
            textBoxCelsius.TabIndex = 2;
            textBoxCelsius.TextChanged += textBoxCelsius_TextChanged;
            // 
            // textBoxFahrenheit
            // 
            textBoxFahrenheit.Location = new Point(637, 301);
            textBoxFahrenheit.Name = "textBoxFahrenheit";
            textBoxFahrenheit.Size = new Size(177, 27);
            textBoxFahrenheit.TabIndex = 3;
            // 
            // radioButtonCelsiusToFahrenheit
            // 
            radioButtonCelsiusToFahrenheit.AutoSize = true;
            radioButtonCelsiusToFahrenheit.Location = new Point(168, 334);
            radioButtonCelsiusToFahrenheit.Name = "radioButtonCelsiusToFahrenheit";
            radioButtonCelsiusToFahrenheit.Size = new Size(158, 24);
            radioButtonCelsiusToFahrenheit.TabIndex = 4;
            radioButtonCelsiusToFahrenheit.TabStop = true;
            radioButtonCelsiusToFahrenheit.Text = "Celsius a fahrenheit";
            radioButtonCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            radioButtonCelsiusToFahrenheit.CheckedChanged += radioButtonCelsiusToFahrenheit_CheckedChanged;
            // 
            // radioButtonFahrenheitToCelsius
            // 
            radioButtonFahrenheitToCelsius.AutoSize = true;
            radioButtonFahrenheitToCelsius.Location = new Point(637, 334);
            radioButtonFahrenheitToCelsius.Name = "radioButtonFahrenheitToCelsius";
            radioButtonFahrenheitToCelsius.Size = new Size(159, 24);
            radioButtonFahrenheitToCelsius.TabIndex = 5;
            radioButtonFahrenheitToCelsius.TabStop = true;
            radioButtonFahrenheitToCelsius.Text = "Fahrenheit a Celsius";
            radioButtonFahrenheitToCelsius.UseVisualStyleBackColor = true;
            radioButtonFahrenheitToCelsius.CheckedChanged += radioButtonFahrenheitToCelsius_CheckedChanged;
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(419, 449);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(181, 54);
            buttonConvert.TabIndex = 6;
            buttonConvert.Text = "Convertir";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(382, 197);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(227, 20);
            labelResult.TabIndex = 7;
            labelResult.Text = "conversor de Celsius a Fahrenheit";
            labelResult.Click += labelResult_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(439, 509);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(150, 42);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Limpiar";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(637, 262);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 9;
            label1.Text = "GRADOS FAHRENHEIT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 262);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 10;
            label2.Text = "GRADOS CELSIUS";
            // 
            // Salir
            // 
            Salir.Location = new Point(439, 568);
            Salir.Name = "Salir";
            Salir.Size = new Size(130, 47);
            Salir.TabIndex = 11;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1020, 904);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 902);
            Controls.Add(Salir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClear);
            Controls.Add(labelResult);
            Controls.Add(buttonConvert);
            Controls.Add(radioButtonFahrenheitToCelsius);
            Controls.Add(radioButtonCelsiusToFahrenheit);
            Controls.Add(textBoxFahrenheit);
            Controls.Add(textBoxCelsius);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCelsius;
        private TextBox textBoxFahrenheit;
        private RadioButton radioButtonCelsiusToFahrenheit;
        private RadioButton radioButtonFahrenheitToCelsius;
        private Button buttonConvert;
        private Label labelResult;
        private Button buttonClear;
        private Label label1;
        private Label label2;
        private Button Salir;
        private PictureBox pictureBox1;
    }
}
