namespace CalculadoraDeNota
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
            btncalcular = new Button();
            btnsair = new Button();
            btnlimpar = new Button();
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            txtnota3 = new TextBox();
            txtnota4 = new TextBox();
            txtresultado = new TextBox();
            lblnota1 = new Label();
            lblnota2 = new Label();
            lblnota3 = new Label();
            lblnota4 = new Label();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.BackColor = Color.SlateBlue;
            btncalcular.Location = new Point(368, 415);
            btncalcular.Margin = new Padding(4, 2, 4, 2);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(104, 55);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.SlateBlue;
            btnsair.Location = new Point(387, 338);
            btnsair.Margin = new Padding(4, 2, 4, 2);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(85, 32);
            btnsair.TabIndex = 1;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = Color.SlateBlue;
            btnlimpar.Location = new Point(387, 376);
            btnlimpar.Margin = new Padding(4, 2, 4, 2);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(85, 32);
            btnlimpar.TabIndex = 2;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(76, 196);
            txtnota1.Margin = new Padding(4, 2, 4, 2);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(56, 23);
            txtnota1.TabIndex = 3;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(76, 239);
            txtnota2.Margin = new Padding(4, 2, 4, 2);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(56, 23);
            txtnota2.TabIndex = 4;
            // 
            // txtnota3
            // 
            txtnota3.Location = new Point(76, 278);
            txtnota3.Margin = new Padding(4, 2, 4, 2);
            txtnota3.Name = "txtnota3";
            txtnota3.Size = new Size(56, 23);
            txtnota3.TabIndex = 5;
            // 
            // txtnota4
            // 
            txtnota4.Location = new Point(76, 316);
            txtnota4.Margin = new Padding(4, 2, 4, 2);
            txtnota4.Name = "txtnota4";
            txtnota4.Size = new Size(56, 23);
            txtnota4.TabIndex = 6;
            // 
            // txtresultado
            // 
            txtresultado.Enabled = false;
            txtresultado.HideSelection = false;
            txtresultado.Location = new Point(158, 412);
            txtresultado.Margin = new Padding(4, 2, 4, 2);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(50, 23);
            txtresultado.TabIndex = 7;
            // 
            // lblnota1
            // 
            lblnota1.AutoSize = true;
            lblnota1.BackColor = Color.SlateBlue;
            lblnota1.Location = new Point(24, 199);
            lblnota1.Margin = new Padding(4, 0, 4, 0);
            lblnota1.Name = "lblnota1";
            lblnota1.Size = new Size(45, 15);
            lblnota1.TabIndex = 1;
            lblnota1.Text = "Nota 1:";
            // 
            // lblnota2
            // 
            lblnota2.AutoSize = true;
            lblnota2.BackColor = Color.SlateBlue;
            lblnota2.Location = new Point(24, 242);
            lblnota2.Margin = new Padding(4, 0, 4, 0);
            lblnota2.Name = "lblnota2";
            lblnota2.Size = new Size(45, 15);
            lblnota2.TabIndex = 2;
            lblnota2.Text = "Nota 2:";
            // 
            // lblnota3
            // 
            lblnota3.AutoSize = true;
            lblnota3.BackColor = Color.SlateBlue;
            lblnota3.Location = new Point(24, 278);
            lblnota3.Margin = new Padding(4, 0, 4, 0);
            lblnota3.Name = "lblnota3";
            lblnota3.Size = new Size(45, 15);
            lblnota3.TabIndex = 3;
            lblnota3.Text = "Nota 3:";
            // 
            // lblnota4
            // 
            lblnota4.AutoSize = true;
            lblnota4.BackColor = Color.SlateBlue;
            lblnota4.Location = new Point(24, 316);
            lblnota4.Margin = new Padding(4, 0, 4, 0);
            lblnota4.Name = "lblnota4";
            lblnota4.Size = new Size(45, 15);
            lblnota4.TabIndex = 4;
            lblnota4.Text = "Nota 4:";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.BackColor = Color.SlateBlue;
            lblresultado.Location = new Point(89, 415);
            lblresultado.Margin = new Padding(4, 0, 4, 0);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(62, 15);
            lblresultado.TabIndex = 12;
            lblresultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(484, 482);
            Controls.Add(lblresultado);
            Controls.Add(lblnota4);
            Controls.Add(lblnota3);
            Controls.Add(lblnota2);
            Controls.Add(lblnota1);
            Controls.Add(txtresultado);
            Controls.Add(txtnota4);
            Controls.Add(txtnota3);
            Controls.Add(txtnota2);
            Controls.Add(txtnota1);
            Controls.Add(btnlimpar);
            Controls.Add(btnsair);
            Controls.Add(btncalcular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Calculador de Nota";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Button btnsair;
        private Button btnlimpar;
        private TextBox txtnota1;
        private TextBox txtnota2;
        private TextBox txtnota3;
        private TextBox txtnota4;
        private TextBox txtresultado;
        private Label lblnota1;
        private Label lblnota2;
        private Label lblnota3;
        private Label lblnota4;
        private Label lblresultado;
    }
}