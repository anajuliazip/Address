namespace Address
{
    partial class Form1
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
            txbDestinatario = new TextBox();
            label1 = new Label();
            btnEnviar = new Button();
            label2 = new Label();
            txbTipoLog = new TextBox();
            label3 = new Label();
            txbNomeLog = new TextBox();
            label4 = new Label();
            txbNumero = new TextBox();
            label5 = new Label();
            txbComplemento = new TextBox();
            label6 = new Label();
            txbBairro = new TextBox();
            label7 = new Label();
            txbCep = new TextBox();
            label8 = new Label();
            txbCidade = new TextBox();
            label9 = new Label();
            txbEstado = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // txbDestinatario
            // 
            txbDestinatario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbDestinatario.Font = new Font("Dutch801 Rm BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbDestinatario.Location = new Point(85, 201);
            txbDestinatario.Name = "txbDestinatario";
            txbDestinatario.Size = new Size(100, 22);
            txbDestinatario.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 180);
            label1.Name = "label1";
            label1.Size = new Size(148, 18);
            label1.TabIndex = 1;
            label1.Text = "Nome do destinatario";
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Dutch801 XBd BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(346, 347);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(106, 42);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(217, 180);
            label2.Name = "label2";
            label2.Size = new Size(132, 18);
            label2.TabIndex = 4;
            label2.Text = "Tipo do logradouro";
            // 
            // txbTipoLog
            // 
            txbTipoLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbTipoLog.Font = new Font("Dutch801 Rm BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbTipoLog.Location = new Point(234, 200);
            txbTipoLog.Name = "txbTipoLog";
            txbTipoLog.Size = new Size(100, 22);
            txbTipoLog.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(355, 179);
            label3.Name = "label3";
            label3.Size = new Size(141, 18);
            label3.TabIndex = 6;
            label3.Text = "Nome do logradouro";
            // 
            // txbNomeLog
            // 
            txbNomeLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbNomeLog.Font = new Font("Dutch801 Rm BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeLog.Location = new Point(372, 201);
            txbNomeLog.Name = "txbNomeLog";
            txbNomeLog.Size = new Size(100, 22);
            txbNomeLog.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(533, 180);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 8;
            label4.Text = "Número";
            // 
            // txbNumero
            // 
            txbNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbNumero.Font = new Font("Dutch801 Rm BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbNumero.Location = new Point(512, 200);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(100, 22);
            txbNumero.TabIndex = 7;
            txbNumero.TextChanged += txbNumero_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(630, 179);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 10;
            label5.Text = "Complemento";
            // 
            // txbComplemento
            // 
            txbComplemento.Anchor = AnchorStyles.Top;
            txbComplemento.Font = new Font("Dutch801 Rm BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbComplemento.Location = new Point(630, 200);
            txbComplemento.Name = "txbComplemento";
            txbComplemento.Size = new Size(100, 22);
            txbComplemento.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(180, 241);
            label6.Name = "label6";
            label6.Size = new Size(50, 18);
            label6.TabIndex = 12;
            label6.Text = "Bairro";
            // 
            // txbBairro
            // 
            txbBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbBairro.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbBairro.Location = new Point(162, 259);
            txbBairro.Name = "txbBairro";
            txbBairro.Size = new Size(100, 25);
            txbBairro.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(321, 241);
            label7.Name = "label7";
            label7.Size = new Size(37, 18);
            label7.TabIndex = 14;
            label7.Text = "CEP";
            // 
            // txbCep
            // 
            txbCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbCep.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbCep.Location = new Point(289, 259);
            txbCep.Name = "txbCep";
            txbCep.Size = new Size(100, 25);
            txbCep.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(443, 241);
            label8.Name = "label8";
            label8.Size = new Size(53, 18);
            label8.TabIndex = 16;
            label8.Text = "Cidade";
            // 
            // txbCidade
            // 
            txbCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbCidade.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbCidade.Location = new Point(419, 259);
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(100, 25);
            txbCidade.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(569, 241);
            label9.Name = "label9";
            label9.Size = new Size(53, 18);
            label9.TabIndex = 18;
            label9.Text = "Estado";
            // 
            // txbEstado
            // 
            txbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbEstado.Font = new Font("Dutch801 Rm BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbEstado.Location = new Point(548, 259);
            txbEstado.Name = "txbEstado";
            txbEstado.Size = new Size(100, 25);
            txbEstado.TabIndex = 17;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(217, 70);
            label10.Name = "label10";
            label10.Size = new Size(369, 31);
            label10.TabIndex = 19;
            label10.Text = "Informações de endereçamento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txbEstado);
            Controls.Add(label8);
            Controls.Add(txbCidade);
            Controls.Add(label7);
            Controls.Add(txbCep);
            Controls.Add(label6);
            Controls.Add(txbBairro);
            Controls.Add(label5);
            Controls.Add(txbComplemento);
            Controls.Add(label4);
            Controls.Add(txbNumero);
            Controls.Add(label3);
            Controls.Add(txbNomeLog);
            Controls.Add(label2);
            Controls.Add(txbTipoLog);
            Controls.Add(btnEnviar);
            Controls.Add(label1);
            Controls.Add(txbDestinatario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbDestinatario;
        private Label label1;
        private Button btnEnviar;
        private Label label2;
        private TextBox txbTipoLog;
        private Label label3;
        private TextBox txbNomeLog;
        private Label label4;
        private TextBox txbNumero;
        private Label label5;
        private TextBox txbComplemento;
        private Label label6;
        private TextBox txbBairro;
        private Label label7;
        private TextBox txbCep;
        private Label label8;
        private TextBox txbCidade;
        private Label label9;
        private TextBox txbEstado;
        private Label label10;
    }
}