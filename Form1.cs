namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global
        private int lastVal = 50;
        private int score = 0;
        private int streak = 0; //resets on wrong guess

        /** LOWER, earn points based on current streak if new value is lower */
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int val = (int)(100.0 * rnd.NextDouble());
            label2.Text = val.ToString();

            if (val < lastVal)
            {
                if (streak < 0)
                {
                    streak = 1;
                }
                else
                {
                    streak++;
                }
                score += streak;
                label4.Text = "+" + streak.ToString();
                label4.ForeColor = Color.Green;
            }
            else
            {
                if (streak > 0)
                {
                    streak = -1;
                }
                else
                {
                    streak--;
                }
                score += streak;
                label4.Text = streak.ToString();
                label4.ForeColor = Color.Red;
            }
            label3.Text = "Score: " + score.ToString();
            lastVal = val;
        }

        /** HIGHER, earn points based on current streak if new value is higher */
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int val = (int)(100.0 * rnd.NextDouble());
            label2.Text = val.ToString();

            if (val > lastVal)
            {
                if (streak < 0)
                {
                    streak = 1;
                }
                else
                {
                    streak++;
                }
                score += streak;
                label4.Text = "+" + streak.ToString();
                label4.ForeColor = Color.Green;
            }
            else
            {
                if (streak > 0)
                {
                    streak = -1;
                }
                else
                {
                    streak--;
                }
                score += streak;
                label4.Text = streak.ToString();
                label4.ForeColor = Color.Red;
            }
            label3.Text = "Score: " + score.ToString();
            lastVal = val;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Load next page (selection boxes)
        private void button3_Click(object sender, EventArgs e)
        {
            SelectionBoxes newForm = new SelectionBoxes();
            this.Hide();
            newForm.ShowDialog();
        }
    }
}
