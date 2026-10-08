namespace Tutorial_2_4
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FinalandpictureBox1 = new PictureBox();
            FrancepictureBox2 = new PictureBox();
            GermanypictureBox3 = new PictureBox();
            countrylabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)FinalandpictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrancepictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GermanypictureBox3).BeginInit();
            SuspendLayout();
            // 
            // FinalandpictureBox1
            // 
            FinalandpictureBox1.Image = (Image)resources.GetObject("FinalandpictureBox1.Image");
            FinalandpictureBox1.Location = new Point(12, 101);
            FinalandpictureBox1.Name = "FinalandpictureBox1";
            FinalandpictureBox1.Size = new Size(224, 168);
            FinalandpictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            FinalandpictureBox1.TabIndex = 0;
            FinalandpictureBox1.TabStop = false;
            FinalandpictureBox1.Click += pictureBox1_Click;
            // 
            // FrancepictureBox2
            // 
            FrancepictureBox2.Image = (Image)resources.GetObject("FrancepictureBox2.Image");
            FrancepictureBox2.Location = new Point(277, 101);
            FrancepictureBox2.Name = "FrancepictureBox2";
            FrancepictureBox2.Size = new Size(234, 168);
            FrancepictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            FrancepictureBox2.TabIndex = 1;
            FrancepictureBox2.TabStop = false;
            FrancepictureBox2.Click += France_Click;
            // 
            // GermanypictureBox3
            // 
            GermanypictureBox3.Image = (Image)resources.GetObject("GermanypictureBox3.Image");
            GermanypictureBox3.Location = new Point(554, 101);
            GermanypictureBox3.Name = "GermanypictureBox3";
            GermanypictureBox3.Size = new Size(224, 168);
            GermanypictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            GermanypictureBox3.TabIndex = 2;
            GermanypictureBox3.TabStop = false;
            GermanypictureBox3.Click += pictureBox3_Click;
            // 
            // countrylabel
            // 
            countrylabel.BorderStyle = BorderStyle.Fixed3D;
            countrylabel.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            countrylabel.Location = new Point(277, 321);
            countrylabel.Name = "countrylabel";
            countrylabel.Size = new Size(225, 89);
            countrylabel.TabIndex = 3;
            countrylabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 42);
            label1.Name = "label1";
            label1.Size = new Size(298, 23);
            label1.TabIndex = 4;
            label1.Text = "點選一個國旗，我告訴你是哪個國家";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(countrylabel);
            Controls.Add(GermanypictureBox3);
            Controls.Add(FrancepictureBox2);
            Controls.Add(FinalandpictureBox1);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)FinalandpictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrancepictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)GermanypictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FinalandpictureBox1;
        private PictureBox FrancepictureBox2;
        private PictureBox GermanypictureBox3;
        private Label countrylabel;
        private Label label1;
    }
}
