namespace app_de_matematicas
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
            Tx_Division = new TextBox();
            Tx_Multiplicacion = new TextBox();
            Tx_Resta = new TextBox();
            Tx_Suma = new TextBox();
            Tx_Valor2 = new TextBox();
            Tx_Valor1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Calcular = new Button();
            Salir = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // Tx_Division
            // 
            Tx_Division.Location = new Point(145, 379);
            Tx_Division.Name = "Tx_Division";
            Tx_Division.Size = new Size(100, 23);
            Tx_Division.TabIndex = 0;
            // 
            // Tx_Multiplicacion
            // 
            Tx_Multiplicacion.Location = new Point(145, 316);
            Tx_Multiplicacion.Name = "Tx_Multiplicacion";
            Tx_Multiplicacion.Size = new Size(100, 23);
            Tx_Multiplicacion.TabIndex = 1;
            // 
            // Tx_Resta
            // 
            Tx_Resta.Location = new Point(145, 258);
            Tx_Resta.Name = "Tx_Resta";
            Tx_Resta.Size = new Size(100, 23);
            Tx_Resta.TabIndex = 2;
            // 
            // Tx_Suma
            // 
            Tx_Suma.Location = new Point(145, 198);
            Tx_Suma.Name = "Tx_Suma";
            Tx_Suma.Size = new Size(100, 23);
            Tx_Suma.TabIndex = 3;
            // 
            // Tx_Valor2
            // 
            Tx_Valor2.Location = new Point(378, 133);
            Tx_Valor2.Name = "Tx_Valor2";
            Tx_Valor2.Size = new Size(100, 23);
            Tx_Valor2.TabIndex = 4;
            // 
            // Tx_Valor1
            // 
            Tx_Valor1.Location = new Point(145, 133);
            Tx_Valor1.Name = "Tx_Valor1";
            Tx_Valor1.Size = new Size(100, 23);
            Tx_Valor1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 58);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 6;
            label1.Text = "Calculadora Rapida";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(80, 133);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 7;
            label2.Text = "Valor 1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(80, 201);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 8;
            label3.Text = "Suma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(80, 266);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 9;
            label4.Text = "Resta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(32, 314);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 10;
            label5.Text = "Multiplicacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(62, 377);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 11;
            label6.Text = "Division";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(494, 133);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 12;
            label7.Text = "Valor 2";
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Segoe UI", 12F);
            Calcular.Location = new Point(397, 196);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(90, 31);
            Calcular.TabIndex = 13;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += this.button1_Click;
            // 
            // Salir
            // 
            Salir.Font = new Font("Segoe UI", 12F);
            Salir.Location = new Point(397, 373);
            Salir.Name = "Salir";
            Salir.Size = new Size(90, 31);
            Salir.TabIndex = 14;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += this.button2_Click;
            // 
            // Limpiar
            // 
            Limpiar.Font = new Font("Segoe UI", 12F);
            Limpiar.Location = new Point(397, 277);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(90, 31);
            Limpiar.TabIndex = 15;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(Limpiar);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Tx_Valor1);
            Controls.Add(Tx_Valor2);
            Controls.Add(Tx_Suma);
            Controls.Add(Tx_Resta);
            Controls.Add(Tx_Multiplicacion);
            Controls.Add(Tx_Division);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tx_Division;
        private TextBox Tx_Multiplicacion;
        private TextBox Tx_Resta;
        private TextBox Tx_Suma;
        private TextBox Tx_Valor2;
        private TextBox Tx_Valor1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Calcular;
        private Button Salir;
        private Button Limpiar;
    }
}
