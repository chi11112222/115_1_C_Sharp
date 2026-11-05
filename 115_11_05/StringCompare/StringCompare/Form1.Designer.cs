namespace StringCompare
{
    partial class Form1
    {
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblString1 = new Label();
            lblString2 = new Label();
            txtString1 = new TextBox();
            txtString2 = new TextBox();
            btnCompare = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblString1
            // 
            lblString1.AutoSize = true;
            lblString1.Location = new Point(45, 48);
            lblString1.Name = "lblString1";
            lblString1.Size = new Size(56, 23);
            lblString1.TabIndex = 0;
            lblString1.Text = "字串1";
            // 
            // lblString2
            // 
            lblString2.AutoSize = true;
            lblString2.Location = new Point(45, 98);
            lblString2.Name = "lblString2";
            lblString2.Size = new Size(56, 23);
            lblString2.TabIndex = 1;
            lblString2.Text = "字串2";
            // 
            // txtString1
            // 
            txtString1.Location = new Point(125, 43);
            txtString1.Name = "txtString1";
            txtString1.Size = new Size(260, 30);
            txtString1.TabIndex = 2;
            txtString1.TextChanged += txtString1_TextChanged;
            // 
            // txtString2
            // 
            txtString2.Location = new Point(125, 93);
            txtString2.Name = "txtString2";
            txtString2.Size = new Size(260, 30);
            txtString2.TabIndex = 3;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(125, 150);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(100, 35);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "比較";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(285, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 230);
            Controls.Add(btnExit);
            Controls.Add(btnCompare);
            Controls.Add(txtString2);
            Controls.Add(txtString1);
            Controls.Add(lblString2);
            Controls.Add(lblString1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "字串比較";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
