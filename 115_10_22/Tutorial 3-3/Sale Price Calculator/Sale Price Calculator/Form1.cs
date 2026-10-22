using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice; // 原價
            decimal discountPercentage; // 折扣百分比
            decimal salePrice; // 售價

            originalPrice = decimal.Parse(originalPriceTextBox.Text); // 讀取原價
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text); // 讀取折扣百分比
            salePrice = originalPrice * (1 - discountPercentage / 100); // 計算售價

            salePriceLabel.Text = salePrice.ToString("C"); // 顯示售價
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void originalPricePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
