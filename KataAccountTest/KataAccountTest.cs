using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataAccount;

namespace KataAccountTest
{
    [TestClass]
    public class KataAccountTest
    {
        OperationForm opForm;
        OperationHistories opHistory;
      
       [TestMethod]
        public void depositAccountTest()
        {
            opForm = new OperationForm("DEPOT");
            opForm.getSolde("TR0001");
            bool resDep = opForm.depositAccount("TR0001", "DEPOT", 300);
            Assert.IsTrue(resDep);         
        }
        [TestMethod]
        public void withdrawAccountTest()
        {
            opForm = new OperationForm("RETRAIT");
            opForm.getSolde("TR0001");
            bool resRet = opForm.withdrawAccount("TR0001", "RETRAIT", 75.5);
            Assert.IsTrue(resRet);
        }
        [TestMethod]
        public void getStatementHistoriesTest()
        {
            opHistory = new OperationHistories();
            bool resHist =  opHistory.getStatementHistories("TR0001");
            Assert.IsTrue(resHist);
        }
    }
}
