namespace WinFormsApp1
{
    partial class frm_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cliente));
            id = new Label();
            cliente = new Label();
            email = new Label();
            contato = new Label();
            data = new Label();
            endereco = new Label();
            vendedor = new Label();
            Genero = new Label();
            contato_text = new MaskedTextBox();
            data_text = new MaskedTextBox();
            id_text = new TextBox();
            cliente_text = new TextBox();
            email_text = new TextBox();
            vendedor_text = new TextBox();
            endereco_text = new TextBox();
            combogenero = new ComboBox();
            acessar = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            combocidade = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            splitter1 = new Splitter();
            process1 = new System.Diagnostics.Process();
            splitter2 = new Splitter();
            button1 = new Button();
            btn_limpar = new Button();
            btn_novo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = Color.Transparent;
            id.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            id.ForeColor = SystemColors.ButtonHighlight;
            id.Location = new Point(53, 87);
            id.Margin = new Padding(4, 0, 4, 0);
            id.Name = "id";
            id.Size = new Size(34, 24);
            id.TabIndex = 0;
            id.Text = "ID:";
            // 
            // cliente
            // 
            cliente.AutoSize = true;
            cliente.BackColor = Color.Transparent;
            cliente.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            cliente.ForeColor = SystemColors.ButtonHighlight;
            cliente.Location = new Point(52, 129);
            cliente.Margin = new Padding(4, 0, 4, 0);
            cliente.Name = "cliente";
            cliente.Size = new Size(79, 24);
            cliente.TabIndex = 1;
            cliente.Text = "Cliente:";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            email.ForeColor = SystemColors.ButtonHighlight;
            email.Location = new Point(52, 176);
            email.Margin = new Padding(4, 0, 4, 0);
            email.Name = "email";
            email.Size = new Size(65, 24);
            email.TabIndex = 2;
            email.Text = "Email:";
            // 
            // contato
            // 
            contato.AutoSize = true;
            contato.BackColor = Color.Transparent;
            contato.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            contato.ForeColor = SystemColors.ButtonHighlight;
            contato.Location = new Point(53, 341);
            contato.Margin = new Padding(4, 0, 4, 0);
            contato.Name = "contato";
            contato.Size = new Size(84, 24);
            contato.TabIndex = 3;
            contato.Text = "Contato:";
            // 
            // data
            // 
            data.AutoSize = true;
            data.BackColor = Color.Transparent;
            data.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            data.ForeColor = SystemColors.ButtonHighlight;
            data.Location = new Point(52, 215);
            data.Margin = new Padding(4, 0, 4, 0);
            data.Name = "data";
            data.Size = new Size(94, 24);
            data.TabIndex = 4;
            data.Text = "Data Nas:";
            // 
            // endereco
            // 
            endereco.AutoSize = true;
            endereco.BackColor = Color.Transparent;
            endereco.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            endereco.ForeColor = SystemColors.ButtonHighlight;
            endereco.Location = new Point(52, 305);
            endereco.Margin = new Padding(4, 0, 4, 0);
            endereco.Name = "endereco";
            endereco.Size = new Size(95, 24);
            endereco.TabIndex = 5;
            endereco.Text = "Endereço:";
            // 
            // vendedor
            // 
            vendedor.AutoSize = true;
            vendedor.BackColor = Color.Transparent;
            vendedor.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            vendedor.ForeColor = SystemColors.ButtonHighlight;
            vendedor.Location = new Point(52, 260);
            vendedor.Margin = new Padding(4, 0, 4, 0);
            vendedor.Name = "vendedor";
            vendedor.Size = new Size(99, 24);
            vendedor.TabIndex = 6;
            vendedor.Text = "Vendedor:";
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.BackColor = Color.Transparent;
            Genero.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            Genero.ForeColor = SystemColors.ButtonHighlight;
            Genero.Location = new Point(52, 383);
            Genero.Margin = new Padding(4, 0, 4, 0);
            Genero.Name = "Genero";
            Genero.Size = new Size(77, 24);
            Genero.TabIndex = 10;
            Genero.Text = "Genero:";
            // 
            // contato_text
            // 
            contato_text.BackColor = Color.Black;
            contato_text.Enabled = false;
            contato_text.Font = new Font("Microsoft Sans Serif", 14.25F);
            contato_text.ForeColor = Color.White;
            contato_text.Location = new Point(147, 341);
            contato_text.Margin = new Padding(4);
            contato_text.Mask = "(99) 00000-0000";
            contato_text.Name = "contato_text";
            contato_text.Size = new Size(233, 29);
            contato_text.TabIndex = 12;
            contato_text.TextAlign = HorizontalAlignment.Center;
            // 
            // data_text
            // 
            data_text.BackColor = Color.Black;
            data_text.Enabled = false;
            data_text.Font = new Font("Microsoft Sans Serif", 14.25F);
            data_text.ForeColor = Color.White;
            data_text.Location = new Point(147, 212);
            data_text.Margin = new Padding(4);
            data_text.Mask = "00/00/0000";
            data_text.Name = "data_text";
            data_text.Size = new Size(233, 29);
            data_text.TabIndex = 13;
            data_text.TextAlign = HorizontalAlignment.Center;
            data_text.ValidatingType = typeof(DateTime);
            // 
            // id_text
            // 
            id_text.BackColor = Color.Black;
            id_text.Enabled = false;
            id_text.Font = new Font("Microsoft Sans Serif", 14.25F);
            id_text.ForeColor = Color.White;
            id_text.Location = new Point(147, 84);
            id_text.Margin = new Padding(3, 4, 3, 4);
            id_text.Name = "id_text";
            id_text.Size = new Size(233, 29);
            id_text.TabIndex = 14;
            id_text.TextChanged += id_text_TextChanged;
            // 
            // cliente_text
            // 
            cliente_text.BackColor = Color.Black;
            cliente_text.Enabled = false;
            cliente_text.Font = new Font("Microsoft Sans Serif", 14.25F);
            cliente_text.ForeColor = Color.White;
            cliente_text.Location = new Point(147, 126);
            cliente_text.Margin = new Padding(3, 4, 3, 4);
            cliente_text.Name = "cliente_text";
            cliente_text.Size = new Size(233, 29);
            cliente_text.TabIndex = 16;
            // 
            // email_text
            // 
            email_text.BackColor = Color.Black;
            email_text.Enabled = false;
            email_text.Font = new Font("Microsoft Sans Serif", 14.25F);
            email_text.ForeColor = Color.White;
            email_text.Location = new Point(147, 173);
            email_text.Margin = new Padding(3, 4, 3, 4);
            email_text.Name = "email_text";
            email_text.Size = new Size(233, 29);
            email_text.TabIndex = 17;
            // 
            // vendedor_text
            // 
            vendedor_text.BackColor = Color.Black;
            vendedor_text.Enabled = false;
            vendedor_text.Font = new Font("Microsoft Sans Serif", 14.25F);
            vendedor_text.ForeColor = Color.White;
            vendedor_text.Location = new Point(147, 257);
            vendedor_text.Margin = new Padding(3, 4, 3, 4);
            vendedor_text.Name = "vendedor_text";
            vendedor_text.Size = new Size(233, 29);
            vendedor_text.TabIndex = 18;
            // 
            // endereco_text
            // 
            endereco_text.BackColor = Color.Black;
            endereco_text.Enabled = false;
            endereco_text.Font = new Font("Microsoft Sans Serif", 14.25F);
            endereco_text.ForeColor = Color.White;
            endereco_text.Location = new Point(147, 302);
            endereco_text.Margin = new Padding(3, 4, 3, 4);
            endereco_text.Name = "endereco_text";
            endereco_text.Size = new Size(233, 29);
            endereco_text.TabIndex = 19;
            // 
            // combogenero
            // 
            combogenero.BackColor = Color.Black;
            combogenero.Enabled = false;
            combogenero.Font = new Font("Microsoft Sans Serif", 14.25F);
            combogenero.ForeColor = Color.White;
            combogenero.FormattingEnabled = true;
            combogenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            combogenero.Location = new Point(147, 383);
            combogenero.Margin = new Padding(3, 4, 3, 4);
            combogenero.Name = "combogenero";
            combogenero.Size = new Size(233, 32);
            combogenero.TabIndex = 20;
            combogenero.Text = "Genero";
            // 
            // acessar
            // 
            acessar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            acessar.AutoSize = true;
            acessar.BackColor = Color.Transparent;
            acessar.BackgroundImageLayout = ImageLayout.None;
            acessar.Cursor = Cursors.Hand;
            acessar.Enabled = false;
            acessar.FlatAppearance.BorderColor = Color.DarkRed;
            acessar.FlatAppearance.BorderSize = 3;
            acessar.FlatAppearance.MouseDownBackColor = Color.Maroon;
            acessar.FlatAppearance.MouseOverBackColor = Color.Red;
            acessar.FlatStyle = FlatStyle.Flat;
            acessar.Font = new Font("Stencil", 14.25F);
            acessar.ForeColor = SystemColors.ButtonHighlight;
            acessar.Location = new Point(12, 476);
            acessar.Margin = new Padding(3, 4, 3, 4);
            acessar.Name = "acessar";
            acessar.Size = new Size(133, 38);
            acessar.TabIndex = 21;
            acessar.Text = "Cadastrar";
            acessar.UseVisualStyleBackColor = false;
            acessar.Click += acessar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Perpetua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(133, 9);
            label2.Name = "label2";
            label2.Size = new Size(172, 55);
            label2.TabIndex = 24;
            label2.Text = "Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 514);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(52, 428);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 25;
            label1.Text = "Estado:";
            // 
            // combocidade
            // 
            combocidade.BackColor = Color.Black;
            combocidade.Enabled = false;
            combocidade.Font = new Font("Microsoft Sans Serif", 14.25F);
            combocidade.ForeColor = Color.White;
            combocidade.FormattingEnabled = true;
            combocidade.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF" });
            combocidade.Location = new Point(147, 425);
            combocidade.Margin = new Padding(3, 4, 3, 4);
            combocidade.Name = "combocidade";
            combocidade.Size = new Size(233, 32);
            combocidade.TabIndex = 26;
            combocidade.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(115, 62);
            label3.Name = "label3";
            label3.Size = new Size(214, 18);
            label3.TabIndex = 27;
            label3.Text = "O inicio de uma nova jornada.";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(9, 535);
            label4.Name = "label4";
            label4.Size = new Size(20, 13);
            label4.TabIndex = 28;
            label4.Text = "1.0";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 518);
            splitter1.TabIndex = 29;
            splitter1.TabStop = false;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 518);
            splitter2.TabIndex = 30;
            splitter2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ravie", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(3, 0);
            button1.Name = "button1";
            button1.Size = new Size(60, 52);
            button1.TabIndex = 31;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_limpar.AutoSize = true;
            btn_limpar.BackColor = Color.Transparent;
            btn_limpar.BackgroundImageLayout = ImageLayout.None;
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.Enabled = false;
            btn_limpar.FlatAppearance.BorderColor = Color.DarkRed;
            btn_limpar.FlatAppearance.BorderSize = 3;
            btn_limpar.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_limpar.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_limpar.FlatStyle = FlatStyle.Flat;
            btn_limpar.Font = new Font("Stencil", 14.25F);
            btn_limpar.ForeColor = SystemColors.ButtonHighlight;
            btn_limpar.Location = new Point(151, 476);
            btn_limpar.Margin = new Padding(3, 4, 3, 4);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(142, 38);
            btn_limpar.TabIndex = 32;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_novo
            // 
            btn_novo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_novo.AutoSize = true;
            btn_novo.BackColor = Color.Transparent;
            btn_novo.BackgroundImageLayout = ImageLayout.None;
            btn_novo.Cursor = Cursors.Hand;
            btn_novo.FlatAppearance.BorderColor = Color.DarkRed;
            btn_novo.FlatAppearance.BorderSize = 3;
            btn_novo.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_novo.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_novo.FlatStyle = FlatStyle.Flat;
            btn_novo.Font = new Font("Stencil", 14.25F);
            btn_novo.ForeColor = SystemColors.ButtonHighlight;
            btn_novo.Location = new Point(303, 476);
            btn_novo.Margin = new Padding(3, 4, 3, 4);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(130, 38);
            btn_novo.TabIndex = 33;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += btn_novo_Click;
            // 
            // frm_cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(855, 518);
            Controls.Add(btn_novo);
            Controls.Add(btn_limpar);
            Controls.Add(button1);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(combocidade);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(acessar);
            Controls.Add(combogenero);
            Controls.Add(endereco_text);
            Controls.Add(vendedor_text);
            Controls.Add(email_text);
            Controls.Add(cliente_text);
            Controls.Add(id_text);
            Controls.Add(data_text);
            Controls.Add(contato_text);
            Controls.Add(Genero);
            Controls.Add(vendedor);
            Controls.Add(endereco);
            Controls.Add(data);
            Controls.Add(contato);
            Controls.Add(email);
            Controls.Add(cliente);
            Controls.Add(id);
            Font = new Font("Perpetua", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frm_cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label id;
        private Label cliente;
        private Label email;
        private Label contato;
        private Label data;
        private Label endereco;
        private Label vendedor;
        private Label Genero;
        private MaskedTextBox contato_text;
        private MaskedTextBox data_text;
        private TextBox id_text;
        private TextBox cliente_text;
        private TextBox email_text;
        private TextBox vendedor_text;
        private TextBox endereco_text;
        private ComboBox combogenero;
        private Button acessar;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox combocidade;
        private Label label3;
        private Label label4;
        private Splitter splitter1;
        private System.Diagnostics.Process process1;
        private Button button1;
        private Splitter splitter2;
        private Button btn_novo;
        private Button btn_limpar;
    }
}