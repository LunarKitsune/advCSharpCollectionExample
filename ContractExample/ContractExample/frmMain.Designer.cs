namespace ContractExample
{
    partial class frmMain
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
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnRemoveContract = new System.Windows.Forms.Button();
            this.btnDisplayTotal = new System.Windows.Forms.Button();
            this.btnDisplayContract = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtFindByID = new System.Windows.Forms.TextBox();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.txtIDCollection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(384, 24);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(92, 55);
            this.btnAddContract.TabIndex = 0;
            this.btnAddContract.Text = "Add";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.BtnAddContract_Click);
            // 
            // btnRemoveContract
            // 
            this.btnRemoveContract.Location = new System.Drawing.Point(384, 103);
            this.btnRemoveContract.Name = "btnRemoveContract";
            this.btnRemoveContract.Size = new System.Drawing.Size(92, 55);
            this.btnRemoveContract.TabIndex = 1;
            this.btnRemoveContract.Text = "Remove";
            this.btnRemoveContract.UseVisualStyleBackColor = true;
            this.btnRemoveContract.Click += new System.EventHandler(this.BtnRemoveContract_Click);
            // 
            // btnDisplayTotal
            // 
            this.btnDisplayTotal.Location = new System.Drawing.Point(384, 176);
            this.btnDisplayTotal.Name = "btnDisplayTotal";
            this.btnDisplayTotal.Size = new System.Drawing.Size(92, 55);
            this.btnDisplayTotal.TabIndex = 2;
            this.btnDisplayTotal.Text = "Total Amount";
            this.btnDisplayTotal.UseVisualStyleBackColor = true;
            this.btnDisplayTotal.Click += new System.EventHandler(this.BtnDisplayTotal_Click);
            // 
            // btnDisplayContract
            // 
            this.btnDisplayContract.Location = new System.Drawing.Point(384, 252);
            this.btnDisplayContract.Name = "btnDisplayContract";
            this.btnDisplayContract.Size = new System.Drawing.Size(92, 55);
            this.btnDisplayContract.TabIndex = 3;
            this.btnDisplayContract.Text = "Display Contracts";
            this.btnDisplayContract.UseVisualStyleBackColor = true;
            this.btnDisplayContract.Click += new System.EventHandler(this.BtnDisplayContract_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(384, 329);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(92, 55);
            this.btnExitApp.TabIndex = 4;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contract Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Find:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(117, 138);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 12;
            // 
            // txtFindByID
            // 
            this.txtFindByID.Location = new System.Drawing.Point(117, 236);
            this.txtFindByID.Name = "txtFindByID";
            this.txtFindByID.Size = new System.Drawing.Size(100, 20);
            this.txtFindByID.TabIndex = 14;
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.Location = new System.Drawing.Point(117, 180);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(200, 20);
            this.dtpContractDate.TabIndex = 15;
            // 
            // txtIDCollection
            // 
            this.txtIDCollection.FormattingEnabled = true;
            this.txtIDCollection.Location = new System.Drawing.Point(117, 57);
            this.txtIDCollection.Name = "txtIDCollection";
            this.txtIDCollection.Size = new System.Drawing.Size(121, 21);
            this.txtIDCollection.TabIndex = 16;
            this.txtIDCollection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyOnly_KeyEvent);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.txtIDCollection);
            this.Controls.Add(this.dtpContractDate);
            this.Controls.Add(this.txtFindByID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnDisplayContract);
            this.Controls.Add(this.btnDisplayTotal);
            this.Controls.Add(this.btnRemoveContract);
            this.Controls.Add(this.btnAddContract);
            this.Name = "frmMain";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnRemoveContract;
        private System.Windows.Forms.Button btnDisplayTotal;
        private System.Windows.Forms.Button btnDisplayContract;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtFindByID;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.ComboBox txtIDCollection;
    }
}

