namespace PROVA
{
    partial class frmTesteHierarchical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteHierarchical));
            this.btnSairHierarchical = new System.Windows.Forms.Button();
            this.btnExcluirHierarchical = new System.Windows.Forms.Button();
            this.btnAlterarHierarchical = new System.Windows.Forms.Button();
            this.btnIncluirHierarchical = new System.Windows.Forms.Button();
            this.btnPesquisarHierarchical = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSairHierarchical
            // 
            this.btnSairHierarchical.Location = new System.Drawing.Point(325, 278);
            this.btnSairHierarchical.Name = "btnSairHierarchical";
            this.btnSairHierarchical.Size = new System.Drawing.Size(75, 41);
            this.btnSairHierarchical.TabIndex = 29;
            this.btnSairHierarchical.Text = "Sair";
            this.btnSairHierarchical.UseVisualStyleBackColor = true;
            this.btnSairHierarchical.Click += new System.EventHandler(this.btnSairTeste_Click);
            // 
            // btnExcluirHierarchical
            // 
            this.btnExcluirHierarchical.Location = new System.Drawing.Point(230, 278);
            this.btnExcluirHierarchical.Name = "btnExcluirHierarchical";
            this.btnExcluirHierarchical.Size = new System.Drawing.Size(75, 41);
            this.btnExcluirHierarchical.TabIndex = 28;
            this.btnExcluirHierarchical.Text = "Excluir";
            this.btnExcluirHierarchical.UseVisualStyleBackColor = true;
            // 
            // btnAlterarHierarchical
            // 
            this.btnAlterarHierarchical.Location = new System.Drawing.Point(129, 278);
            this.btnAlterarHierarchical.Name = "btnAlterarHierarchical";
            this.btnAlterarHierarchical.Size = new System.Drawing.Size(75, 41);
            this.btnAlterarHierarchical.TabIndex = 27;
            this.btnAlterarHierarchical.Text = "Alterar";
            this.btnAlterarHierarchical.UseVisualStyleBackColor = true;
            // 
            // btnIncluirHierarchical
            // 
            this.btnIncluirHierarchical.Location = new System.Drawing.Point(24, 278);
            this.btnIncluirHierarchical.Name = "btnIncluirHierarchical";
            this.btnIncluirHierarchical.Size = new System.Drawing.Size(75, 41);
            this.btnIncluirHierarchical.TabIndex = 26;
            this.btnIncluirHierarchical.Text = "Incluir";
            this.btnIncluirHierarchical.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarHierarchical
            // 
            this.btnPesquisarHierarchical.Location = new System.Drawing.Point(325, 18);
            this.btnPesquisarHierarchical.Name = "btnPesquisarHierarchical";
            this.btnPesquisarHierarchical.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarHierarchical.TabIndex = 25;
            this.btnPesquisarHierarchical.Text = "Pesquisar";
            this.btnPesquisarHierarchical.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 176);
            this.dataGridView1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 23;
            // 
            // frmTesteHierarchical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 336);
            this.Controls.Add(this.btnSairHierarchical);
            this.Controls.Add(this.btnExcluirHierarchical);
            this.Controls.Add(this.btnAlterarHierarchical);
            this.Controls.Add(this.btnIncluirHierarchical);
            this.Controls.Add(this.btnPesquisarHierarchical);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTesteHierarchical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Hierarchical";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairHierarchical;
        private System.Windows.Forms.Button btnExcluirHierarchical;
        private System.Windows.Forms.Button btnAlterarHierarchical;
        private System.Windows.Forms.Button btnIncluirHierarchical;
        private System.Windows.Forms.Button btnPesquisarHierarchical;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}