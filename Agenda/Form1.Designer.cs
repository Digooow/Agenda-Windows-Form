namespace Agenda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btInserir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btExcluir = new Button();
            dGDados = new DataGridView();
            btNext = new Button();
            mtbTelefone = new MaskedTextBox();
            mtbNome = new MaskedTextBox();
            mtbId = new MaskedTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Contato";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 41);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 70);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            // 
            // btInserir
            // 
            btInserir.BackColor = SystemColors.MenuHighlight;
            btInserir.BackgroundImageLayout = ImageLayout.None;
            btInserir.Cursor = Cursors.Hand;
            btInserir.Location = new Point(26, 109);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(75, 23);
            btInserir.TabIndex = 6;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.TopCenter;
            btInserir.UseVisualStyleBackColor = false;
            btInserir.Click += btInserir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.MenuHighlight;
            btAlterar.Location = new Point(107, 109);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 23);
            btAlterar.TabIndex = 7;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(188, 109);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(75, 23);
            btLocalizar.TabIndex = 8;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(269, 109);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 9;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // dGDados
            // 
            dGDados.AllowUserToAddRows = false;
            dGDados.AllowUserToDeleteRows = false;
            dGDados.AllowUserToResizeColumns = false;
            dGDados.AllowUserToResizeRows = false;
            dGDados.BackgroundColor = SystemColors.GradientActiveCaption;
            dGDados.BorderStyle = BorderStyle.None;
            dGDados.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dGDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGDados.ImeMode = ImeMode.On;
            dGDados.Location = new Point(28, 173);
            dGDados.MultiSelect = false;
            dGDados.Name = "dGDados";
            dGDados.ReadOnly = true;
            dGDados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dGDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGDados.Size = new Size(325, 150);
            dGDados.TabIndex = 10;
            dGDados.TabStop = false;
            dGDados.CellClick += dGDados_SelectionChanged;
            dGDados.CellContentClick += dGDados_CellContentClick;
            // 
            // btNext
            // 
            btNext.Location = new Point(350, 109);
            btNext.Name = "btNext";
            btNext.Size = new Size(75, 23);
            btNext.TabIndex = 11;
            btNext.Text = "Próxima";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(94, 67);
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(207, 23);
            mtbTelefone.TabIndex = 12;
            mtbTelefone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // mtbNome
            // 
            mtbNome.Location = new Point(94, 38);
            mtbNome.Name = "mtbNome";
            mtbNome.Size = new Size(207, 23);
            mtbNome.TabIndex = 13;
            // 
            // mtbId
            // 
            mtbId.Location = new Point(94, 9);
            mtbId.Name = "mtbId";
            mtbId.Size = new Size(207, 23);
            mtbId.TabIndex = 14;
            mtbId.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(94, 5);
            label4.Name = "label4";
            label4.Size = new Size(207, 23);
            label4.TabIndex = 15;
            label4.Text = "Id gerado automaticamente.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(mtbId);
            Controls.Add(mtbNome);
            Controls.Add(mtbTelefone);
            Controls.Add(btNext);
            Controls.Add(dGDados);
            Controls.Add(btExcluir);
            Controls.Add(btLocalizar);
            Controls.Add(btAlterar);
            Controls.Add(btInserir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Agenda";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dGDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btInserir;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btExcluir;
        private DataGridView dGDados;
        private Button btNext;
        private MaskedTextBox mtbTelefone;
        private MaskedTextBox mtbNome;
        private MaskedTextBox mtbId;
        private Label label4;
    }
}
