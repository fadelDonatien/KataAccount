namespace KataAccount
{
    partial class OperationHistories
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
            this.dtgOpHist = new System.Windows.Forms.DataGridView();
            this.btOpHistory = new System.Windows.Forms.Button();
            this.lbOpHist = new System.Windows.Forms.Label();
            this.lbIdAccount = new System.Windows.Forms.Label();
            this.tbIdAccount = new System.Windows.Forms.TextBox();
            this.lbSoldeHist = new System.Windows.Forms.Label();
            this.lbSoldeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpHist)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOpHist
            // 
            this.dtgOpHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOpHist.Location = new System.Drawing.Point(3, 72);
            this.dtgOpHist.Name = "dtgOpHist";
            this.dtgOpHist.Size = new System.Drawing.Size(449, 191);
            this.dtgOpHist.TabIndex = 0;
            // 
            // btOpHistory
            // 
            this.btOpHistory.Location = new System.Drawing.Point(167, 269);
            this.btOpHistory.Name = "btOpHistory";
            this.btOpHistory.Size = new System.Drawing.Size(86, 23);
            this.btOpHistory.TabIndex = 1;
            this.btOpHistory.Text = "OK";
            this.btOpHistory.UseVisualStyleBackColor = true;
            this.btOpHistory.Click += new System.EventHandler(this.btOpHistory_Click);
            // 
            // lbOpHist
            // 
            this.lbOpHist.AutoSize = true;
            this.lbOpHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpHist.Location = new System.Drawing.Point(113, 9);
            this.lbOpHist.Name = "lbOpHist";
            this.lbOpHist.Size = new System.Drawing.Size(215, 25);
            this.lbOpHist.TabIndex = 2;
            this.lbOpHist.Text = "Operation Histories";
            // 
            // lbIdAccount
            // 
            this.lbIdAccount.AutoSize = true;
            this.lbIdAccount.Location = new System.Drawing.Point(12, 46);
            this.lbIdAccount.Name = "lbIdAccount";
            this.lbIdAccount.Size = new System.Drawing.Size(59, 13);
            this.lbIdAccount.TabIndex = 3;
            this.lbIdAccount.Text = "Id Account";
            // 
            // tbIdAccount
            // 
            this.tbIdAccount.Location = new System.Drawing.Point(77, 46);
            this.tbIdAccount.Name = "tbIdAccount";
            this.tbIdAccount.Size = new System.Drawing.Size(147, 20);
            this.tbIdAccount.TabIndex = 4;
            // 
            // lbSoldeHist
            // 
            this.lbSoldeHist.AutoSize = true;
            this.lbSoldeHist.Location = new System.Drawing.Point(294, 46);
            this.lbSoldeHist.Name = "lbSoldeHist";
            this.lbSoldeHist.Size = new System.Drawing.Size(34, 13);
            this.lbSoldeHist.TabIndex = 5;
            this.lbSoldeHist.Text = "Solde";
            // 
            // lbSoldeValue
            // 
            this.lbSoldeValue.AutoSize = true;
            this.lbSoldeValue.Location = new System.Drawing.Point(365, 46);
            this.lbSoldeValue.Name = "lbSoldeValue";
            this.lbSoldeValue.Size = new System.Drawing.Size(0, 13);
            this.lbSoldeValue.TabIndex = 6;
            // 
            // OperationHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 304);
            this.Controls.Add(this.lbSoldeValue);
            this.Controls.Add(this.lbSoldeHist);
            this.Controls.Add(this.tbIdAccount);
            this.Controls.Add(this.lbIdAccount);
            this.Controls.Add(this.lbOpHist);
            this.Controls.Add(this.btOpHistory);
            this.Controls.Add(this.dtgOpHist);
            this.Name = "OperationHistories";
            this.Text = "Operation Histories";
            this.Load += new System.EventHandler(this.OperationHistories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOpHist;
        private System.Windows.Forms.Button btOpHistory;
        private System.Windows.Forms.Label lbOpHist;
        private System.Windows.Forms.Label lbIdAccount;
        private System.Windows.Forms.TextBox tbIdAccount;
        private System.Windows.Forms.Label lbSoldeHist;
        private System.Windows.Forms.Label lbSoldeValue;
    }
}