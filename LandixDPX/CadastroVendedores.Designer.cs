namespace LandixDPX
{
    partial class CadastroVendedores
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbclientes = new System.Windows.Forms.ComboBox();
            this.btnCadastrarV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LtDTNASC = new System.Windows.Forms.ListBox();
            this.LtCDTAB = new System.Windows.Forms.ListBox();
            this.LtDSNOME = new System.Windows.Forms.ListBox();
            this.LtCDVEND = new System.Windows.Forms.ListBox();
            this.Atualizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LBClientes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.criarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(138, 100);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(226, 20);
            this.txbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código tabela preço:";
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(138, 137);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(68, 20);
            this.txbCod.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(138, 178);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(226, 20);
            this.dtpNascimento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clientes:";
            // 
            // cmbclientes
            // 
            this.cmbclientes.FormattingEnabled = true;
            this.cmbclientes.Location = new System.Drawing.Point(138, 224);
            this.cmbclientes.Name = "cmbclientes";
            this.cmbclientes.Size = new System.Drawing.Size(226, 21);
            this.cmbclientes.TabIndex = 7;
            this.cmbclientes.SelectedIndexChanged += new System.EventHandler(this.cmbclientes_SelectedIndexChanged);
            // 
            // btnCadastrarV
            // 
            this.btnCadastrarV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarV.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarV.Location = new System.Drawing.Point(697, 91);
            this.btnCadastrarV.Name = "btnCadastrarV";
            this.btnCadastrarV.Size = new System.Drawing.Size(88, 37);
            this.btnCadastrarV.TabIndex = 8;
            this.btnCadastrarV.Text = "Cadastrar";
            this.btnCadastrarV.UseVisualStyleBackColor = true;
            this.btnCadastrarV.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(697, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // LtDTNASC
            // 
            this.LtDTNASC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtDTNASC.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtDTNASC.FormattingEnabled = true;
            this.LtDTNASC.ItemHeight = 19;
            this.LtDTNASC.Location = new System.Drawing.Point(633, 301);
            this.LtDTNASC.Name = "LtDTNASC";
            this.LtDTNASC.Size = new System.Drawing.Size(152, 152);
            this.LtDTNASC.TabIndex = 3;
            this.LtDTNASC.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // LtCDTAB
            // 
            this.LtCDTAB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtCDTAB.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtCDTAB.FormattingEnabled = true;
            this.LtCDTAB.ItemHeight = 19;
            this.LtCDTAB.Location = new System.Drawing.Point(475, 301);
            this.LtCDTAB.Name = "LtCDTAB";
            this.LtCDTAB.Size = new System.Drawing.Size(152, 152);
            this.LtCDTAB.TabIndex = 2;
            this.LtCDTAB.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // LtDSNOME
            // 
            this.LtDSNOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtDSNOME.Font = new System.Drawing.Font("Arial", 13F);
            this.LtDSNOME.FormattingEnabled = true;
            this.LtDSNOME.ItemHeight = 19;
            this.LtDSNOME.Location = new System.Drawing.Point(278, 301);
            this.LtDSNOME.Name = "LtDSNOME";
            this.LtDSNOME.Size = new System.Drawing.Size(192, 152);
            this.LtDSNOME.TabIndex = 1;
            this.LtDSNOME.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // LtCDVEND
            // 
            this.LtCDVEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LtCDVEND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtCDVEND.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtCDVEND.FormattingEnabled = true;
            this.LtCDVEND.ItemHeight = 19;
            this.LtCDVEND.Location = new System.Drawing.Point(25, 301);
            this.LtCDVEND.Name = "LtCDVEND";
            this.LtCDVEND.Size = new System.Drawing.Size(248, 152);
            this.LtCDVEND.TabIndex = 0;
            this.LtCDVEND.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualizar.Font = new System.Drawing.Font("Arial", 10F);
            this.Atualizar.ForeColor = System.Drawing.Color.White;
            this.Atualizar.Location = new System.Drawing.Point(697, 140);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(88, 37);
            this.Atualizar.TabIndex = 15;
            this.Atualizar.Text = "Editar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(79, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Identificador";
            this.label9.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(278, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 21);
            this.panel1.TabIndex = 26;
            this.panel1.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tipo de Pessoa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseWaitCursor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(25, 274);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 21);
            this.panel6.TabIndex = 25;
            this.panel6.UseWaitCursor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Controls.Add(this.LBClientes);
            this.panel7.Location = new System.Drawing.Point(475, 274);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 21);
            this.panel7.TabIndex = 24;
            this.panel7.UseWaitCursor = true;
            // 
            // LBClientes
            // 
            this.LBClientes.AutoSize = true;
            this.LBClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LBClientes.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBClientes.ForeColor = System.Drawing.Color.White;
            this.LBClientes.Location = new System.Drawing.Point(14, 2);
            this.LBClientes.Name = "LBClientes";
            this.LBClientes.Size = new System.Drawing.Size(120, 17);
            this.LBClientes.TabIndex = 3;
            this.LBClientes.Text = "Código da Tabelo";
            this.LBClientes.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(633, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 21);
            this.panel2.TabIndex = 25;
            this.panel2.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data de Nascimento";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(273, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cadastro Vendedor";
            // 
            // criarClienteToolStripMenuItem
            // 
            this.criarClienteToolStripMenuItem.Name = "criarClienteToolStripMenuItem";
            this.criarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarClienteToolStripMenuItem.Text = "Criar Cliente";
            this.criarClienteToolStripMenuItem.Click += new System.EventHandler(this.criarClienteToolStripMenuItem_Click);
            // 
            // CadastroVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 473);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.LtDTNASC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LtCDTAB);
            this.Controls.Add(this.btnCadastrarV);
            this.Controls.Add(this.LtDSNOME);
            this.Controls.Add(this.cmbclientes);
            this.Controls.Add(this.LtCDVEND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroVendedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vendedores";
            this.Load += new System.EventHandler(this.CadastroVendedores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbclientes;
        private System.Windows.Forms.Button btnCadastrarV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ListBox LtDTNASC;
        private System.Windows.Forms.ListBox LtCDTAB;
        private System.Windows.Forms.ListBox LtDSNOME;
        private System.Windows.Forms.ListBox LtCDVEND;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LBClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem criarClienteToolStripMenuItem;
    }
}