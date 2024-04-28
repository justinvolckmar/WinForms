
namespace WinForms
{
    public class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Banana", "Apple", "Pear", "Orange", "Kiwi" });
            comboBox1.Location = new Point(53, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 417);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(0, 381);
            button2.Name = "button2";
            button2.Size = new Size(105, 36);
            button2.TabIndex = 5;
            button2.Text = "Load Prev Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 170);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 6;
            label1.Text = "Text: Nothing";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(106, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(327, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 417);
            panel2.TabIndex = 8;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(198, 381);
            button3.Name = "button3";
            button3.Size = new Size(105, 36);
            button3.TabIndex = 13;
            button3.Text = "Load Next Form";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            ClientSize = new Size(642, 441);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Load Images & Output Text";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        /** Swaps the image location of pictureBox1 according to the selection index of the combo box */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Image img = Image.FromFile("../../../bananas.png");

            switch (index)
            {
                case 0: //bananas
                    break;
                case 1: //apple
                    img = Image.FromFile("../../../apple.jpg");
                    break;
                case 2: //pear
                    img = Image.FromFile("../../../pear.jpg");
                    break;
                case 3: //orange
                    img = Image.FromFile("../../../orange.jpg");
                    break;
                case 4: //kiwi
                    img = Image.FromFile("../../../kiwi.jpg");
                    break;
            }
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // update the label text with the textbox contents
        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            if (text == "")
            {
                text = "Nothing";
            }
            label1.Text = "Text: " + text;
        }

        //return to the previous form (selection boxes)
        private void button2_Click(object sender, EventArgs e)
        {
            SelectionBoxes newForm = new SelectionBoxes();
            this.Hide();
            newForm.ShowDialog();
        }

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private TextBox textBox1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //next page
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            this.Hide();
            newForm.ShowDialog();
        }
    }
}
