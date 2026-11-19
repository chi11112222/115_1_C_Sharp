using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            totalLabel.Text = "—";
            discountLabe1.Text = "—";
            feedbackLabel.Text = "";

            if (int.TryParse(daysTextBox.Text, out int days))
            {
                if (days >= 1 && days <= 7)
                {
                    int dailyRate;
                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    int discount;
                    string discountMessage;
                    if (clubCheckBox.Checked)
                    {
                        if (days >= 3)
                        {
                            discount = 30;
                            discountMessage = "折抵 30 元";
                        }
                        else
                        {
                            discount = 0;
                            discountMessage = "未達折抵門檻";
                        }
                    }
                    else
                    {
                        discount = 0;
                        discountMessage = "無優惠";
                    }

                    dailyRateLabel.Text = dailyRate.ToString() + " 元";
                    discountLabe1.Text = discountMessage;
                    totalLabel.Text = (days * dailyRate - discount).ToString() + " 元";
                }
                else
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void dailyRateCaptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalCaptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysTextBox.Text = "";
            clubCheckBox.Checked = false;
            feedbackLabel.Text = "";
            dailyRateLabel.Text = "—";
            discountLabe1.Text = "—";
            totalLabel.Text = "—";
        }
    }
}
