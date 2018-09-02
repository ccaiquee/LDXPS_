namespace LandixDPX
{
    partial class CadastroClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtipoT = new System.Windows.Forms.TextBox();
            this.LtCdvend = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ltBoxTipo = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBClientes = new System.Windows.Forms.Label();
            this.LtBoxCliente = new System.Windows.Forms.ListBox();
            this.ltxBoxCredito = new System.Windows.Forms.ListBox();
            this.CodVend = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(159, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Clientes";
            this.label1.UseWaitCursor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(607, 194);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 37);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.UseWaitCursor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de pessoa:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Limite de Credito:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vendedor:";
            this.label5.UseWaitCursor = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(100, 98);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(274, 20);
            this.txtnome.TabIndex = 8;
            this.txtnome.UseWaitCursor = true;
            // 
            // txtcredito
            // 
            this.txtcredito.Location = new System.Drawing.Point(280, 141);
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.Size = new System.Drawing.Size(94, 20);
            this.txtcredito.TabIndex = 9;
            this.txtcredito.UseWaitCursor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarVendedorToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // criarVendedorToolStripMenuItem
            // 
            this.criarVendedorToolStripMenuItem.Name = "criarVendedorToolStripMenuItem";
            this.criarVendedorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.criarVendedorToolStripMenuItem.Text = "Criar Vendedor";
            this.criarVendedorToolStripMenuItem.Click += new System.EventHandler(this.criarVendedorToolStripMenuItem_Click);
            // 
            // txtipoT
            // 
            this.txtipoT.Location = new System.Drawing.Point(104, 139);
            this.txtipoT.Name = "txtipoT";
            this.txtipoT.Size = new System.Drawing.Size(79, 20);
            this.txtipoT.TabIndex = 12;
            this.txtipoT.UseWaitCursor = true;
            this.txtipoT.TextChanged += new System.EventHandler(this.txtipoT_TextChanged);
            // 
            // LtCdvend
            // 
            this.LtCdvend.Location = new System.Drawing.Point(100, 236);
            this.LtCdvend.Name = "LtCdvend";
            this.LtCdvend.Size = new System.Drawing.Size(274, 20);
            this.LtCdvend.TabIndex = 13;
            this.LtCdvend.UseWaitCursor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(607, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 37);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.UseWaitCursor = true;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(607, 84);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 37);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.UseWaitCursor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(269, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 21);
            this.panel3.TabIndex = 23;
            this.panel3.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo de Pessoa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseWaitCursor = true;
            // 
            // ltBoxTipo
            // 
            this.ltBoxTipo.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltBoxTipo.FormattingEnabled = true;
            this.ltBoxTipo.ItemHeight = 19;
            this.ltBoxTipo.Location = new System.Drawing.Point(269, 312);
            this.ltBoxTipo.Name = "ltBoxTipo";
            this.ltBoxTipo.Size = new System.Drawing.Size(183, 213);
            this.ltBoxTipo.TabIndex = 22;
            this.ltBoxTipo.UseWaitCursor = true;
            this.ltBoxTipo.SelectedIndexChanged += new System.EventHandler(this.ltxBoxCredito_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(14, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 21);
            this.panel2.TabIndex = 21;
            this.panel2.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(90, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Clientes";
            this.label7.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.LBClientes);
            this.panel1.Location = new System.Drawing.Point(468, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 21);
            this.panel1.TabIndex = 20;
            this.panel1.UseWaitCursor = true;
            // 
            // LBClientes
            // 
            this.LBClientes.AutoSize = true;
            this.LBClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LBClientes.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBClientes.ForeColor = System.Drawing.Color.White;
            this.LBClientes.Location = new System.Drawing.Point(74, 1);
            this.LBClientes.Name = "LBClientes";
            this.LBClientes.Size = new System.Drawing.Size(118, 17);
            this.LBClientes.TabIndex = 3;
            this.LBClientes.Text = "Limite de Crédito";
            this.LBClientes.UseWaitCursor = true;
            // 
            // LtBoxCliente
            // 
            this.LtBoxCliente.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtBoxCliente.FormattingEnabled = true;
            this.LtBoxCliente.ItemHeight = 19;
            this.LtBoxCliente.Location = new System.Drawing.Point(14, 312);
            this.LtBoxCliente.Name = "LtBoxCliente";
            this.LtBoxCliente.Size = new System.Drawing.Size(240, 213);
            this.LtBoxCliente.TabIndex = 19;
            this.LtBoxCliente.UseWaitCursor = true;
            this.LtBoxCliente.SelectedIndexChanged += new System.EventHandler(this.ltxBoxCredito_SelectedIndexChanged);
            // 
            // ltxBoxCredito
            // 
            this.ltxBoxCredito.Font = new System.Drawing.Font("Arial", 13F);
            this.ltxBoxCredito.FormattingEnabled = true;
            this.ltxBoxCredito.ItemHeight = 19;
            this.ltxBoxCredito.Location = new System.Drawing.Point(468, 312);
            this.ltxBoxCredito.Name = "ltxBoxCredito";
            this.ltxBoxCredito.Size = new System.Drawing.Size(240, 213);
            this.ltxBoxCredito.TabIndex = 18;
            this.ltxBoxCredito.UseWaitCursor = true;
            this.ltxBoxCredito.SelectedIndexChanged += new System.EventHandler(this.ltxBoxCredito_SelectedIndexChanged);
            // 
            // CodVend
            // 
            this.CodVend.FormattingEnabled = true;
            this.CodVend.Location = new System.Drawing.Point(101, 188);
            this.CodVend.Name = "CodVend";
            this.CodVend.Size = new System.Drawing.Size(144, 21);
            this.CodVend.TabIndex = 24;
            this.CodVend.UseWaitCursor = true;
            this.CodVend.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Código Vendedor:";
            this.label9.UseWaitCursor = true;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 540);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CodVend);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ltBoxTipo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LtBoxCliente);
            this.Controls.Add(this.ltxBoxCredito);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.LtCdvend);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtipoT);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcredito);
            this.Name = "CadastroClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarVendedorToolStripMenuItem;
        private System.Windows.Forms.TextBox txtipoT;
        private System.Windows.Forms.TextBox LtCdvend;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ltBoxTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBClientes;
        private System.Windows.Forms.ListBox LtBoxCliente;
        private System.Windows.Forms.ListBox ltxBoxCredito;
        private System.Windows.Forms.ComboBox CodVend;
        private System.Windows.Forms.Label label9;
    }
}