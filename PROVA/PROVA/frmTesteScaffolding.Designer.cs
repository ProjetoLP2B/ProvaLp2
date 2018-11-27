namespace PROVA
{
    partial class frmTesteScaffolding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteScaffolding));
            this.btnSairScaffolding = new System.Windows.Forms.Button();
            this.btnExcluirScaffolding = new System.Windows.Forms.Button();
            this.btnAlterarScaffolding = new System.Windows.Forms.Button();
            this.btnIncluirScaffolding = new System.Windows.Forms.Button();
            this.btnPesquisarScaffolding = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSairScaffolding
            // 
            this.btnSairScaffolding.Location = new System.Drawing.Point(325, 278);
            this.btnSairScaffolding.Name = "btnSairScaffolding";
            this.btnSairScaffolding.Size = new System.Drawing.Size(75, 41);
            this.btnSairScaffolding.TabIndex = 29;
            this.btnSairScaffolding.Text = "Sair";
            this.btnSairScaffolding.UseVisualStyleBackColor = true;
            this.btnSairScaffolding.Click += new System.EventHandler(this.btnSairTeste_Click);
            // 
            // btnExcluirScaffolding
            // 
            this.btnExcluirScaffolding.Location = new System.Drawing.Point(230, 278);
            this.btnExcluirScaffolding.Name = "btnExcluirScaffolding";
            this.btnExcluirScaffolding.Size = new System.Drawing.Size(75, 41);
            this.btnExcluirScaffolding.TabIndex = 28;
            this.btnExcluirScaffolding.Text = "Excluir";
            this.btnExcluirScaffolding.UseVisualStyleBackColor = true;
            // 
            // btnAlterarScaffolding
            // 
            this.btnAlterarScaffolding.Location = new System.Drawing.Point(129, 278);
            this.btnAlterarScaffolding.Name = "btnAlterarScaffolding";
            this.btnAlterarScaffolding.Size = new System.Drawing.Size(75, 41);
            this.btnAlterarScaffolding.TabIndex = 27;
            this.btnAlterarScaffolding.Text = "Alterar";
            this.btnAlterarScaffolding.UseVisualStyleBackColor = true;
            // 
            // btnIncluirScaffolding
            // 
            this.btnIncluirScaffolding.Location = new System.Drawing.Point(24, 278);
            this.btnIncluirScaffolding.Name = "btnIncluirScaffolding";
            this.btnIncluirScaffolding.Size = new System.Drawing.Size(75, 41);
            this.btnIncluirScaffolding.TabIndex = 26;
            this.btnIncluirScaffolding.Text = "Incluir";
            this.btnIncluirScaffolding.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarScaffolding
            // 
            this.btnPesquisarScaffolding.Location = new System.Drawing.Point(325, 18);
            this.btnPesquisarScaffolding.Name = "btnPesquisarScaffolding";
            this.btnPesquisarScaffolding.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarScaffolding.TabIndex = 25;
            this.btnPesquisarScaffolding.Text = "Pesquisar";
            this.btnPesquisarScaffolding.UseVisualStyleBackColor = true;
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
            // frmTesteScaffolding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 336);
            this.Controls.Add(this.btnSairScaffolding);
            this.Controls.Add(this.btnExcluirScaffolding);
            this.Controls.Add(this.btnAlterarScaffolding);
            this.Controls.Add(this.btnIncluirScaffolding);
            this.Controls.Add(this.btnPesquisarScaffolding);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTesteScaffolding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Scaffolding";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairScaffolding;
        private System.Windows.Forms.Button btnExcluirScaffolding;
        private System.Windows.Forms.Button btnAlterarScaffolding;
        private System.Windows.Forms.Button btnIncluirScaffolding;
        private System.Windows.Forms.Button btnPesquisarScaffolding;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}