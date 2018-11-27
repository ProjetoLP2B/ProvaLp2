namespace WindowsFormsApplication1
{
    partial class TestCase
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
            this.dvgEnviromental = new System.Windows.Forms.DataGridView();
            this.cmbCadastrareEnviromental = new System.Windows.Forms.ComboBox();
            this.btnCadastrarEnviromental = new System.Windows.Forms.Button();
            this.btnCadastrarInternal = new System.Windows.Forms.Button();
            this.cmbCadastrarInternal = new System.Windows.Forms.ComboBox();
            this.dvgInternal = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblEnviromental = new System.Windows.Forms.Label();
            this.lblInternal = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTesteName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEnviromental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInternal)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEnviromental
            // 
            this.dvgEnviromental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEnviromental.Location = new System.Drawing.Point(12, 154);
            this.dvgEnviromental.Name = "dvgEnviromental";
            this.dvgEnviromental.Size = new System.Drawing.Size(216, 150);
            this.dvgEnviromental.TabIndex = 3;
            // 
            // cmbCadastrareEnviromental
            // 
            this.cmbCadastrareEnviromental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCadastrareEnviromental.FormattingEnabled = true;
            this.cmbCadastrareEnviromental.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "TestHierarchical",
            "TestScaffolding",
            "CUT"});
            this.cmbCadastrareEnviromental.Location = new System.Drawing.Point(12, 327);
            this.cmbCadastrareEnviromental.Name = "cmbCadastrareEnviromental";
            this.cmbCadastrareEnviromental.Size = new System.Drawing.Size(121, 21);
            this.cmbCadastrareEnviromental.TabIndex = 4;
            this.cmbCadastrareEnviromental.SelectedIndexChanged += new System.EventHandler(this.cmbCadastrarTestCase_SelectedIndexChanged);
            // 
            // btnCadastrarEnviromental
            // 
            this.btnCadastrarEnviromental.Location = new System.Drawing.Point(139, 327);
            this.btnCadastrarEnviromental.Name = "btnCadastrarEnviromental";
            this.btnCadastrarEnviromental.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarEnviromental.TabIndex = 5;
            this.btnCadastrarEnviromental.Text = "INCLUIR";
            this.btnCadastrarEnviromental.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarInternal
            // 
            this.btnCadastrarInternal.Location = new System.Drawing.Point(380, 327);
            this.btnCadastrarInternal.Name = "btnCadastrarInternal";
            this.btnCadastrarInternal.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarInternal.TabIndex = 8;
            this.btnCadastrarInternal.Text = "INCLUIR";
            this.btnCadastrarInternal.UseVisualStyleBackColor = true;
            // 
            // cmbCadastrarInternal
            // 
            this.cmbCadastrarInternal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCadastrarInternal.FormattingEnabled = true;
            this.cmbCadastrarInternal.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "TestHierarchical",
            "TestScaffolding",
            "CUT"});
            this.cmbCadastrarInternal.Location = new System.Drawing.Point(253, 327);
            this.cmbCadastrarInternal.Name = "cmbCadastrarInternal";
            this.cmbCadastrarInternal.Size = new System.Drawing.Size(121, 21);
            this.cmbCadastrarInternal.TabIndex = 7;
            // 
            // dvgInternal
            // 
            this.dvgInternal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInternal.Location = new System.Drawing.Point(253, 154);
            this.dvgInternal.Name = "dvgInternal";
            this.dvgInternal.Size = new System.Drawing.Size(216, 150);
            this.dvgInternal.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(355, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // lblEnviromental
            // 
            this.lblEnviromental.AutoSize = true;
            this.lblEnviromental.Location = new System.Drawing.Point(69, 138);
            this.lblEnviromental.Name = "lblEnviromental";
            this.lblEnviromental.Size = new System.Drawing.Size(92, 13);
            this.lblEnviromental.TabIndex = 12;
            this.lblEnviromental.Text = "ENVIROMENTAL";
            // 
            // lblInternal
            // 
            this.lblInternal.AutoSize = true;
            this.lblInternal.Location = new System.Drawing.Point(339, 138);
            this.lblInternal.Name = "lblInternal";
            this.lblInternal.Size = new System.Drawing.Size(61, 13);
            this.lblInternal.TabIndex = 13;
            this.lblInternal.Text = "INTERNAL";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(139, 376);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(201, 39);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblTesteName
            // 
            this.lblTesteName.AutoSize = true;
            this.lblTesteName.Location = new System.Drawing.Point(9, 57);
            this.lblTesteName.Name = "lblTesteName";
            this.lblTesteName.Size = new System.Drawing.Size(65, 13);
            this.lblTesteName.TabIndex = 15;
            this.lblTesteName.Text = "Teste Name";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(183, 57);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 16;
            this.lblClass.Text = "Class";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(352, 57);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(50, 13);
            this.lblPackage.TabIndex = 17;
            this.lblPackage.Text = "Package";
            // 
            // TestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 427);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblTesteName);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblInternal);
            this.Controls.Add(this.lblEnviromental);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCadastrarInternal);
            this.Controls.Add(this.cmbCadastrarInternal);
            this.Controls.Add(this.dvgInternal);
            this.Controls.Add(this.btnCadastrarEnviromental);
            this.Controls.Add(this.cmbCadastrareEnviromental);
            this.Controls.Add(this.dvgEnviromental);
            this.Name = "TestCase";
            this.Text = "TestCase";
            this.Load += new System.EventHandler(this.TestCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEnviromental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInternal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEnviromental;
        private System.Windows.Forms.ComboBox cmbCadastrareEnviromental;
        private System.Windows.Forms.Button btnCadastrarEnviromental;
        private System.Windows.Forms.Button btnCadastrarInternal;
        private System.Windows.Forms.ComboBox cmbCadastrarInternal;
        private System.Windows.Forms.DataGridView dvgInternal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblEnviromental;
        private System.Windows.Forms.Label lblInternal;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblTesteName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblPackage;
    }
}