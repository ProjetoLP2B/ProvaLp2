namespace PROVA
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hARDWAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOFTWAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cASEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCAFFOLDINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIERARCHICALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hARDWAREToolStripMenuItem,
            this.sOFTWAREToolStripMenuItem,
            this.tESTEToolStripMenuItem,
            this.cUTToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hARDWAREToolStripMenuItem
            // 
            this.hARDWAREToolStripMenuItem.Name = "hARDWAREToolStripMenuItem";
            this.hARDWAREToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.hARDWAREToolStripMenuItem.Text = "HARDWARE";
            this.hARDWAREToolStripMenuItem.Click += new System.EventHandler(this.hARDWAREToolStripMenuItem_Click);
            // 
            // sOFTWAREToolStripMenuItem
            // 
            this.sOFTWAREToolStripMenuItem.Name = "sOFTWAREToolStripMenuItem";
            this.sOFTWAREToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.sOFTWAREToolStripMenuItem.Text = "SOFTWARE";
            this.sOFTWAREToolStripMenuItem.Click += new System.EventHandler(this.sOFTWAREToolStripMenuItem_Click);
            // 
            // tESTEToolStripMenuItem
            // 
            this.tESTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cASEToolStripMenuItem,
            this.sCAFFOLDINGToolStripMenuItem,
            this.hIERARCHICALToolStripMenuItem});
            this.tESTEToolStripMenuItem.Name = "tESTEToolStripMenuItem";
            this.tESTEToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tESTEToolStripMenuItem.Text = "TESTE";
            // 
            // cASEToolStripMenuItem
            // 
            this.cASEToolStripMenuItem.Name = "cASEToolStripMenuItem";
            this.cASEToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cASEToolStripMenuItem.Text = "CASE";
            this.cASEToolStripMenuItem.Click += new System.EventHandler(this.cASEToolStripMenuItem_Click_1);
            // 
            // sCAFFOLDINGToolStripMenuItem
            // 
            this.sCAFFOLDINGToolStripMenuItem.Name = "sCAFFOLDINGToolStripMenuItem";
            this.sCAFFOLDINGToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sCAFFOLDINGToolStripMenuItem.Text = "SCAFFOLDING";
            this.sCAFFOLDINGToolStripMenuItem.Click += new System.EventHandler(this.sCAFFOLDINGToolStripMenuItem_Click);
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.cUTToolStripMenuItem.Text = "CUT";
            this.cUTToolStripMenuItem.Click += new System.EventHandler(this.cUTToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // hIERARCHICALToolStripMenuItem
            // 
            this.hIERARCHICALToolStripMenuItem.Name = "hIERARCHICALToolStripMenuItem";
            this.hIERARCHICALToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hIERARCHICALToolStripMenuItem.Text = "HIERARCHICAL";
            this.hIERARCHICALToolStripMenuItem.Click += new System.EventHandler(this.hIERARCHICALToolStripMenuItem_Click_2);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROVA.Properties.Resources.Logo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 436);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hARDWAREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOFTWAREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cASEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCAFFOLDINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIERARCHICALToolStripMenuItem;
    }
}

