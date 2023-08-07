namespace EmpresaTI17T
{
    partial class Atualizar
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
            this.button1 = new System.Windows.Forms.Button();
            this.uf = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(116, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uf
            // 
            this.uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uf.Location = new System.Drawing.Point(149, 264);
            this.uf.Mask = "aa";
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(231, 30);
            this.uf.TabIndex = 21;
            this.uf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.uf_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.telefone.Location = new System.Drawing.Point(149, 192);
            this.telefone.Mask = "(99)99999-9999";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(231, 30);
            this.telefone.TabIndex = 20;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // cidade
            // 
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cidade.Location = new System.Drawing.Point(149, 228);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(230, 30);
            this.cidade.TabIndex = 19;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nome.Location = new System.Drawing.Point(149, 156);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(230, 30);
            this.nome.TabIndex = 18;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpf.Location = new System.Drawing.Point(149, 119);
            this.cpf.Mask = "99999999999";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(231, 30);
            this.cpf.TabIndex = 17;
            this.cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(34, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(34, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Atualizar Pessoa";
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.Atualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox uf;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}