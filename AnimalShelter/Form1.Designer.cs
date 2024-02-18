namespace AnimalShelter
{
    partial class Form1
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
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CusDetailPanel = new System.Windows.Forms.Panel();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CusDetailPanel.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(226, 333);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(109, 43);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDetailPanel
            // 
            this.CusDetailPanel.Controls.Add(this.CusIsQualified);
            this.CusDetailPanel.Controls.Add(this.label3);
            this.CusDetailPanel.Controls.Add(this.CusDescription);
            this.CusDetailPanel.Controls.Add(this.label8);
            this.CusDetailPanel.Controls.Add(this.CusAddress);
            this.CusDetailPanel.Controls.Add(this.CusAge);
            this.CusDetailPanel.Controls.Add(this.label128);
            this.CusDetailPanel.Controls.Add(this.label6);
            this.CusDetailPanel.Controls.Add(this.CusFullName);
            this.CusDetailPanel.Controls.Add(this.label2);
            this.CusDetailPanel.Location = new System.Drawing.Point(676, 36);
            this.CusDetailPanel.Name = "CusDetailPanel";
            this.CusDetailPanel.Size = new System.Drawing.Size(385, 391);
            this.CusDetailPanel.TabIndex = 1;
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(167, 183);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(0, 20);
            this.CusIsQualified.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Qualification:";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(167, 236);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(0, 20);
            this.CusDescription.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description:";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(167, 135);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(0, 20);
            this.CusAddress.TabIndex = 7;
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(167, 86);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(0, 20);
            this.CusAge.TabIndex = 6;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(37, 135);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(72, 20);
            this.label128.TabIndex = 5;
            this.label128.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Age:";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(165, 43);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(0, 20);
            this.CusFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.CusNewLastName);
            this.CusNewPanel.Controls.Add(this.CusNewFirstName);
            this.CusNewPanel.Controls.Add(this.label10);
            this.CusNewPanel.Controls.Add(this.label7);
            this.CusNewPanel.Controls.Add(this.label9);
            this.CusNewPanel.Controls.Add(this.label4);
            this.CusNewPanel.Controls.Add(this.label1);
            this.CusNewPanel.Controls.Add(this.CreateCustomer);
            this.CusNewPanel.Location = new System.Drawing.Point(30, 36);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(359, 391);
            this.CusNewPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Birthday:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Description:";
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(110, 27);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(151, 26);
            this.CusNewFirstName.TabIndex = 6;
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(110, 69);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(151, 26);
            this.CusNewLastName.TabIndex = 7;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(110, 154);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(236, 26);
            this.CusNewAddress.TabIndex = 9;
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(110, 112);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(151, 26);
            this.CusNewBirthday.TabIndex = 8;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(110, 196);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(236, 129);
            this.CusNewDescription.TabIndex = 10;
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 20;
            this.CustomerList.Location = new System.Drawing.Point(422, 42);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(221, 384);
            this.CustomerList.TabIndex = 3;
            this.CustomerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 565);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CusDetailPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDetailPanel.ResumeLayout(false);
            this.CusDetailPanel.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel CusDetailPanel;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CusFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CusIsQualified;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel CusNewPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.TextBox CusNewLastName;
        private System.Windows.Forms.TextBox CusNewFirstName;
        private System.Windows.Forms.ListBox CustomerList;
    }
}

