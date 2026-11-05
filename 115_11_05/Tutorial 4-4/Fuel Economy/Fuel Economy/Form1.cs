using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km; // 儲存行駛公里數
            double liters; // 儲存使用汽油公升數
            double kmpl; // 儲存每公升汽油行駛公里數

            //km = double.Parse(kmTextBox.Text); // 取得使用者輸入的形式公里數
            //liters = double.Parse(literTextBox.Text); // 取得使用者輸入的使用汽油公升數
            if (double.TryParse(kmTextBox.Text, out km))
            {
                if (double.TryParse(literTextBox.Text, out liters))
                {
                    if (km > 0 && liters > 0)
                    {
                        kmpl = km / liters; // 計算每公升汽油行駛公里數
                        kmplLabel.Text = kmpl.ToString("F2") + " 公里/公升";
                    }
                    else
                    {
                        MessageBox.Show("公里數和汽油公升數必須大於零。");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的汽油公升數。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的公里數。");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void milesPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mpgLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
