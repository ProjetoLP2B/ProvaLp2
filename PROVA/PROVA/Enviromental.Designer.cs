namespace WindowsFormsApplication1
{
    partial class Enviromental
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
            this.lblHardware = new System.Windows.Forms.Label();
            this.cmbHardware = new System.Windows.Forms.ComboBox();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.cmbSoftware = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Location = new System.Drawing.Point(12, 57);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(53, 13);
            this.lblHardware.TabIndex = 1;
            this.lblHardware.Text = "Hardware";
            // 
            // cmbHardware
            // 
            this.cmbHardware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHardware.FormattingEnabled = true;
            this.cmbHardware.Location = new System.Drawing.Point(15, 73);
            this.cmbHardware.Name = "cmbHardware";
            this.cmbHardware.Size = new System.Drawing.Size(187, 21);
            this.cmbHardware.TabIndex = 2;
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Location = new System.Drawing.Point(12, 110);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(49, 13);
            this.lblSoftware.TabIndex = 3;
            this.lblSoftware.Text = "Software";
            // 
            // cmbSoftware
            // 
            this.cmbSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoftware.FormattingEnabled = true;
            this.cmbSoftware.Location = new System.Drawing.Point(15, 126);
            this.cmbSoftware.Name = "cmbSoftware";
            this.cmbSoftware.Size = new System.Drawing.Size(187, 21);
            this.cmbSoftware.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 172);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(127, 172);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(36, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(166, 20);
            this.txtID.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // Enviromental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 216);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbSoftware);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.cmbHardware);
            this.Controls.Add(this.lblHardware);
            this.Name = "Enviromental";
            this.Text = "Enviromental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.ComboBox cmbHardware;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.ComboBox cmbSoftware;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}