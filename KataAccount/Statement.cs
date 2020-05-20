using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KataAccount
{
    class Statement
    {
        private readonly Operation operation;
        private readonly double currentStatement;
        
        public Statement(Operation op, double  currentStat)
        {
            if (string.IsNullOrEmpty(op.ToString()))
                throw new ArgumentException("Operation can't be null");

            operation = op;
            currentStatement = currentStat;
            printStatement();
        }
        public void printStatement()
        {           
            StringBuilder sb = new StringBuilder();           
            sb.Append(operation.getDateOperation());
            sb.Append(";");
            sb.Append(operation.getTypeOperation());           
            sb.Append(";");
            sb.Append(currentStatement);
            sb.Append(";");
            sb.Append(operation.getAmountOperation());

            ReadWriteFileAccount rwFileAccount = new ReadWriteFileAccount(operation.IdAccount);
            rwFileAccount.ecrireFichierAccount(sb);                   
        }
    }
}
