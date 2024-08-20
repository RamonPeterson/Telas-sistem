namespace WinFormsApp1
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnacesso = new Button();
            label3 = new Label();
            cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 136);
            label1.Name = "label1";
            label1.Size = new Size(119, 40);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Perpetua", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 247);
            label2.Name = "label2";
            label2.Size = new Size(124, 40);
            label2.TabIndex = 2;
            label2.Text = "SENHA";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Perpetua", 21.75F);
            textBox1.Location = new Point(56, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 41);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(56, 300);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(280, 39);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnacesso
            // 
            btnacesso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnacesso.AutoSize = true;
            btnacesso.BackColor = Color.Transparent;
            btnacesso.BackgroundImageLayout = ImageLayout.None;
            btnacesso.Cursor = Cursors.Hand;
            btnacesso.FlatAppearance.BorderColor = Color.DarkRed;
            btnacesso.FlatAppearance.BorderSize = 3;
            btnacesso.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnacesso.FlatAppearance.MouseOverBackColor = Color.Red;
            btnacesso.FlatStyle = FlatStyle.Flat;
            btnacesso.Font = new Font("Perpetua", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnacesso.ForeColor = Color.White;
            btnacesso.Location = new Point(56, 359);
            btnacesso.Name = "btnacesso";
            btnacesso.Size = new Size(129, 57);
            btnacesso.TabIndex = 6;
            btnacesso.Text = "Acessar";
            btnacesso.UseVisualStyleBackColor = false;
            btnacesso.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(-1, 445);
            label3.Name = "label3";
            label3.Size = new Size(20, 13);
            label3.TabIndex = 8;
            label3.Text = "1.0";
            label3.Click += label3_Click;
            // 
            // cancelar
            // 
            cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancelar.AutoSize = true;
            cancelar.BackColor = Color.Transparent;
            cancelar.BackgroundImageLayout = ImageLayout.None;
            cancelar.Cursor = Cursors.Hand;
            cancelar.FlatAppearance.BorderColor = Color.DarkRed;
            cancelar.FlatAppearance.BorderSize = 3;
            cancelar.FlatAppearance.MouseDownBackColor = Color.Maroon;
            cancelar.FlatAppearance.MouseOverBackColor = Color.Red;
            cancelar.FlatStyle = FlatStyle.Flat;
            cancelar.Font = new Font("Perpetua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelar.ForeColor = Color.White;
            cancelar.Location = new Point(207, 359);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(131, 57);
            cancelar.TabIndex = 9;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = false;
            cancelar.Click += button1_Click_1;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 457);
            Controls.Add(cancelar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnacesso);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += frm_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnacesso;
        private Label label3;
        private Button cancelar;
    }
}
