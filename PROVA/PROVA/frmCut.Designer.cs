namespace PROVA
{
    partial class frmCut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCut));
            this.btnSairCUT = new System.Windows.Forms.Button();
            this.btnExcluirCUT = new System.Windows.Forms.Button();
            this.btnAlterarCUT = new System.Windows.Forms.Button();
            this.btnIncluirCUT = new System.Windows.Forms.Button();
            this.btnPesquisarCUT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSairCUT
            // 
            this.btnSairCUT.Location = new System.Drawing.Point(325, 274);
            this.btnSairCUT.Name = "btnSairCUT";
            this.btnSairCUT.Size = new System.Drawing.Size(75, 41);
            this.btnSairCUT.TabIndex = 29;
            this.btnSairCUT.Text = "Sair";
            this.btnSairCUT.UseVisualStyleBackColor = true;
            this.btnSairCUT.Click += new System.EventHandler(this.btnSairCUT_Click);
            // 
            // btnExcluirCUT
            // 
            this.btnExcluirCUT.Location = new System.Drawing.Point(227, 274);
            this.btnExcluirCUT.Name = "btnExcluirCUT";
            this.btnExcluirCUT.Size = new System.Drawing.Size(75, 41);
            this.btnExcluirCUT.TabIndex = 28;
            this.btnExcluirCUT.Text = "Excluir";
            this.btnExcluirCUT.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCUT
            // 
            this.btnAlterarCUT.Location = new System.Drawing.Point(126, 274);
            this.btnAlterarCUT.Name = "btnAlterarCUT";
            this.btnAlterarCUT.Size = new System.Drawing.Size(75, 41);
            this.btnAlterarCUT.TabIndex = 27;
            this.btnAlterarCUT.Text = "Alterar";
            this.btnAlterarCUT.UseVisualStyleBackColor = true;
            // 
            // btnIncluirCUT
            // 
            this.btnIncluirCUT.Location = new System.Drawing.Point(24, 274);
            this.btnIncluirCUT.Name = "btnIncluirCUT";
            this.btnIncluirCUT.Size = new System.Drawing.Size(75, 41);
            this.btnIncluirCUT.TabIndex = 26;
            this.btnIncluirCUT.Text = "Incluir";
            this.btnIncluirCUT.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarCUT
            // 
            this.btnPesquisarCUT.Location = new System.Drawing.Point(325, 21);
            this.btnPesquisarCUT.Name = "btnPesquisarCUT";
            this.btnPesquisarCUT.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCUT.TabIndex = 25;
            this.btnPesquisarCUT.Text = "Pesquisar";
            this.btnPesquisarCUT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 176);
            this.dataGridView1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 23;
            // 
            // frmCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 336);
            this.Controls.Add(this.btnSairCUT);
            this.Controls.Add(this.btnExcluirCUT);
            this.Controls.Add(this.btnAlterarCUT);
            this.Controls.Add(this.btnIncluirCUT);
            this.Controls.Add(this.btnPesquisarCUT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairCUT;
        private System.Windows.Forms.Button btnExcluirCUT;
        private System.Windows.Forms.Button btnAlterarCUT;
        private System.Windows.Forms.Button btnIncluirCUT;
        private System.Windows.Forms.Button btnPesquisarCUT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}