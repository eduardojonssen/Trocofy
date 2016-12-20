namespace Trocofy {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UxBtnCalculateChange = new System.Windows.Forms.Button();
            this.UxTxtProductAmount = new System.Windows.Forms.TextBox();
            this.UxTxtReceivedAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UxTxtChange = new System.Windows.Forms.TextBox();
            this.UxLblProductAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UxTxtChangeDetailAmount = new System.Windows.Forms.TextBox();
            this.UxLblChangeDetailAmount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxBtnCalculateChange
            // 
            this.UxBtnCalculateChange.Location = new System.Drawing.Point(181, 196);
            this.UxBtnCalculateChange.Name = "UxBtnCalculateChange";
            this.UxBtnCalculateChange.Size = new System.Drawing.Size(75, 35);
            this.UxBtnCalculateChange.TabIndex = 0;
            this.UxBtnCalculateChange.Text = "Calcular";
            this.UxBtnCalculateChange.UseVisualStyleBackColor = true;
            this.UxBtnCalculateChange.Click += new System.EventHandler(this.UxBtnCalculate_Click);
            // 
            // UxTxtProductAmount
            // 
            this.UxTxtProductAmount.Location = new System.Drawing.Point(138, 82);
            this.UxTxtProductAmount.Name = "UxTxtProductAmount";
            this.UxTxtProductAmount.Size = new System.Drawing.Size(170, 26);
            this.UxTxtProductAmount.TabIndex = 1;
            // 
            // UxTxtReceivedAmount
            // 
            this.UxTxtReceivedAmount.Location = new System.Drawing.Point(138, 143);
            this.UxTxtReceivedAmount.Name = "UxTxtReceivedAmount";
            this.UxTxtReceivedAmount.Size = new System.Drawing.Size(170, 26);
            this.UxTxtReceivedAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Devolvido";
            // 
            // UxTxtChange
            // 
            this.UxTxtChange.Location = new System.Drawing.Point(169, 284);
            this.UxTxtChange.Name = "UxTxtChange";
            this.UxTxtChange.Size = new System.Drawing.Size(100, 26);
            this.UxTxtChange.TabIndex = 5;
            this.UxTxtChange.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // UxLblProductAmount
            // 
            this.UxLblProductAmount.AutoSize = true;
            this.UxLblProductAmount.Location = new System.Drawing.Point(165, 59);
            this.UxLblProductAmount.Name = "UxLblProductAmount";
            this.UxLblProductAmount.Size = new System.Drawing.Size(128, 20);
            this.UxLblProductAmount.TabIndex = 6;
            this.UxLblProductAmount.Text = "Valor do Produto";
            this.UxLblProductAmount.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Recebido";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // UxTxtChangeDetailAmount
            // 
            this.UxTxtChangeDetailAmount.Location = new System.Drawing.Point(66, 358);
            this.UxTxtChangeDetailAmount.Multiline = true;
            this.UxTxtChangeDetailAmount.Name = "UxTxtChangeDetailAmount";
            this.UxTxtChangeDetailAmount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UxTxtChangeDetailAmount.Size = new System.Drawing.Size(310, 143);
            this.UxTxtChangeDetailAmount.TabIndex = 22;
            this.UxTxtChangeDetailAmount.TextChanged += new System.EventHandler(this.UxTxtChangeDetailAmount_TextChanged);
            // 
            // UxLblChangeDetailAmount
            // 
            this.UxLblChangeDetailAmount.AutoSize = true;
            this.UxLblChangeDetailAmount.Location = new System.Drawing.Point(156, 335);
            this.UxLblChangeDetailAmount.Name = "UxLblChangeDetailAmount";
            this.UxLblChangeDetailAmount.Size = new System.Drawing.Size(127, 20);
            this.UxLblChangeDetailAmount.TabIndex = 23;
            this.UxLblChangeDetailAmount.Text = "Detalhe do troco";
            this.UxLblChangeDetailAmount.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 623);
            this.Controls.Add(this.UxLblChangeDetailAmount);
            this.Controls.Add(this.UxTxtChangeDetailAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UxLblProductAmount);
            this.Controls.Add(this.UxTxtChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UxTxtReceivedAmount);
            this.Controls.Add(this.UxTxtProductAmount);
            this.Controls.Add(this.UxBtnCalculateChange);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trocofy 1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UxBtnCalculateChange;
        private System.Windows.Forms.TextBox UxTxtProductAmount;
        private System.Windows.Forms.TextBox UxTxtReceivedAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UxTxtChange;
        private System.Windows.Forms.Label UxLblProductAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox UxTxtChangeDetailAmount;
        private System.Windows.Forms.Label UxLblChangeDetailAmount;
    }
}

