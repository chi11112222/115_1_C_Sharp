namespace Tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cardBackpictureBox1.Visible = false;
            cardFacepictureBox2.Visible = true;
        }

        private void showBackbutton1_Click(object sender, EventArgs e)
        {
            cardBackpictureBox1.Visible = true;
            cardFacepictureBox2.Visible = false;
        }

        private void cardBackpictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
