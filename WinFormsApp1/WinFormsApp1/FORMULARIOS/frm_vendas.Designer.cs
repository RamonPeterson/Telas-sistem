namespace WinFormsApp1
{
    partial class frm_vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vendas));
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            endereco = new TextBox();
            cliente = new TextBox();
            email = new TextBox();
            codigo_cliente = new TextBox();
            label9 = new Label();
            email_cliente = new Label();
            textbox = new Label();
            codcliente = new Label();
            button1 = new Button();
            label6 = new Label();
            panel3 = new Panel();
            fabricante = new ComboBox();
            id_produto = new TextBox();
            lala = new Label();
            produto = new Label();
            idproduto = new Label();
            label3 = new Label();
            codigo_barra = new TextBox();
            panel4 = new Panel();
            loja = new ComboBox();
            id_vendedor = new TextBox();
            labell12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            vendedor = new TextBox();
            label11 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            label2 = new Label();
            label12 = new Label();
            label5 = new Label();
            finalizar_compra = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(640, 36);
            label4.Name = "label4";
            label4.Size = new Size(193, 32);
            label4.TabIndex = 0;
            label4.Text = "The Witcher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 8);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 1;
            label1.Text = "Informações do cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(endereco);
            panel1.Controls.Add(cliente);
            panel1.Controls.Add(email);
            panel1.Controls.Add(codigo_cliente);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(email_cliente);
            panel1.Controls.Add(textbox);
            panel1.Controls.Add(codcliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 233);
            panel1.TabIndex = 8;
            // 
            // endereco
            // 
            endereco.Font = new Font("Perpetua", 11.25F);
            endereco.Location = new Point(193, 194);
            endereco.Name = "endereco";
            endereco.Size = new Size(231, 25);
            endereco.TabIndex = 9;
            // 
            // cliente
            // 
            cliente.Font = new Font("Perpetua", 11.25F);
            cliente.Location = new Point(193, 105);
            cliente.Name = "cliente";
            cliente.Size = new Size(231, 25);
            cliente.TabIndex = 8;
            // 
            // email
            // 
            email.Font = new Font("Perpetua", 11.25F);
            email.Location = new Point(193, 151);
            email.Name = "email";
            email.Size = new Size(231, 25);
            email.TabIndex = 10;
            // 
            // codigo_cliente
            // 
            codigo_cliente.Font = new Font("Perpetua", 11.25F);
            codigo_cliente.Location = new Point(193, 68);
            codigo_cliente.Name = "codigo_cliente";
            codigo_cliente.Size = new Size(231, 25);
            codigo_cliente.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 14.25F);
            label9.Location = new Point(64, 191);
            label9.Name = "label9";
            label9.Size = new Size(83, 22);
            label9.TabIndex = 5;
            label9.Text = "Endereço:";
            // 
            // email_cliente
            // 
            email_cliente.AutoSize = true;
            email_cliente.Font = new Font("Perpetua", 14.25F);
            email_cliente.Location = new Point(64, 148);
            email_cliente.Name = "email_cliente";
            email_cliente.Size = new Size(56, 22);
            email_cliente.TabIndex = 4;
            email_cliente.Text = "Email:";
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Font = new Font("Perpetua", 14.25F);
            textbox.Location = new Point(64, 105);
            textbox.Name = "textbox";
            textbox.Size = new Size(68, 22);
            textbox.TabIndex = 3;
            textbox.Text = "Cliente:";
            // 
            // codcliente
            // 
            codcliente.AutoSize = true;
            codcliente.Font = new Font("Perpetua", 14.25F);
            codcliente.Location = new Point(64, 65);
            codcliente.Name = "codcliente";
            codcliente.Size = new Size(123, 22);
            codcliente.TabIndex = 2;
            codcliente.Text = "Codigo Cliente:";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ravie", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(0, -2);
            button1.Name = "button1";
            button1.Size = new Size(60, 52);
            button1.TabIndex = 32;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(752, 113);
            label6.Name = "label6";
            label6.Size = new Size(193, 32);
            label6.TabIndex = 0;
            label6.Text = "The Witcher";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(fabricante);
            panel3.Controls.Add(id_produto);
            panel3.Controls.Add(lala);
            panel3.Controls.Add(produto);
            panel3.Controls.Add(idproduto);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(codigo_barra);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(477, 256);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 236);
            panel3.TabIndex = 9;
            // 
            // fabricante
            // 
            fabricante.BackColor = Color.Black;
            fabricante.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fabricante.ForeColor = Color.White;
            fabricante.FormattingEnabled = true;
            fabricante.Items.AddRange(new object[] { "BRF", "Seara", "Pamplona", "Frimesa" });
            fabricante.Location = new Point(193, 164);
            fabricante.Margin = new Padding(3, 4, 3, 4);
            fabricante.Name = "fabricante";
            fabricante.Size = new Size(231, 36);
            fabricante.TabIndex = 21;
            // 
            // id_produto
            // 
            id_produto.Font = new Font("Perpetua", 11.25F);
            id_produto.Location = new Point(193, 68);
            id_produto.Name = "id_produto";
            id_produto.Size = new Size(231, 25);
            id_produto.TabIndex = 13;
            // 
            // lala
            // 
            lala.AutoSize = true;
            lala.Font = new Font("Perpetua", 14.25F);
            lala.Location = new Point(64, 178);
            lala.Name = "lala";
            lala.Size = new Size(89, 22);
            lala.TabIndex = 7;
            lala.Text = "Fabricante:";
            // 
            // produto
            // 
            produto.AutoSize = true;
            produto.Font = new Font("Perpetua", 14.25F);
            produto.Location = new Point(64, 120);
            produto.Name = "produto";
            produto.Size = new Size(75, 22);
            produto.TabIndex = 8;
            produto.Text = "Produto:";
            // 
            // idproduto
            // 
            idproduto.AutoSize = true;
            idproduto.Font = new Font("Perpetua", 14.25F);
            idproduto.Location = new Point(64, 65);
            idproduto.Name = "idproduto";
            idproduto.Size = new Size(96, 22);
            idproduto.TabIndex = 9;
            idproduto.Text = "ID produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 8);
            label3.Name = "label3";
            label3.Size = new Size(228, 28);
            label3.TabIndex = 6;
            label3.Text = "Informações do produtos";
            // 
            // codigo_barra
            // 
            codigo_barra.Font = new Font("Perpetua", 11.25F);
            codigo_barra.Location = new Point(193, 111);
            codigo_barra.Name = "codigo_barra";
            codigo_barra.Size = new Size(231, 25);
            codigo_barra.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Controls.Add(loja);
            panel4.Controls.Add(id_vendedor);
            panel4.Controls.Add(labell12);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(vendedor);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(477, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(453, 236);
            panel4.TabIndex = 10;
            // 
            // loja
            // 
            loja.BackColor = Color.Black;
            loja.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loja.ForeColor = Color.White;
            loja.FormattingEnabled = true;
            loja.Items.AddRange(new object[] { "Plataforma", "Barra", "Calçada", "Peri Peri" });
            loja.Location = new Point(189, 162);
            loja.Margin = new Padding(3, 4, 3, 4);
            loja.Name = "loja";
            loja.Size = new Size(235, 36);
            loja.TabIndex = 21;
            // 
            // id_vendedor
            // 
            id_vendedor.Font = new Font("Perpetua", 11.25F);
            id_vendedor.Location = new Point(189, 63);
            id_vendedor.Name = "id_vendedor";
            id_vendedor.Size = new Size(235, 25);
            id_vendedor.TabIndex = 13;
            // 
            // labell12
            // 
            labell12.AutoSize = true;
            labell12.Font = new Font("Perpetua", 14.25F);
            labell12.Location = new Point(64, 176);
            labell12.Name = "labell12";
            labell12.Size = new Size(46, 22);
            labell12.TabIndex = 7;
            labell12.Text = "Loja:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 14.25F);
            label7.Location = new Point(64, 118);
            label7.Name = "label7";
            label7.Size = new Size(86, 22);
            label7.TabIndex = 8;
            label7.Text = "Vendedor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 14.25F);
            label8.Location = new Point(64, 63);
            label8.Name = "label8";
            label8.Size = new Size(105, 22);
            label8.TabIndex = 9;
            label8.Text = "ID vendedor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(91, 8);
            label10.Name = "label10";
            label10.Size = new Size(236, 28);
            label10.TabIndex = 6;
            label10.Text = "Informações do Vendedor";
            // 
            // vendedor
            // 
            vendedor.Font = new Font("Perpetua", 11.25F);
            vendedor.Location = new Point(189, 107);
            vendedor.Name = "vendedor";
            vendedor.Size = new Size(235, 25);
            vendedor.TabIndex = 7;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(844, 179);
            label11.Name = "label11";
            label11.Size = new Size(193, 32);
            label11.TabIndex = 0;
            label11.Text = "The Witcher";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(2, 489);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 38);
            panel2.TabIndex = 11;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(370, 3);
            label13.Name = "label13";
            label13.Size = new Size(244, 32);
            label13.TabIndex = 12;
            label13.Text = "Assassins creed";
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
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(628, -29);
            label12.Name = "label12";
            label12.Size = new Size(244, 32);
            label12.TabIndex = 0;
            label12.Text = "Assassins creed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(195, 33);
            label5.Name = "label5";
            label5.Size = new Size(113, 36);
            label5.TabIndex = 33;
            label5.Text = "Vendas";
            // 
            // finalizar_compra
            // 
            finalizar_compra.BackColor = Color.Maroon;
            finalizar_compra.Cursor = Cursors.Hand;
            finalizar_compra.FlatAppearance.BorderColor = Color.Maroon;
            finalizar_compra.FlatAppearance.MouseDownBackColor = Color.Red;
            finalizar_compra.FlatAppearance.MouseOverBackColor = Color.Red;
            finalizar_compra.Font = new Font("Perpetua", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalizar_compra.ForeColor = Color.White;
            finalizar_compra.Location = new Point(143, 160);
            finalizar_compra.Name = "finalizar_compra";
            finalizar_compra.Size = new Size(209, 52);
            finalizar_compra.TabIndex = 34;
            finalizar_compra.Text = "Finalizar";
            finalizar_compra.UseVisualStyleBackColor = false;
            // 
            // frm_vendas
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(930, 530);
            Controls.Add(finalizar_compra);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Perpetua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_vendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Panel panel3;
        private Label label9;
        private Label email_cliente;
        private Label textbox;
        private Label codcliente;
        private Label lala;
        private Label labell12;
        private Label label3;
        private Label idproduto;
        private Label produto;
        private TextBox email;
        private TextBox endereco;
        private TextBox cliente;
        private TextBox codigo_barra;
        private TextBox codigo_cliente;
        private TextBox id_produto;
        private ComboBox fabricante;
        private Button button1;
        private Panel panel4;
        private ComboBox loja;
        private TextBox id_vendedor;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox vendedor;
        private Label label11;
        private Panel panel2;
        private Label label2;
        private Label label12;
        private Label label13;
        private Label label5;
        private Button finalizar_compra;
    }
}