namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string message = txtString1.Text == txtString2.Text
                ? "兩個字串相同。"
                : "兩個字串不同。";

            MessageBox.Show(message, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string strinagl, string2;

            strinagl = txtString1.Text;
            string2 = txtString2.Text;

            if (String.Compare(strinagl, string2) == 0)
            {
                MessageBox.Show("兩個字串相同。");
            }
            else if (String.Compare(strinagl, string2) < 0)
            {
                MessageBox.Show($"{string1} 小於 {strinag2}");
            }
            else
            {
                MessageBox.Show(strinagl + " 大於 " + string2);
            }
        }

        private void txtString1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
