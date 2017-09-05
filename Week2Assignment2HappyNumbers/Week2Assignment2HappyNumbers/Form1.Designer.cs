namespace Week2Assignment2HappyNumbers
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnHappyList = new System.Windows.Forms.Button();
            this.lblHappyList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(80, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(49, 49);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(159, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test for Happy Number";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnHappyList
            // 
            this.btnHappyList.Location = new System.Drawing.Point(49, 137);
            this.btnHappyList.Name = "btnHappyList";
            this.btnHappyList.Size = new System.Drawing.Size(159, 23);
            this.btnHappyList.TabIndex = 2;
            this.btnHappyList.Text = "List First 8 Happy Numbers";
            this.btnHappyList.UseVisualStyleBackColor = true;
            this.btnHappyList.Click += new System.EventHandler(this.btnHappyList_Click);
            // 
            // lblHappyList
            // 
            this.lblHappyList.AutoSize = true;
            this.lblHappyList.Location = new System.Drawing.Point(46, 100);
            this.lblHappyList.Name = "lblHappyList";
            this.lblHappyList.Size = new System.Drawing.Size(0, 13);
            this.lblHappyList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 185);
            this.Controls.Add(this.lblHappyList);
            this.Controls.Add(this.btnHappyList);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Happy Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnHappyList;
        private System.Windows.Forms.Label lblHappyList;
    }
}

