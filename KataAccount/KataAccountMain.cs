using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace KataAccount
{
    public partial class KataAccountMain : Form
    {
        OperationForm opForm;
        OperationHistories opHist = new OperationHistories();
        private string opType = string.Empty;

        public string OpType
        {
            get
            {
                return opType;
            }

            set
            {
                opType = value;
            }
        }     

        public KataAccountMain()
        {
            InitializeComponent(); 
            string imgFilename = Path.Combine(Application.StartupPath, @"..\..\Data\BankAccountImg.png");
            Image myBgImage = Image.FromFile(imgFilename);
            this.BackgroundImage = myBgImage;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;          
        }      
       
        private void depot_Click(object sender, EventArgs e)
        {
            opType = TypesOperation.DEPOT.ToString();
            opForm = new OperationForm(opType);
            opForm.ShowDialog();
        }
        private void retrait_Click(object sender, EventArgs e)
        {
            opType = TypesOperation.RETRAIT.ToString();
            opForm = new OperationForm(opType);
            opForm.ShowDialog();          
        }
        private void quitter_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void historique_Click(object sender, EventArgs e)
        {
          opHist.ShowDialog();            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BANK ACCOUNT KATA Application\n\n  © By Fadel Donatien 2020", "BANK ACCOUNT KATA", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
