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

namespace KataAccount
{
    public partial class OperationHistories : Form
    {
        ReadWriteFileAccount rwFile;

        bool opHist;
        public OperationHistories()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;          
        }
        private void OperationHistories_Load(object sender, EventArgs e)
        {
            dtgOpHist.DataSource = null;
            tbIdAccount.Text = string.Empty;
            lbSoldeValue.Text = string.Empty;              
        }      
        
        private void chargeOpHistory(string idAccount)
        {
            DataTable dtOpHistories = new DataTable();
            dtOpHistories.Columns.Add("Date", typeof(string));
            dtOpHistories.Columns.Add("Type", typeof(string));
            dtOpHistories.Columns.Add("Montant", typeof(string));
            dtOpHistories.Columns.Add("Solde", typeof(string));

            dtgOpHist.DataSource = dtOpHistories;

            rwFile = new ReadWriteFileAccount(idAccount, TypesOperation.HISTORIQUE.ToString());
            rwFile.readFileAccount(dtOpHistories);                        
        }
        /// <summary>
        /// Methode pour charger les historiques des opérations
        /// </summary>
        public bool getStatementHistories(string idAccount)
        {
            rwFile = new ReadWriteFileAccount(idAccount, TypesOperation.HISTORIQUE.ToString());
            if (!string.IsNullOrEmpty(idAccount))
            {
                if (rwFile.AccountIsExist)
                {
                    chargeOpHistory(idAccount);
                    lbSoldeValue.Text = rwFile.SoldeTot.ToString() + "€";
                    opHist = true;
                }
                else
                {
                    opHist = false;
                }
            }
            else
            {
                opHist = false;
                MessageBox.Show("Merci de saisir le numéro du compte", "ERROR ID_ACCOUNT EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return opHist;
        }

        private void btOpHistory_Click(object sender, EventArgs e)
        {
            getStatementHistories(tbIdAccount.Text.ToString().Trim());
        }
    }
}
