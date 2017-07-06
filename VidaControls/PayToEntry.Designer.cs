namespace VidaControls
{
    partial class PayToEntry
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbPayTo = new System.Windows.Forms.TextBox();
            this.lbPayees = new System.Windows.Forms.ListBox();
            this.tbDueDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAPR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalOwed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinimumPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndelete = new System.Windows.Forms.Button();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay To Name";
            // 
            // tbPayTo
            // 
            this.tbPayTo.Location = new System.Drawing.Point(17, 31);
            this.tbPayTo.Name = "tbPayTo";
            this.tbPayTo.Size = new System.Drawing.Size(100, 20);
            this.tbPayTo.TabIndex = 1;
            // 
            // lbPayees
            // 
            this.lbPayees.FormattingEnabled = true;
            this.lbPayees.Location = new System.Drawing.Point(17, 84);
            this.lbPayees.Name = "lbPayees";
            this.lbPayees.Size = new System.Drawing.Size(652, 95);
            this.lbPayees.TabIndex = 0;
            this.lbPayees.TabStop = false;
            this.lbPayees.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbPayees_DrawItem);
            // 
            // tbDueDate
            // 
            this.tbDueDate.Location = new System.Drawing.Point(123, 31);
            this.tbDueDate.Name = "tbDueDate";
            this.tbDueDate.Size = new System.Drawing.Size(100, 20);
            this.tbDueDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Day Of Month Due";
            // 
            // tbAPR
            // 
            this.tbAPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbAPR.Location = new System.Drawing.Point(229, 31);
            this.tbAPR.Name = "tbAPR";
            this.tbAPR.Size = new System.Drawing.Size(100, 20);
            this.tbAPR.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "APR";
            // 
            // tbTotalOwed
            // 
            this.tbTotalOwed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbTotalOwed.Location = new System.Drawing.Point(335, 31);
            this.tbTotalOwed.Name = "tbTotalOwed";
            this.tbTotalOwed.Size = new System.Drawing.Size(100, 20);
            this.tbTotalOwed.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Owed";
            // 
            // tbMinimumPayment
            // 
            this.tbMinimumPayment.Location = new System.Drawing.Point(441, 31);
            this.tbMinimumPayment.Name = "tbMinimumPayment";
            this.tbMinimumPayment.Size = new System.Drawing.Size(100, 20);
            this.tbMinimumPayment.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Minimum Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ex. AMEX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ex. 10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ex. 12.7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ex. 500.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ex. 25.00";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(675, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(675, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(675, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(582, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndelete
            // 
            this.btnUndelete.Location = new System.Drawing.Point(675, 113);
            this.btnUndelete.Name = "btnUndelete";
            this.btnUndelete.Size = new System.Drawing.Size(75, 23);
            this.btnUndelete.TabIndex = 8;
            this.btnUndelete.Text = "Undelete";
            this.btnUndelete.UseVisualStyleBackColor = true;
            this.btnUndelete.Click += new System.EventHandler(this.btnUndelete_Click);
            // 
            // cbAccounts
            // 
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(548, 31);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(121, 21);
            this.cbAccounts.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Account Type";
            // 
            // PayToEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.btnUndelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMinimumPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTotalOwed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAPR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPayees);
            this.Controls.Add(this.tbPayTo);
            this.Controls.Add(this.label1);
            this.Name = "PayToEntry";
            this.Size = new System.Drawing.Size(765, 220);
            this.Load += new System.EventHandler(this.PayToEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPayTo;
        private System.Windows.Forms.ListBox lbPayees;
        private System.Windows.Forms.TextBox tbDueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAPR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalOwed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinimumPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndelete;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Label label11;
    }
}
