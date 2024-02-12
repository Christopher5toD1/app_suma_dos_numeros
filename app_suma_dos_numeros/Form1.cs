namespace app_suma_dos_numeros
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N1, N2, R3;
            N1 = double.Parse(Tx_Numero1.Text);
            N2 = double.Parse(Tx_Numero2.Text);
            R3 = N1 + N2;
            Tx_Resultado.Text = R3.ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Tx_Numero1.Text = "";
            Tx_Numero2.Text = "";
            Tx_Resultado.Text = "";


        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tx_Numero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
