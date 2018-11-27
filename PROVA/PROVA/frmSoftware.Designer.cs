namespace PROVA
{
    partial class frmSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoftware));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIncluirSoftware = new System.Windows.Forms.Button();
            this.btnAlterarSoftware = new System.Windows.Forms.Button();
            this.btnExcluirSoftware = new System.Windows.Forms.Button();
            this.btnPesquisarSoftware = new System.Windows.Forms.Button();
            this.btnSairSoftware = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 176);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnIncluirSoftware
            // 
            this.btnIncluirSoftware.Location = new System.Drawing.Point(21, 283);
            this.btnIncluirSoftware.Name = "btnIncluirSoftware";
            this.btnIncluirSoftware.Size = new System.Drawing.Size(75, 41);
            this.btnIncluirSoftware.TabIndex = 3;
            this.btnIncluirSoftware.Text = "Incluir";
            this.btnIncluirSoftware.UseVisualStyleBackColor = true;
            // 
            // btnAlterarSoftware
            // 
            this.btnAlterarSoftware.Location = new System.Drawing.Point(125, 283);
            this.btnAlterarSoftware.Name = "btnAlterarSoftware";
            this.btnAlterarSoftware.Size = new System.Drawing.Size(75, 41);
            this.btnAlterarSoftware.TabIndex = 4;
            this.btnAlterarSoftware.Text = "Alterar";
            this.btnAlterarSoftware.UseVisualStyleBackColor = true;
            // 
            // btnExcluirSoftware
            // 
            this.btnExcluirSoftware.Location = new System.Drawing.Point(222, 283);
            this.btnExcluirSoftware.Name = "btnExcluirSoftware";
            this.btnExcluirSoftware.Size = new System.Drawing.Size(75, 41);
            this.btnExcluirSoftware.TabIndex = 5;
            this.btnExcluirSoftware.Text = "Excluir";
            this.btnExcluirSoftware.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarSoftware
            // 
            this.btnPesquisarSoftware.Location = new System.Drawing.Point(322, 35);
            this.btnPesquisarSoftware.Name = "btnPesquisarSoftware";
            this.btnPesquisarSoftware.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarSoftware.TabIndex = 8;
            this.btnPesquisarSoftware.Text = "Pesquisar";
            this.btnPesquisarSoftware.UseVisualStyleBackColor = true;
            // 
            // btnSairSoftware
            // 
            this.btnSairSoftware.Location = new System.Drawing.Point(322, 283);
            this.btnSairSoftware.Name = "btnSairSoftware";
            this.btnSairSoftware.Size = new System.Drawing.Size(75, 41);
            this.btnSairSoftware.TabIndex = 17;
            this.btnSairSoftware.Text = "Sair";
            this.btnSairSoftware.UseVisualStyleBackColor = true;
            this.btnSairSoftware.Click += new System.EventHandler(this.btnSairSoftware_Click);
            // 
            // frmSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 336);
            this.Controls.Add(this.btnSairSoftware);
            this.Controls.Add(this.btnPesquisarSoftware);
            this.Controls.Add(this.btnExcluirSoftware);
            this.Controls.Add(this.btnAlterarSoftware);
            this.Controls.Add(this.btnIncluirSoftware);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIncluirSoftware;
        private System.Windows.Forms.Button btnAlterarSoftware;
        private System.Windows.Forms.Button btnExcluirSoftware;
        private System.Windows.Forms.Button btnPesquisarSoftware;
        private System.Windows.Forms.Button btnSairSoftware;
    }
}