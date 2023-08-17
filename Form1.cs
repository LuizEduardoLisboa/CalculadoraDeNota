namespace CalculadoraDeNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente sair?!", "Atenção", MessageBoxButtons.YesNo);

            if (sair == DialogResult.Yes)
            {
                Close();
            }

            else if (sair == DialogResult.No)
            {
                txtnota1.Focus();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = " ";
            txtnota2.Text = " ";
            txtnota3.Text = " ";
            txtnota4.Text = " ";
            txtnota1.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, resultado;

            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            nota4 = Convert.ToDouble(txtnota4.Text);
            resultado = (nota1 + nota2 + nota3 + nota4) / 4;
            txtresultado.Text = resultado.ToString();

            MessageBox.Show(txtresultado.Text);


            txtnota1.Text = " ";
            txtnota2.Text = " ";
            txtnota3.Text = " ";
            txtnota4.Text = " ";
            txtresultado.Text = " ";
            txtnota1.Focus();
        }
    }
}