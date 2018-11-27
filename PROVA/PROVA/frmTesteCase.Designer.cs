namespace PROVA
{
    partial class frmTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeste));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisarTeste = new System.Windows.Forms.Button();
            this.btnSairTeste = new System.Windows.Forms.Button();
            this.btnExcluirTeste = new System.Windows.Forms.Button();
            this.btnAlterarTeste = new System.Windows.Forms.Button();
            this.btnIncluirTeste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 176);
            this.dataGridView1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnPesquisarTeste
            // 
            this.btnPesquisarTeste.Location = new System.Drawing.Point(323, 31);
            this.btnPesquisarTeste.Name = "btnPesquisarTeste";
            this.btnPesquisarTeste.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarTeste.TabIndex = 17;
            this.btnPesquisarTeste.Text = "Pesquisar";
            this.btnPesquisarTeste.UseVisualStyleBackColor = true;
            // 
            // btnSairTeste
            // 
            this.btnSairTeste.Location = new System.Drawing.Point(323, 291);
            this.btnSairTeste.Name = "btnSairTeste";
            this.btnSairTeste.Size = new System.Drawing.Size(75, 41);
            this.btnSairTeste.TabIndex = 22;
            this.btnSairTeste.Text = "Sair";
            this.btnSairTeste.UseVisualStyleBackColor = true;
            this.btnSairTeste.Click += new System.EventHandler(this.btnSairTeste_Click);
            // 
            // btnExcluirTeste
            // 
            this.btnExcluirTeste.Location = new System.Drawing.Point(228, 291);
            this.btnExcluirTeste.Name = "btnExcluirTeste";
            this.btnExcluirTeste.Size = new System.Drawing.Size(75, 41);
            this.btnExcluirTeste.TabIndex = 20;
            this.btnExcluirTeste.Text = "Excluir";
            this.btnExcluirTeste.UseVisualStyleBackColor = true;
            // 
            // btnAlterarTeste
            // 
            this.btnAlterarTeste.Location = new System.Drawing.Point(127, 291);
            this.btnAlterarTeste.Name = "btnAlterarTeste";
            this.btnAlterarTeste.Size = new System.Drawing.Size(75, 41);
            this.btnAlterarTeste.TabIndex = 19;
            this.btnAlterarTeste.Text = "Alterar";
            this.btnAlterarTeste.UseVisualStyleBackColor = true;
            // 
            // btnIncluirTeste
            // 
            this.btnIncluirTeste.Location = new System.Drawing.Point(22, 291);
            this.btnIncluirTeste.Name = "btnIncluirTeste";
            this.btnIncluirTeste.Size = new System.Drawing.Size(75, 41);
            this.btnIncluirTeste.TabIndex = 18;
            this.btnIncluirTeste.Text = "Incluir";
            this.btnIncluirTeste.UseVisualStyleBackColor = true;
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 336);
            this.Controls.Add(this.btnSairTeste);
            this.Controls.Add(this.btnExcluirTeste);
            this.Controls.Add(this.btnAlterarTeste);
            this.Controls.Add(this.btnIncluirTeste);
            this.Controls.Add(this.btnPesquisarTeste);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Case";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisarTeste;
        private System.Windows.Forms.Button btnSairTeste;
        private System.Windows.Forms.Button btnExcluirTeste;
        private System.Windows.Forms.Button btnAlterarTeste;
        private System.Windows.Forms.Button btnIncluirTeste;
    }
}