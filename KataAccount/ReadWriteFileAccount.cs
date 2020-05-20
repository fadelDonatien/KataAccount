using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace KataAccount
{
    class ReadWriteFileAccount
    {
        string idFile = string.Empty;        
        double soldeTot;

        public double SoldeTot
        {
            get
            {
                return soldeTot;
            }
            set
            {
                soldeTot = value;
            }
        }

        string fileAccountPath = string.Empty;
        public string FileAccountPath
        {
            get
            {
                return fileAccountPath;
            }

            set
            {
                fileAccountPath = value;
            }
        }

        bool accountIsExist;
        public bool AccountIsExist
        {
            get
            {
                return accountIsExist;
            }

            set
            {
                accountIsExist = value;
            }
        }       

        public ReadWriteFileAccount(string idBankAccout, string typeOp = "DEPOT")
        {
            idFile = idBankAccout;
            fileAccountPath = Path.GetFullPath(idFile + "_bankAccountHistory.txt");
            if(cheeckAccount())
            {
                accountIsExist = true;
                getSoldeTotalFromFileAccount();
            }
            else  // Si le compte n'existe pas encore
            {
                if(typeOp == TypesOperation.DEPOT.ToString())
                {
                    var resultChoice = MessageBox.Show("Le compte " + idFile + " n'existe pas. Voulez-vous le créer ? ", "ACCOUNT NOT FOUND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultChoice == DialogResult.Yes) //Si on accepte, on créer le nouveau compte afin de pouvoir faire un dépot
                    {
                        using (File.CreateText(fileAccountPath)){};
                        accountIsExist = true;
                    }
                    else
                    {
                        accountIsExist = false;
                    }
                } 
               else if (typeOp == TypesOperation.RETRAIT.ToString() || typeOp == TypesOperation.HISTORIQUE.ToString()) 
                {
                   accountIsExist = false;
                   MessageBox.Show("Le retrait ou consultation de l'historique se fait uniquement avec un compte existant ", "ACCOUNT NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }

        /// <summary>
        /// Vérifier si le compte éxiste déjà ou non
        /// </summary>
        /// <returns></returns>
        private bool cheeckAccount()
        {
          return File.Exists(fileAccountPath) ? true : false;
        }
        /// <summary>
        /// Recupérer le solde total d'un compte donné
        /// </summary>
        public void getSoldeTotalFromFileAccount()
        {           
            using (StreamWriter sw = (File.Exists(fileAccountPath)) ? File.AppendText(fileAccountPath) : File.CreateText(fileAccountPath)){};
            if(new FileInfo(fileAccountPath).Length != 0) //Check if file is not empty 
            {
              if(!IsFileLocked(fileAccountPath))
               {
                 var lines = File.ReadLines(fileAccountPath);
                 string lastLine = lines.Last();
                 string[] lastLineTab = lastLine.Split(';');
                 for (int i = 0; i < lastLineTab.Length; i++)
                  {
                    if (i == lastLineTab.Length - 1)
                     {
                      soldeTot = double.Parse(lastLineTab[i]);
                     }
                  }
               }                    
            }
            else
            {
              soldeTot = 0;
            }                 
        }       

        /// <summary>
        /// Ecrir les mouvements des opérations effectués
        /// </summary>
        /// <param name="sbHistory"></param>
        public void ecrireFichierAccount(StringBuilder sbHistory)
        {                  
            using (StreamWriter writeStat = File.AppendText(FileAccountPath))  
            {
              writeStat.WriteLine(sbHistory);
            }             
        }

        /// <summary>
        /// Methode pour lire le fichier pour charger l'historique
        /// </summary>
        /// <param name="dataTableHist"></param>
        public void readFileAccount(DataTable dataTableHist)
        {               
            string[] lignes = File.ReadAllLines(fileAccountPath);
            if (lignes.Length > 0)
            {
                string[] lineValue;

                for (int i = 0; i < lignes.Length; i++)
                {
                    lineValue = lignes[i].ToString().Split(';');
                    string[] columnValue = new string[lineValue.Length];

                    for (int j = 0; j < lineValue.Length; j++)
                    {
                        columnValue[j] = lineValue[j].Trim();
                    }
                    dataTableHist.Rows.Add(columnValue);
                }
            }
            else
            {
                MessageBox.Show("Le compte '" + idFile + "' n'a pas encore fait des opérations", "NO OPERATION ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Verifier si le ficher est en cours d'utilisation 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool IsFileLocked(string filename)
        {
            bool locked = false;
            try
            {
                FileStream fileAccount =  File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                fileAccount.Close();
            }
            catch (IOException e)
            {
                locked = true;
                MessageBox.Show(" File " + filename + " used by other process","FILE USED",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            return locked;
        }
    }
}
