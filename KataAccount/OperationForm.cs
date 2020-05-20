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
    public partial class OperationForm : Form
    {
        Operation op;
        Statement st;
        ReadWriteFileAccount rwAcc;
        bool operationOK;
        double solde;

        public double Solde
        {
            get
            {
                return solde;
            }

            set
            {
                solde = value;
            }
        }
        public string OpTypeForm
        {
            get
            {
                return opTypeForm;
            }

            set
            {
                opTypeForm = value;
            }
        }

        public bool OperationOK
        {
            get
            {
                return operationOK;
            }

            set
            {
                operationOK = value;
            }
        }

        string opTypeForm = string.Empty;
      //  string idBankAccount = string.Empty;
      
        public OperationForm(string operationType)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lbOperation.Text = operationType;
            lbOperation.Font = new Font(lbOperation.Font.Name,12, FontStyle.Bold);
            opTypeForm = operationType;
           // idBankAccount = tbIdAccount.Text.Trim();        
            tbSolde.Enabled = false;                 
        }

        public double getSolde(string idAccount)
        {
            rwAcc = new ReadWriteFileAccount(idAccount, opTypeForm);
            rwAcc.getSoldeTotalFromFileAccount();           
            return solde = rwAcc.SoldeTot;
        }
        /// <summary>
        /// Methode pour le dépot
        /// </summary>
        /// <param name="id"></param>
        /// <param name="typeOp"></param>
        /// <param name="montantCred"></param>
        public bool depositAccount(string id, string typeOp,  double montantCred)
       {          
            try
            {
                solde += montantCred;
                op = new Operation(id, typeOp, DateTime.Now, solde);
                st = new Statement(op, montantCred);
                operationOK = true;
            }
            catch(Exception e)
            {
                operationOK = false;
                MessageBox.Show(e.Message,"DEPOSIT ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return operationOK;
       }        
        /// <summary>
        /// Methode pour faire le retrait
        /// </summary>
        /// <param name="typeOp"></param>
        /// <param name="montantRetr"></param>
        public bool withdrawAccount(string idAcc, string typeOp, double montantRetr)
        {
          try
           {             
             if((solde > 0) && (solde >= montantRetr)) // Voir si le compte contient suffisament de sous 
             {
               solde -= montantRetr;
               op = new Operation(idAcc, typeOp, DateTime.Now, solde);
               st = new Statement(op, montantRetr);
               operationOK = true;
             }
             else
             {
               operationOK = false;
               MessageBox.Show("Insuffisant de solde dans le compte ou le montant de retrait " + montantRetr  + "€ est supérieur au solde " + solde  + "€ restant","WITHDRAW ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }
            }
          catch(Exception e)
          {
             operationOK = false;
             MessageBox.Show(e.Message,"WITHDRAW FUNCTION ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
          }
            return operationOK;
       }       

        private void btCredit_Click(object sender, EventArgs e)
        {
            double resultMontant;
            if(!string.IsNullOrEmpty(tbIdAccount.Text.ToString().Trim()))
            {
              if(double.TryParse(tbMontant.Text.Trim(), out resultMontant))
              {
                    rwAcc = new ReadWriteFileAccount(tbIdAccount.Text.ToString().Trim(), opTypeForm);
                    if (rwAcc.AccountIsExist)
                    {
                        if (opTypeForm == TypesOperation.DEPOT.ToString())
                        {
                            getSolde(tbIdAccount.Text.Trim()).ToString();
                            depositAccount(tbIdAccount.Text.Trim(), opTypeForm, resultMontant);
                            tbSolde.Text = solde.ToString();

                            if (OperationOK)
                                MessageBox.Show("Le dépot d'une somme de " + resultMontant + "€ a bien été effectué", "DEPOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            getSolde(tbIdAccount.Text.Trim()).ToString();                          
                            withdrawAccount(tbIdAccount.Text.Trim(), opTypeForm, resultMontant);
                            tbSolde.Text = solde.ToString();

                            if (OperationOK)
                                MessageBox.Show("Le retrait d'une somme de " + resultMontant + "€ a bien été effectué", "RETRAIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
              else
                {
                    MessageBox.Show("Merci de saisir le montant en chiffre ", "ERROR AMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            } 
            else
            {
                MessageBox.Show("Merci de saisir le numéro de compte ", "ERROR ID_ACCOUNT EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                 
        }

        private void btCancelCredit_Click(object sender, EventArgs e)
        {
            tbIdAccount.Text = string.Empty;
            tbMontant.Text = string.Empty;
            tbSolde.Text = string.Empty;
        }
    }
}
