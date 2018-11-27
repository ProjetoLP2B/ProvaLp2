namespace PROVA
{
    partial class frmHardware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHardware));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisarHardware = new System.Windows.Forms.Button();
            this.btnSairHardware = new System.Windows.Forms.Button();
            this.btnExcluirHardware = new System.Windows.Forms.Button();
            this.btnAlterarHardware = new System.Windows.Forms.Button();
            this.btnIncluirHardware = new System.Windows.Forms.Button();
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
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnPesquisarHardware
            // 
            this.btnPesquisarHardware.Location = new System.Drawing.Point(323, 31);
            this.btnPesquisarHardware.Name = "btnPesquisarHardware";
            this.btnPesquisarHardware.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarHardware.TabIndex = 16;
            this.btnPesquisarHardware.Text = "Pesquisar";
            this.btnPesquisarHardware.UseVisualStyleBackColor = true;
            // 
            // btnSairHardware
            // 
            this.btnSairHardware.Location = new System.Drawing.Point(323, 284);
            this.btnSairHardware.Name = "btnSairHardware";
            this.btnSairHardware.Size = new System.Drawing.Size(75, 41);
            this.btnSairHardware.TabIndex = 22;
            this.btnSairHardware.Text = "Sair";
            this.btnSairHardware.UseVisualStyleBackColor = true;
            this.btnSairHardware.Click += new System.EventHandler(this.btnSairHardware_Click);
            // 
            // btnExcluirHardware
            // 
            this.btnExcluirHardware.Location = new System.Drawing.Point(225, 284);
            this.btnExcluirHardware.Name = "btnExcluirHardware";
            this.btnExcluirHardware.Size = new System.Drawing.Size(75, 41);
            this.btnExcluirHardware.TabIndex = 20;
            this.btnExcluirHardware.Text = "Excluir";
            this.btnExcluirHardware.UseVisualStyleBackColor = true;
            // 
            // btnAlterarHardware
            // 
            this.btnAlterarHardware.Location = new System.Drawing.Point(124, 284);
            this.btnAlterarHardware.Name = "btnAlterarHardware";
            this.btnAlterarHardware.Size = new System.Drawing.Size(75, 41);
            this.btnAlterarHardware.TabIndex = 19;
            this.btnAlterarHardware.Text = "Alterar";
            this.btnAlterarHardware.UseVisualStyleBackColor = true;
            // 
            // btnIncluirHardware
            // 
            this.btnIncluirHardware.Location = new System.Drawing.Point(22, 284);
            this.btnIncluirHardware.Name = "btnIncluirHardware";
            this.btnIncluirHardware.Size = new System.Drawing.Size(75, 41);
            this.btnIncluirHardware.TabIndex = 18;
            this.btnIncluirHardware.Text = "Incluir";
            this.btnIncluirHardware.UseVisualStyleBackColor = true;
            // 
            // frmHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 336);
            this.Controls.Add(this.btnSairHardware);
            this.Controls.Add(this.btnExcluirHardware);
            this.Controls.Add(this.btnAlterarHardware);
            this.Controls.Add(this.btnIncluirHardware);
            this.Controls.Add(this.btnPesquisarHardware);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHardware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware";
            this.Load += new System.EventHandler(this.frmHardware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisarHardware;
        private System.Windows.Forms.Button btnSairHardware;
        private System.Windows.Forms.Button btnExcluirHardware;
        private System.Windows.Forms.Button btnAlterarHardware;
        private System.Windows.Forms.Button btnIncluirHardware;
    }
}