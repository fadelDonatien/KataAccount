namespace KataAccount
{
    partial class OperationForm
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
            this.lbAccountID = new System.Windows.Forms.Label();
            this.tbIdAccount = new System.Windows.Forms.TextBox();
            this.soldeAmount = new System.Windows.Forms.Label();
            this.tbMontant = new System.Windows.Forms.TextBox();
            this.depotAmount = new System.Windows.Forms.Label();
            this.tbSolde = new System.Windows.Forms.TextBox();
            this.btCredit = new System.Windows.Forms.Button();
            this.btCancelCredit = new System.Windows.Forms.Button();
            this.lbOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Location = new System.Drawing.Point(14, 49);
            this.lbAccountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(69, 16);
            this.lbAccountID.TabIndex = 0;
            this.lbAccountID.Text = "ID compte";
            // 
            // tbIdAccount
            // 
            this.tbIdAccount.Location = new System.Drawing.Point(101, 41);
            this.tbIdAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIdAccount.Name = "tbIdAccount";
            this.tbIdAccount.Size = new System.Drawing.Size(175, 21);
            this.tbIdAccount.TabIndex = 1;
            // 
            // soldeAmount
            // 
            this.soldeAmount.AutoSize = true;
            this.soldeAmount.Location = new System.Drawing.Point(14, 141);
            this.soldeAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soldeAmount.Name = "soldeAmount";
            this.soldeAmount.Size = new System.Drawing.Size(44, 16);
            this.soldeAmount.TabIndex = 2;
            this.soldeAmount.Text = "Solde";
            // 
            // tbMontant
            // 
            this.tbMontant.Location = new System.Drawing.Point(101, 86);
            this.tbMontant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.Size = new System.Drawing.Size(175, 21);
            this.tbMontant.TabIndex = 3;
            // 
            // depotAmount
            // 
            this.depotAmount.AutoSize = true;
            this.depotAmount.Location = new System.Drawing.Point(14, 94);
            this.depotAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depotAmount.Name = "depotAmount";
            this.depotAmount.Size = new System.Drawing.Size(55, 16);
            this.depotAmount.TabIndex = 4;
            this.depotAmount.Text = "Montant";
            // 
            // tbSolde
            // 
            this.tbSolde.Location = new System.Drawing.Point(101, 132);
            this.tbSolde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSolde.Name = "tbSolde";
            this.tbSolde.Size = new System.Drawing.Size(175, 21);
            this.tbSolde.TabIndex = 5;
            // 
            // btCredit
            // 
            this.btCredit.Location = new System.Drawing.Point(18, 187);
            this.btCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCredit.Name = "btCredit";
            this.btCredit.Size = new System.Drawing.Size(88, 26);
            this.btCredit.TabIndex = 6;
            this.btCredit.Text = "OK";
            this.btCredit.UseVisualStyleBackColor = true;
            this.btCredit.Click += new System.EventHandler(this.btCredit_Click);
            // 
            // btCancelCredit
            // 
            this.btCancelCredit.Location = new System.Drawing.Point(188, 187);
            this.btCancelCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelCredit.Name = "btCancelCredit";
            this.btCancelCredit.Size = new System.Drawing.Size(88, 26);
            this.btCancelCredit.TabIndex = 7;
            this.btCancelCredit.Text = "Annuler";
            this.btCancelCredit.UseVisualStyleBackColor = true;
            this.btCancelCredit.Click += new System.EventHandler(this.btCancelCredit_Click);
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Location = new System.Drawing.Point(136, 15);
            this.lbOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(0, 16);
            this.lbOperation.TabIndex = 8;
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 228);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.btCancelCredit);
            this.Controls.Add(this.btCredit);
            this.Controls.Add(this.tbSolde);
            this.Controls.Add(this.depotAmount);
            this.Controls.Add(this.tbMontant);
            this.Controls.Add(this.soldeAmount);
            this.Controls.Add(this.tbIdAccount);
            this.Controls.Add(this.lbAccountID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OperationForm";
            this.Text = "Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountID;
        private System.Windows.Forms.TextBox tbIdAccount;
        private System.Windows.Forms.Label soldeAmount;
        private System.Windows.Forms.TextBox tbMontant;
        private System.Windows.Forms.Label depotAmount;
        private System.Windows.Forms.TextBox tbSolde;
        private System.Windows.Forms.Button btCredit;
        private System.Windows.Forms.Button btCancelCredit;
        private System.Windows.Forms.Label lbOperation;
    }
}