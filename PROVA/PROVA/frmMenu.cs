using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hARDWAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHardware objHardware = new frmHardware();
            objHardware.MdiParent = this;
            objHardware.Show();
        }

        private void sOFTWAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoftware objSoftware = new frmSoftware();
            objSoftware.MdiParent = this;
            objSoftware.Show();
        }

        private void tESTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTesteScaffolding objTeste = new frmTesteScaffolding();
            objTeste.MdiParent = this;
            objTeste.Show();
        }

        

        private void cASEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmTeste objTeste = new frmTeste();
            objTeste.MdiParent = this;
            objTeste.Show();
        }

       
        private void sCAFFOLDINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTesteScaffolding objTesteSc = new frmTesteScaffolding();
            objTesteSc.MdiParent = this;
            objTesteSc.Show();
        }

        private void hIERARCHICALToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmTesteHierarchical objTesteHi = new frmTesteHierarchical();
            objTesteHi.MdiParent = this;
            objTesteHi.Show();
        }

        private void cUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCut objCUT = new frmCut();
            objCUT.MdiParent = this;
            objCUT.Show();
        }
    }
}
