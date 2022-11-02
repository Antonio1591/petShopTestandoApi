namespace petShopTestandoApi.Viwer
{
    partial class frmCadastroPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(166, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro Pessoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de \r\nNascimento";
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(166, 148);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 23);
            this.cmbCidade.TabIndex = 7;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(166, 224);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(121, 23);
            this.dtNascimento.TabIndex = 8;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastra.Location = new System.Drawing.Point(39, 279);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(86, 39);
            this.btnCadastra.TabIndex = 9;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(179, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastroPessoa";
            this.Text = "frmCadastroPessoa";
            this.Load += new System.EventHandler(this.frmCadastroPessoa_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbCidade;
        private DateTimePicker dtNascimento;
        private Button btnCadastra;
        private Button button2;
    }
}