using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAccount
{
    class Operation
    {
        private readonly string opType;
	    private readonly DateTime opDate;
	    private readonly double opAmount;
        private readonly string idAccount;

        public string IdAccount
        {
            get
            {
                return idAccount;
            }
        }

        public Operation(string idAccount,string typeOp, DateTime dateOp, double montantOp)
        {
            if (string.IsNullOrEmpty(dateOp.ToString()))
                throw new ArgumentException("Date can't be null");
            if (string.IsNullOrEmpty(typeOp.ToString()))
                throw new ArgumentException("Type opération can't be null");

            this.idAccount = idAccount;
            opType = typeOp;
            opDate = dateOp;
            opAmount = montantOp;
        }

        public string getIdAccountOperation()
        {
            return IdAccount;
        }
        public string getTypeOperation()
        {
            return opType;
        }

        public DateTime getDateOperation()
        {
            return opDate;
        }

        public double getAmountOperation()
        {
            return opAmount;
        }
    }
}
