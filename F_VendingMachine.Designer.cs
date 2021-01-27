namespace VendingMachine
{
    partial class F_VendingMachine
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.lb_precofanta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_precococa = new System.Windows.Forms.Label();
            this.rb_coca = new System.Windows.Forms.RadioButton();
            this.rb_fanta = new System.Windows.Forms.RadioButton();
            this.lb_precodolly = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_dolly = new System.Windows.Forms.RadioButton();
            this.btn_verEstoque = new System.Windows.Forms.Button();
            this.tb_valorInserido = new System.Windows.Forms.TextBox();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_vendasTotais = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "FANTA";
            // 
            // lb_precofanta
            // 
            this.lb_precofanta.AutoSize = true;
            this.lb_precofanta.Location = new System.Drawing.Point(199, 56);
            this.lb_precofanta.Name = "lb_precofanta";
            this.lb_precofanta.Size = new System.Drawing.Size(54, 17);
            this.lb_precofanta.TabIndex = 4;
            this.lb_precofanta.Text = "R$2,50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COCA-COLA";
            // 
            // lb_precococa
            // 
            this.lb_precococa.AutoSize = true;
            this.lb_precococa.Location = new System.Drawing.Point(94, 56);
            this.lb_precococa.Name = "lb_precococa";
            this.lb_precococa.Size = new System.Drawing.Size(54, 17);
            this.lb_precococa.TabIndex = 3;
            this.lb_precococa.Text = "R$3,00";
            // 
            // rb_coca
            // 
            this.rb_coca.AutoSize = true;
            this.rb_coca.Location = new System.Drawing.Point(110, 76);
            this.rb_coca.Name = "rb_coca";
            this.rb_coca.Size = new System.Drawing.Size(17, 16);
            this.rb_coca.TabIndex = 4;
            this.rb_coca.TabStop = true;
            this.rb_coca.UseVisualStyleBackColor = true;
            // 
            // rb_fanta
            // 
            this.rb_fanta.AutoSize = true;
            this.rb_fanta.Location = new System.Drawing.Point(217, 76);
            this.rb_fanta.Name = "rb_fanta";
            this.rb_fanta.Size = new System.Drawing.Size(17, 16);
            this.rb_fanta.TabIndex = 5;
            this.rb_fanta.TabStop = true;
            this.rb_fanta.UseVisualStyleBackColor = true;
            // 
            // lb_precodolly
            // 
            this.lb_precodolly.AutoSize = true;
            this.lb_precodolly.Location = new System.Drawing.Point(291, 56);
            this.lb_precodolly.Name = "lb_precodolly";
            this.lb_precodolly.Size = new System.Drawing.Size(54, 17);
            this.lb_precodolly.TabIndex = 5;
            this.lb_precodolly.Text = "R$2,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOLLY";
            // 
            // rb_dolly
            // 
            this.rb_dolly.AutoSize = true;
            this.rb_dolly.Location = new System.Drawing.Point(310, 76);
            this.rb_dolly.Name = "rb_dolly";
            this.rb_dolly.Size = new System.Drawing.Size(17, 16);
            this.rb_dolly.TabIndex = 6;
            this.rb_dolly.TabStop = true;
            this.rb_dolly.UseVisualStyleBackColor = true;
            // 
            // btn_verEstoque
            // 
            this.btn_verEstoque.Location = new System.Drawing.Point(159, 190);
            this.btn_verEstoque.Name = "btn_verEstoque";
            this.btn_verEstoque.Size = new System.Drawing.Size(126, 25);
            this.btn_verEstoque.TabIndex = 7;
            this.btn_verEstoque.Text = "ESTOQUE";
            this.btn_verEstoque.UseVisualStyleBackColor = true;
            this.btn_verEstoque.Click += new System.EventHandler(this.btn_verEstoque_Click);
            // 
            // tb_valorInserido
            // 
            this.tb_valorInserido.Location = new System.Drawing.Point(148, 107);
            this.tb_valorInserido.Name = "tb_valorInserido";
            this.tb_valorInserido.Size = new System.Drawing.Size(143, 22);
            this.tb_valorInserido.TabIndex = 8;
            this.tb_valorInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_valorInserido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valorInserido_KeyPress);
            // 
            // btn_comprar
            // 
            this.btn_comprar.AutoSize = true;
            this.btn_comprar.Location = new System.Drawing.Point(148, 135);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(143, 27);
            this.btn_comprar.TabIndex = 9;
            this.btn_comprar.Text = "COMPRAR";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_vendasTotais
            // 
            this.btn_vendasTotais.Location = new System.Drawing.Point(12, 190);
            this.btn_vendasTotais.Name = "btn_vendasTotais";
            this.btn_vendasTotais.Size = new System.Drawing.Size(141, 25);
            this.btn_vendasTotais.TabIndex = 10;
            this.btn_vendasTotais.Text = "VALOR VENDAS";
            this.btn_vendasTotais.UseVisualStyleBackColor = true;
            this.btn_vendasTotais.Click += new System.EventHandler(this.btn_vendasTotais_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "QTD VENDAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_vendasTotais);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.tb_valorInserido);
            this.Controls.Add(this.btn_verEstoque);
            this.Controls.Add(this.rb_coca);
            this.Controls.Add(this.rb_fanta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_precococa);
            this.Controls.Add(this.rb_dolly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_precofanta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_precodolly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_VendingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_precofanta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_precococa;
        private System.Windows.Forms.RadioButton rb_coca;
        private System.Windows.Forms.RadioButton rb_fanta;
        private System.Windows.Forms.Label lb_precodolly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_dolly;
        private System.Windows.Forms.Button btn_verEstoque;
        private System.Windows.Forms.TextBox tb_valorInserido;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_vendasTotais;
        private System.Windows.Forms.Button button1;
    }
}

