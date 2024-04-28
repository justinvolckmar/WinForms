namespace WinForms
{
    public class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            turnBox = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)turnBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 121);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(131, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 121);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(259, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 121);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(3, 130);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(122, 121);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(131, 130);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(122, 121);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(259, 130);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(122, 121);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(3, 257);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(122, 121);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Location = new Point(131, 257);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(122, 121);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Location = new Point(259, 257);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(122, 121);
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(169, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 382);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 10;
            label1.Text = "Tic Tac Toe";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 11;
            label2.Text = "Current Turn: ";
            label2.Click += label2_Click;
            // 
            // turnBox
            // 
            turnBox.Location = new Point(98, 29);
            turnBox.Name = "turnBox";
            turnBox.Size = new Size(56, 56);
            turnBox.TabIndex = 12;
            turnBox.TabStop = false;
            turnBox.Click += turnBox_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 373);
            button2.Name = "button2";
            button2.Size = new Size(105, 36);
            button2.TabIndex = 13;
            button2.Text = "Load Prev Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 117);
            button1.Name = "button1";
            button1.Size = new Size(105, 36);
            button1.TabIndex = 14;
            button1.Text = "Reset Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            ClientSize = new Size(564, 423);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(turnBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "No Opponent Tic Tac Toe";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)turnBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private int checkWinner()
        {
            //check wins [hor]
            if (board[0] == board[1] && board[1] == board[2] && board[0] == currentTurn)
            {
                return currentTurn;
            }
            else if (board[3] == board[4] && board[4] == board[5] && board[3] == currentTurn)
            {
                return currentTurn;
            }
            else if (board[6] == board[7] && board[7] == board[8] && board[6] == currentTurn)
            {
                return currentTurn;
            }//check wins [ver]
            else if (board[0] == board[3] && board[3] == board[6] && board[0] == currentTurn)
            {
                return currentTurn;
            }
            else if (board[1] == board[4] && board[4] == board[7] && board[1] == currentTurn)
            {
                return currentTurn;
            }
            else if (board[2] == board[5] && board[5] == board[8] && board[2] == currentTurn)
            {
                return currentTurn;
            }//check wins [diag]
            else if (board[0] == board[4] && board[4] == board[8] && board[0] == currentTurn)
            {
                return currentTurn;
            }
            else if (board[2] == board[4] && board[4] == board[6] && board[2] == currentTurn)
            {
                return currentTurn;
            }//CATS
            else if (board[0] >= 0 && board[1] >= 0 && board[2] >= 0
                && board[3] >= 0 && board[4] >= 0 && board[5] >= 0
                && board[6] >= 0 && board[7] >= 0 && board[8] >= 0) {
                var win = MessageBox.Show("Nobody won! CATs game!");
            }

            //else return no win found
            return -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (board[0] == -1)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[0] = 0;
                    pictureBox1.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[0] = 1;
                    pictureBox1.BackgroundImage = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox1]");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (board[1] == -1)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[1] = 0;
                    pictureBox2.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[1] = 1;
                    pictureBox2.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox2]");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (board[2] == -1)
            {
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[2] = 0;
                    pictureBox3.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[2] = 1;
                    pictureBox3.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox3]");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (board[3] == -1)
            {
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[3] = 0;
                    pictureBox4.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[3] = 1;
                    pictureBox4.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox4]");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (board[4] == -1)
            {
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[4] = 0;
                    pictureBox5.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[4] = 1;
                    pictureBox5.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox5]");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (board[5] == -1)
            {
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[5] = 0;
                    pictureBox6.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[5] = 1;
                    pictureBox6.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox6]");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (board[6] == -1)
            {
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[6] = 0;
                    pictureBox7.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[6] = 1;
                    pictureBox7.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox7]");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (board[7] == -1)
            {
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[7] = 0;
                    pictureBox8.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[7] = 1;
                    pictureBox8.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox8]");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (board[8] == -1)
            {
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                if (currentTurn == 0) //O
                {
                    board[8] = 0;
                    pictureBox9.Image = Image.FromFile("../../../o.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("O's have won!");
                        clearBoard();
                    }
                    currentTurn = 1;
                    turnBox.Image = Image.FromFile("../../../x.png");
                }
                else //X
                {
                    board[8] = 1;
                    pictureBox9.Image = Image.FromFile("../../../x.png");
                    if (checkWinner() == currentTurn)
                    {
                        var win = MessageBox.Show("X's have won!");
                        clearBoard();
                    }
                    currentTurn = 0;
                    turnBox.Image = Image.FromFile("../../../o.png");
                }
            }
            else
            {
                Console.WriteLine("Space already occupied. [pictureBox9]");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = -1;
            }
            turnBox.Image = Image.FromFile("../../../o.png");
            turnBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void turnBox_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox turnBox;
        private PictureBox pictureBox9;
        private Button button2;

        private int[] board = new int[9];
        private Button button1;
        private int currentTurn = 0; //0 == O, 1 == X

        //go back to previous form
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            this.Hide();
            newForm.ShowDialog();
        }

        //clear the current game board
        private void clearBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = -1;
            }
            turnBox.Image = Image.FromFile("../../../o.png");
            turnBox.SizeMode = PictureBoxSizeMode.StretchImage;

            currentTurn = 0;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearBoard();
        }
    }
}