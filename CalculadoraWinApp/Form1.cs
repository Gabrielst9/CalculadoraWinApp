namespace CalculadoraWinApp
{
    public partial class Form1 : Form
    {
        public List<string> historicoOperacoes = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private byte VerificaOpcaoEscolhida()
        {
            byte opcaoEscohida;

            if (radioBtnAdicao.Checked)
            {
                opcaoEscohida = 1;
            }

            else if (radioBtnSubtracao.Checked)
            {
                opcaoEscohida = 2;
            }

            else if (radioBtnMultiplicacao.Checked)
            {
                opcaoEscohida = 3;
            }

            else if (radioBtnDivisao.Checked)
            {
                opcaoEscohida = 4;
            }

            else
            {
                opcaoEscohida = 0;
            }

            return opcaoEscohida;
        }

        public float RealizarCalculo(byte operacaoEscolhida)
        {
            float primeiroNumero = int.Parse(txtPrimeiroNumero.Text);
            float segundoNumero = int.Parse(txtSegundoNumero.Text);
            float resultado;
            string operador = "";

            switch (operacaoEscolhida)
            {
                case 1:
                    resultado = Somar(primeiroNumero, segundoNumero);
                    operador = "+";
                    historicoOperacoes.Add($"{primeiroNumero} {operador} {segundoNumero} = {resultado}");
                    return resultado;

                case 2:
                    resultado = Subtrair(primeiroNumero, segundoNumero);
                    operador = "-";
                    historicoOperacoes.Add($"{primeiroNumero} {operador} {segundoNumero} = {resultado}");
                    return resultado;

                case 3:
                    resultado = Multiplicar(primeiroNumero, segundoNumero);
                    operador = "x";
                    historicoOperacoes.Add($"{primeiroNumero} {operador} {segundoNumero} = {resultado}");
                    return resultado;

                case 4:
                    resultado = Dividir(primeiroNumero, segundoNumero);
                    operador = "/";
                    historicoOperacoes.Add($"{primeiroNumero} {operador} {segundoNumero} = {resultado}");
                    return resultado;
            }

            return 0;
        }

        #region Funções
        private float Somar(float primeiroNumero, float segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        private float Subtrair(float primeiroNumero, float segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        private float Multiplicar(float primeiroNumero, float segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        private float Dividir(float primeiroNumero, float segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
        #endregion

        public void AdicionarItensListBox()
        {
            listBoxHistorico.Items.Clear();
            listBoxHistorico.Items.AddRange(historicoOperacoes.ToArray());
        }

        #region Botões
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            byte opcaoEscolhida = VerificaOpcaoEscolhida();
            float resultado = RealizarCalculo(opcaoEscolhida);
            AdicionarItensListBox();
            lblResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Text = "";
            txtSegundoNumero.Text = "";
            lblResultado.Text = "";
        }
        #endregion
    }
}
