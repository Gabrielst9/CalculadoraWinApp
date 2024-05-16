namespace CalculadoraWinApp
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
            pnlPrincipal = new Panel();
            lblResultado = new Label();
            listBoxHistorico = new ListBox();
            btnLimpar = new Button();
            btnCalcular = new Button();
            grpBoxOpcoes = new GroupBox();
            radioBtnDivisao = new RadioButton();
            radioBtnMultiplicacao = new RadioButton();
            radioBtnSubtracao = new RadioButton();
            radioBtnAdicao = new RadioButton();
            lblSegundoNumero = new Label();
            lblPrimeiroNumero = new Label();
            txtSegundoNumero = new TextBox();
            txtPrimeiroNumero = new TextBox();
            pnlPrincipal.SuspendLayout();
            grpBoxOpcoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = SystemColors.ControlLight;
            pnlPrincipal.Controls.Add(lblResultado);
            pnlPrincipal.Controls.Add(listBoxHistorico);
            pnlPrincipal.Controls.Add(btnLimpar);
            pnlPrincipal.Controls.Add(btnCalcular);
            pnlPrincipal.Controls.Add(grpBoxOpcoes);
            pnlPrincipal.Controls.Add(lblSegundoNumero);
            pnlPrincipal.Controls.Add(lblPrimeiroNumero);
            pnlPrincipal.Controls.Add(txtSegundoNumero);
            pnlPrincipal.Controls.Add(txtPrimeiroNumero);
            pnlPrincipal.Location = new Point(168, 25);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(435, 532);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(276, 45);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // listBoxHistorico
            // 
            listBoxHistorico.FormattingEnabled = true;
            listBoxHistorico.ItemHeight = 15;
            listBoxHistorico.Location = new Point(7, 385);
            listBoxHistorico.Name = "listBoxHistorico";
            listBoxHistorico.Size = new Size(417, 139);
            listBoxHistorico.TabIndex = 7;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.Info;
            btnLimpar.Location = new Point(7, 342);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(417, 37);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.Info;
            btnCalcular.Location = new Point(7, 299);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(417, 37);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // grpBoxOpcoes
            // 
            grpBoxOpcoes.BackColor = SystemColors.InactiveCaption;
            grpBoxOpcoes.Controls.Add(radioBtnDivisao);
            grpBoxOpcoes.Controls.Add(radioBtnMultiplicacao);
            grpBoxOpcoes.Controls.Add(radioBtnSubtracao);
            grpBoxOpcoes.Controls.Add(radioBtnAdicao);
            grpBoxOpcoes.Location = new Point(7, 110);
            grpBoxOpcoes.Name = "grpBoxOpcoes";
            grpBoxOpcoes.Size = new Size(417, 183);
            grpBoxOpcoes.TabIndex = 4;
            grpBoxOpcoes.TabStop = false;
            grpBoxOpcoes.Text = "Selecione a Operação";
            // 
            // radioBtnDivisao
            // 
            radioBtnDivisao.AutoSize = true;
            radioBtnDivisao.Location = new Point(6, 117);
            radioBtnDivisao.Name = "radioBtnDivisao";
            radioBtnDivisao.Size = new Size(63, 19);
            radioBtnDivisao.TabIndex = 3;
            radioBtnDivisao.TabStop = true;
            radioBtnDivisao.Text = "Divisão";
            radioBtnDivisao.UseVisualStyleBackColor = true;
            // 
            // radioBtnMultiplicacao
            // 
            radioBtnMultiplicacao.AutoSize = true;
            radioBtnMultiplicacao.Location = new Point(6, 92);
            radioBtnMultiplicacao.Name = "radioBtnMultiplicacao";
            radioBtnMultiplicacao.Size = new Size(97, 19);
            radioBtnMultiplicacao.TabIndex = 2;
            radioBtnMultiplicacao.TabStop = true;
            radioBtnMultiplicacao.Text = "Multiplicação";
            radioBtnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radioBtnSubtracao
            // 
            radioBtnSubtracao.AutoSize = true;
            radioBtnSubtracao.Location = new Point(6, 67);
            radioBtnSubtracao.Name = "radioBtnSubtracao";
            radioBtnSubtracao.Size = new Size(78, 19);
            radioBtnSubtracao.TabIndex = 1;
            radioBtnSubtracao.TabStop = true;
            radioBtnSubtracao.Text = "Subtração";
            radioBtnSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdicao
            // 
            radioBtnAdicao.AutoSize = true;
            radioBtnAdicao.Location = new Point(6, 42);
            radioBtnAdicao.Name = "radioBtnAdicao";
            radioBtnAdicao.Size = new Size(62, 19);
            radioBtnAdicao.TabIndex = 0;
            radioBtnAdicao.TabStop = true;
            radioBtnAdicao.Text = "Adição";
            radioBtnAdicao.UseVisualStyleBackColor = true;
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Location = new Point(7, 71);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(101, 15);
            lblSegundoNumero.TabIndex = 3;
            lblSegundoNumero.Text = "Segundo Numero";
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Location = new Point(7, 29);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(99, 15);
            lblPrimeiroNumero.TabIndex = 2;
            lblPrimeiroNumero.Text = "Primeiro Número";
            // 
            // txtSegundoNumero
            // 
            txtSegundoNumero.Location = new Point(111, 68);
            txtSegundoNumero.Name = "txtSegundoNumero";
            txtSegundoNumero.Size = new Size(100, 23);
            txtSegundoNumero.TabIndex = 1;
            // 
            // txtPrimeiroNumero
            // 
            txtPrimeiroNumero.Location = new Point(111, 26);
            txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            txtPrimeiroNumero.Size = new Size(100, 23);
            txtPrimeiroNumero.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 584);
            Controls.Add(pnlPrincipal);
            Name = "Form1";
            Text = "Form1";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            grpBoxOpcoes.ResumeLayout(false);
            grpBoxOpcoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private GroupBox grpBoxOpcoes;
        private Label lblSegundoNumero;
        private Label lblPrimeiroNumero;
        private TextBox txtSegundoNumero;
        private TextBox txtPrimeiroNumero;
        private RadioButton radioBtnDivisao;
        private RadioButton radioBtnMultiplicacao;
        private RadioButton radioBtnSubtracao;
        private RadioButton radioBtnAdicao;
        private Button btnLimpar;
        private Button btnCalcular;
        private ListBox listBoxHistorico;
        private Label lblResultado;
    }
}
