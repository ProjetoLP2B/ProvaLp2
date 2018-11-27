namespace WindowsFormsApplication1
{
    partial class CadastrarHardware
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtModelNumber = new System.Windows.Forms.TextBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.txtDeviceType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(111, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 132);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(78, 23);
            this.btnIncluir.TabIndex = 17;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtModelNumber
            // 
            this.txtModelNumber.Location = new System.Drawing.Point(12, 93);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.Size = new System.Drawing.Size(174, 20);
            this.txtModelNumber.TabIndex = 16;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(12, 27);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(68, 13);
            this.lblDeviceType.TabIndex = 14;
            this.lblDeviceType.Text = "Device Type";
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(9, 77);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(76, 13);
            this.lblModelNumber.TabIndex = 13;
            this.lblModelNumber.Text = "Model Number";
            // 
            // txtDeviceType
            // 
            this.txtDeviceType.Location = new System.Drawing.Point(12, 43);
            this.txtDeviceType.Name = "txtDeviceType";
            this.txtDeviceType.Size = new System.Drawing.Size(174, 20);
            this.txtDeviceType.TabIndex = 11;
            // 
            // CadastrarHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 166);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtModelNumber);
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.txtDeviceType);
            this.Name = "CadastrarHardware";
            this.Text = "CadastrarHardware";
            this.Load += new System.EventHandler(this.CadastrarHardware_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtModelNumber;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.TextBox txtDeviceType;
    }
}