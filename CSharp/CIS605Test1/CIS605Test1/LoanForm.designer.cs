﻿namespace CIS605Test1
{
    partial class LoanForm
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
            this.grpLoanInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudLoanDuration = new System.Windows.Forms.NumericUpDown();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudLoanAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnTotalLoans = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpLoanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanAmount)).BeginInit();
            this.grpTriggers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoanInfo
            // 
            this.grpLoanInfo.Controls.Add(this.lblTotalInterest);
            this.grpLoanInfo.Controls.Add(this.lblMonthlyPayment);
            this.grpLoanInfo.Controls.Add(this.label6);
            this.grpLoanInfo.Controls.Add(this.label4);
            this.grpLoanInfo.Controls.Add(this.nudLoanDuration);
            this.grpLoanInfo.Controls.Add(this.nudAnnualInterestRate);
            this.grpLoanInfo.Controls.Add(this.nudLoanAmount);
            this.grpLoanInfo.Controls.Add(this.label3);
            this.grpLoanInfo.Controls.Add(this.label2);
            this.grpLoanInfo.Controls.Add(this.label1);
            this.grpLoanInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpLoanInfo.Location = new System.Drawing.Point(12, 28);
            this.grpLoanInfo.Name = "grpLoanInfo";
            this.grpLoanInfo.Size = new System.Drawing.Size(509, 421);
            this.grpLoanInfo.TabIndex = 0;
            this.grpLoanInfo.TabStop = false;
            this.grpLoanInfo.Text = "Loan Info:";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalInterest.Location = new System.Drawing.Point(305, 349);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(187, 42);
            this.lblTotalInterest.TabIndex = 13;
            this.lblTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(305, 286);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(187, 42);
            this.lblMonthlyPayment.TabIndex = 12;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monthly Payment";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Interest";
            // 
            // nudLoanDuration
            // 
            this.nudLoanDuration.Increment = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudLoanDuration.Location = new System.Drawing.Point(305, 198);
            this.nudLoanDuration.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudLoanDuration.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudLoanDuration.Name = "nudLoanDuration";
            this.nudLoanDuration.Size = new System.Drawing.Size(187, 32);
            this.nudLoanDuration.TabIndex = 8;
            this.nudLoanDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLoanDuration.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(305, 127);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(187, 32);
            this.nudAnnualInterestRate.TabIndex = 7;
            this.nudAnnualInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLoanAmount
            // 
            this.nudLoanAmount.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudLoanAmount.Location = new System.Drawing.Point(305, 60);
            this.nudLoanAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLoanAmount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLoanAmount.Name = "nudLoanAmount";
            this.nudLoanAmount.Size = new System.Drawing.Size(187, 32);
            this.nudLoanAmount.TabIndex = 6;
            this.nudLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLoanAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan Duration (Months)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Interest Rate";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount";
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnTotalLoans);
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Controls.Add(this.btnCreate);
            this.grpTriggers.Location = new System.Drawing.Point(57, 455);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(436, 200);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnTotalLoans
            // 
            this.btnTotalLoans.Location = new System.Drawing.Point(6, 84);
            this.btnTotalLoans.Name = "btnTotalLoans";
            this.btnTotalLoans.Size = new System.Drawing.Size(413, 45);
            this.btnTotalLoans.TabIndex = 6;
            this.btnTotalLoans.Text = "&Display Total Number of Loans";
            this.btnTotalLoans.UseVisualStyleBackColor = true;
            this.btnTotalLoans.Click += new System.EventHandler(this.btnTotalLoans_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(223, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(6, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(211, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(413, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create Loan";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // LoanForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(539, 664);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpLoanInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "LoanForm";
            this.Text = "CIS 605 - Test 1";
            this.grpLoanInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanAmount)).EndInit();
            this.grpTriggers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoanInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nudLoanDuration;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.NumericUpDown nudLoanAmount;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTotalLoans;
        private System.Windows.Forms.Label lblTotalInterest;
    }
}

