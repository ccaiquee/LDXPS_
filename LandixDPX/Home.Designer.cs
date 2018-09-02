namespace LandixDPX
{
    partial class Home
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
            this.ltxBoxCredito = new System.Windows.Forms.ListBox();
            this.LBClientes = new System.Windows.Forms.Label();
            this.LtBoxCliente = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ltBoxTipo = new System.Windows.Forms.ListBox();
            this.cmBoxVendedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltxBoxCredito
            // 
            this.ltxBoxCredito.Font = new System.Drawing.Font("Arial", 13F);
            this.ltxBoxCredito.FormattingEnabled = true;
            this.ltxBoxCredito.ItemHeight = 19;
            this.ltxBoxCredito.Location = new System.Drawing.Point(480, 250);
            this.ltxBoxCredito.Name = "ltxBoxCredito";
            this.ltxBoxCredito.Size = new System.Drawing.Size(240, 213);
            this.ltxBoxCredito.TabIndex = 1;
            this.ltxBoxCredito.SelectedIndexChanged += new System.EventHandler(this.LtBoxCliente_SelectedIndexChanged);
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
            // 
            // LtBoxCliente
            // 
            this.LtBoxCliente.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtBoxCliente.FormattingEnabled = true;
            this.LtBoxCliente.ItemHeight = 19;
            this.LtBoxCliente.Location = new System.Drawing.Point(26, 250);
            this.LtBoxCliente.Name = "LtBoxCliente";
            this.LtBoxCliente.Size = new System.Drawing.Size(240, 213);
            this.LtBoxCliente.TabIndex = 5;
            this.LtBoxCliente.SelectedIndexChanged += new System.EventHandler(this.LtBoxCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.LBClientes);
            this.panel1.Location = new System.Drawing.Point(480, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 21);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 21);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Pessoa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(281, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 21);
            this.panel3.TabIndex = 10;
            // 
            // ltBoxTipo
            // 
            this.ltBoxTipo.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltBoxTipo.FormattingEnabled = true;
            this.ltBoxTipo.ItemHeight = 19;
            this.ltBoxTipo.Location = new System.Drawing.Point(281, 250);
            this.ltBoxTipo.Name = "ltBoxTipo";
            this.ltBoxTipo.Size = new System.Drawing.Size(183, 213);
            this.ltBoxTipo.TabIndex = 9;
            // 
            // cmBoxVendedor
            // 
            this.cmBoxVendedor.Font = new System.Drawing.Font("Arial", 10F);
            this.cmBoxVendedor.FormattingEnabled = true;
            this.cmBoxVendedor.Location = new System.Drawing.Point(26, 130);
            this.cmBoxVendedor.Name = "cmBoxVendedor";
            this.cmBoxVendedor.Size = new System.Drawing.Size(329, 24);
            this.cmBoxVendedor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vendedores:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.vendedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem1});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            this.manutençãoToolStripMenuItem.Click += new System.EventHandler(this.manutençãoToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem1
            // 
            this.manutençãoToolStripMenuItem1.Name = "manutençãoToolStripMenuItem1";
            this.manutençãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.manutençãoToolStripMenuItem1.Text = "Manutenção";
            this.manutençãoToolStripMenuItem1.Click += new System.EventHandler(this.manutençãoToolStripMenuItem1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(746, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmBoxVendedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ltBoxTipo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LtBoxCliente);
            this.Controls.Add(this.ltxBoxCredito);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home LDXPS";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ltxBoxCredito;
        private System.Windows.Forms.Label LBClientes;
        private System.Windows.Forms.ListBox LtBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox ltBoxTipo;
        private System.Windows.Forms.ComboBox cmBoxVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem1;
    }
}