namespace WindowsFormsApplication1
{
    partial class Internal
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbTestScaffolding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCUT = new System.Windows.Forms.ComboBox();
            this.lblCUT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(50, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(166, 20);
            this.txtID.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(141, 186);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(26, 186);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cmbTestScaffolding
            // 
            this.cmbTestScaffolding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestScaffolding.FormattingEnabled = true;
            this.cmbTestScaffolding.Location = new System.Drawing.Point(26, 135);
            this.cmbTestScaffolding.Name = "cmbTestScaffolding";
            this.cmbTestScaffolding.Size = new System.Drawing.Size(187, 21);
            this.cmbTestScaffolding.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Test Scaffolding";
            // 
            // cmbCUT
            // 
            this.cmbCUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCUT.FormattingEnabled = true;
            this.cmbCUT.Location = new System.Drawing.Point(26, 71);
            this.cmbCUT.Name = "cmbCUT";
            this.cmbCUT.Size = new System.Drawing.Size(187, 21);
            this.cmbCUT.TabIndex = 10;
            // 
            // lblCUT
            // 
            this.lblCUT.AutoSize = true;
            this.lblCUT.Location = new System.Drawing.Point(23, 55);
            this.lblCUT.Name = "lblCUT";
            this.lblCUT.Size = new System.Drawing.Size(29, 13);
            this.lblCUT.TabIndex = 9;
            this.lblCUT.Text = "CUT";
            // 
            // Internal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 217);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbTestScaffolding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCUT);
            this.Controls.Add(this.lblCUT);
            this.Name = "Internal";
            this.Text = "Internal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbTestScaffolding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCUT;
        private System.Windows.Forms.Label lblCUT;
    }
}