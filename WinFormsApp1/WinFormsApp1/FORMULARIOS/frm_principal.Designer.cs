namespace WinFormsApp1
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            vendedor = new LinkLabel();
            produtos = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            cliente = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(vendedor);
            panel1.Controls.Add(produtos);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cliente);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 515);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 474);
            panel2.Name = "panel2";
            panel2.Size = new Size(761, 38);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(-2, 19);
            label2.Name = "label2";
            label2.Size = new Size(20, 13);
            label2.TabIndex = 7;
            label2.Text = "1.0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(264, 2);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Assassins creed";
            // 
            // vendedor
            // 
            vendedor.AutoSize = true;
            vendedor.BorderStyle = BorderStyle.Fixed3D;
            vendedor.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vendedor.ForeColor = Color.Red;
            vendedor.LinkColor = Color.White;
            vendedor.Location = new Point(323, 9);
            vendedor.Name = "vendedor";
            vendedor.Size = new Size(137, 31);
            vendedor.TabIndex = 6;
            vendedor.TabStop = true;
            vendedor.Text = "Vendedor";
            // 
            // produtos
            // 
            produtos.AutoSize = true;
            produtos.BorderStyle = BorderStyle.Fixed3D;
            produtos.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            produtos.ForeColor = Color.Red;
            produtos.LinkColor = Color.White;
            produtos.Location = new Point(77, 9);
            produtos.Name = "produtos";
            produtos.Size = new Size(103, 31);
            produtos.TabIndex = 1;
            produtos.TabStop = true;
            produtos.Text = "Vendas";
            produtos.LinkClicked += produtos_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 21.75F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(271, 53);
            label3.Name = "label3";
            label3.Size = new Size(239, 33);
            label3.TabIndex = 5;
            label3.Text = "Escolha seu caminho.";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(763, 387);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // cliente
            // 
            cliente.AutoSize = true;
            cliente.BackColor = Color.Transparent;
            cliente.BorderStyle = BorderStyle.Fixed3D;
            cliente.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cliente.ForeColor = Color.Red;
            cliente.LinkColor = Color.White;
            cliente.Location = new Point(604, 9);
            cliente.Name = "cliente";
            cliente.Size = new Size(110, 31);
            cliente.TabIndex = 2;
            cliente.TabStop = true;
            cliente.Text = "Cliente";
            cliente.LinkClicked += linkLabel3_LinkClicked;
            // 
            // frm_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 515);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel cliente;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel produtos;
        private LinkLabel vendedor;
        private Label label2;
    }
}