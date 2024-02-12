namespace app_suma_dos_numeros
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Tx_Numero1 = new TextBox();
            Tx_Numero2 = new TextBox();
            Tx_Resultado = new TextBox();
            Calcular = new Button();
            Limpiar = new Button();
            Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Suma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 101);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingresar numero";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 168);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 2;
            label3.Text = "Ingresar numero";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 238);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 3;
            label4.Text = "Resultado";
            // 
            // Tx_Numero1
            // 
            Tx_Numero1.Location = new Point(307, 101);
            Tx_Numero1.Name = "Tx_Numero1";
            Tx_Numero1.Size = new Size(100, 29);
            Tx_Numero1.TabIndex = 4;
            Tx_Numero1.TextChanged += Tx_Numero1_TextChanged;
            // 
            // Tx_Numero2
            // 
            Tx_Numero2.Location = new Point(307, 165);
            Tx_Numero2.Name = "Tx_Numero2";
            Tx_Numero2.Size = new Size(100, 29);
            Tx_Numero2.TabIndex = 5;
            Tx_Numero2.TextChanged += textBox2_TextChanged;
            // 
            // Tx_Resultado
            // 
            Tx_Resultado.Location = new Point(383, 235);
            Tx_Resultado.Name = "Tx_Resultado";
            Tx_Resultado.Size = new Size(100, 29);
            Tx_Resultado.TabIndex = 6;
            Tx_Resultado.TextChanged += textBox3_TextChanged;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(218, 306);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(83, 39);
            Calcular.TabIndex = 7;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += button1_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(316, 306);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(91, 39);
            Limpiar.TabIndex = 9;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Close
            // 
            Close.Location = new Point(421, 306);
            Close.Name = "Close";
            Close.Size = new Size(91, 39);
            Close.TabIndex = 11;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(734, 357);
            Controls.Add(Close);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(Tx_Resultado);
            Controls.Add(Tx_Numero2);
            Controls.Add(Tx_Numero1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Tx_Numero1;
        private TextBox Tx_Numero2;
        private TextBox Tx_Resultado;
        private Button Calcular;
        private Button Limpiar;
        private Button Close;
    }
}
