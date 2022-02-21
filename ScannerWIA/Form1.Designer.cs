namespace ScannerWIA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaScanners = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipoImagem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnTrocarCaminho = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnTrocarCaminho);
            this.groupBox1.Controls.Add(this.txtCaminho);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboTipoImagem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeArquivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listaScanners);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 598);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do arquivo";
            // 
            // listaScanners
            // 
            this.listaScanners.FormattingEnabled = true;
            this.listaScanners.Location = new System.Drawing.Point(9, 52);
            this.listaScanners.Name = "listaScanners";
            this.listaScanners.Size = new System.Drawing.Size(262, 95);
            this.listaScanners.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um dispositivo";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(12, 186);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(259, 20);
            this.txtNomeArquivo.TabIndex = 3;
            this.txtNomeArquivo.Text = "MinhaImagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salvar Como";
            // 
            // comboTipoImagem
            // 
            this.comboTipoImagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoImagem.FormattingEnabled = true;
            this.comboTipoImagem.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "TIFF"});
            this.comboTipoImagem.Location = new System.Drawing.Point(12, 250);
            this.comboTipoImagem.Name = "comboTipoImagem";
            this.comboTipoImagem.Size = new System.Drawing.Size(259, 21);
            this.comboTipoImagem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pasta";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(15, 315);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(256, 20);
            this.txtCaminho.TabIndex = 7;
            // 
            // btnTrocarCaminho
            // 
            this.btnTrocarCaminho.BackColor = System.Drawing.Color.Orange;
            this.btnTrocarCaminho.Location = new System.Drawing.Point(15, 341);
            this.btnTrocarCaminho.Name = "btnTrocarCaminho";
            this.btnTrocarCaminho.Size = new System.Drawing.Size(132, 29);
            this.btnTrocarCaminho.TabIndex = 8;
            this.btnTrocarCaminho.Text = "Mudar caminho";
            this.btnTrocarCaminho.UseVisualStyleBackColor = false;
            this.btnTrocarCaminho.Click += new System.EventHandler(this.btnTrocarCaminho_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnScan, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(295, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.94702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.05298F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 604);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScan.Location = new System.Drawing.Point(3, 3);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(234, 42);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scanear";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Scanner WIA Andson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listaScanners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Button btnTrocarCaminho;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTipoImagem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnScan;
    }
}

