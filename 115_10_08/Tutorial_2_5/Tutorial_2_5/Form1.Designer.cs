namespace Tutorial_2_5
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
            cardBackpictureBox1 = new PictureBox();
            cardFacepictureBox2 = new PictureBox();
            showBackbutton1 = new Button();
            showFacebutton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)cardBackpictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardFacepictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cardBackpictureBox1
            // 
            cardBackpictureBox1.Image = Properties.Resources.Backface_Red;
            cardBackpictureBox1.Location = new Point(269, 51);
            cardBackpictureBox1.Name = "cardBackpictureBox1";
            cardBackpictureBox1.Size = new Size(181, 271);
            cardBackpictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBackpictureBox1.TabIndex = 0;
            cardBackpictureBox1.TabStop = false;
            cardBackpictureBox1.Click += cardBackpictureBox1_Click;
            // 
            // cardFacepictureBox2
            // 
            cardFacepictureBox2.Image = Properties.Resources.King_Hearts;
            cardFacepictureBox2.Location = new Point(269, 51);
            cardFacepictureBox2.Name = "cardFacepictureBox2";
            cardFacepictureBox2.Size = new Size(181, 271);
            cardFacepictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFacepictureBox2.TabIndex = 1;
            cardFacepictureBox2.TabStop = false;
            cardFacepictureBox2.Visible = false;
            // 
            // showBackbutton1
            // 
            showBackbutton1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showBackbutton1.Location = new Point(119, 350);
            showBackbutton1.Name = "showBackbutton1";
            showBackbutton1.Size = new Size(203, 58);
            showBackbutton1.TabIndex = 2;
            showBackbutton1.Text = "顯示背面";
            showBackbutton1.UseVisualStyleBackColor = true;
            showBackbutton1.Click += showBackbutton1_Click;
            // 
            // showFacebutton2
            // 
            showFacebutton2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showFacebutton2.Location = new Point(404, 350);
            showFacebutton2.Name = "showFacebutton2";
            showFacebutton2.Size = new Size(211, 58);
            showFacebutton2.TabIndex = 3;
            showFacebutton2.Text = "顯示正面";
            showFacebutton2.UseVisualStyleBackColor = true;
            showFacebutton2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showFacebutton2);
            Controls.Add(showBackbutton1);
            Controls.Add(cardFacepictureBox2);
            Controls.Add(cardBackpictureBox1);
            Name = "Form1";
            Text = "撲克牌展示";
            ((System.ComponentModel.ISupportInitialize)cardBackpictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardFacepictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardBackpictureBox1;
        private PictureBox cardFacepictureBox2;
        private Button showBackbutton1;
        private Button showFacebutton2;
    }
}
