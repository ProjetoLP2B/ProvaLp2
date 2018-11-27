namespace WindowsFormsApplication1
{
    partial class frmCadastrarSoftware
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
            this.txtOS = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSoftwareVersion = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(12, 34);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(195, 20);
            this.txtOS.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 118);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.AutoSize = true;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(9, 68);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(84, 13);
            this.lblSoftwareVersion.TabIndex = 4;
            this.lblSoftwareVersion.Text = "SoftwareVersion";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(12, 18);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(25, 13);
            this.lblOS.TabIndex = 5;
            this.lblOS.Text = "O.S";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(16, 134);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(191, 20);
            this.txtType.TabIndex = 6;
            // 
            // txtSoftwareVersion
            // 
            this.txtSoftwareVersion.Location = new System.Drawing.Point(12, 84);
            this.txtSoftwareVersion.Name = "txtSoftwareVersion";
            this.txtSoftwareVersion.Size = new System.Drawing.Size(195, 20);
            this.txtSoftwareVersion.TabIndex = 7;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(15, 188);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(78, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(132, 188);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmCadastrarSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 229);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtSoftwareVersion);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.lblSoftwareVersion);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtOS);
            this.Name = "frmCadastrarSoftware";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSoftwareVersion;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSoftwareVersion;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
    }
}

