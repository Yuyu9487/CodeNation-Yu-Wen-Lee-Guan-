using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPrograming1
{
    public partial class MainForm : Form
    {
        private int dotCount = 0;
        private int thinkingStartIndex = 0;
        Game game = new Game();
        public MainForm()
        {
            InitializeComponent();
        }

        //Menu
        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Hide();
            MenuPanel.Show();
            game.endGame();
            socialPlatformPanel.Hide();
            aiChatPanel.Hide();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            btnExit.Show();
            MenuPanel.Hide();
            game.initialize(this, this.components);
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            btnExit.Show();
            MenuPanel.Hide();
            socialPlatformPanel.Show();
        }

        private void btnAIChat_Click(object sender, EventArgs e)
        {
            btnExit.Show();
            MenuPanel.Hide();
            aiChatPanel.Show();
        }

        //social platform
        private void btnPost_Click(object sender, EventArgs e)
        {
            if (btnPost.Enabled)
            {
                MessageBox.Show("Posted: " + btnPost.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!content.Visible) //检测那个content是不是被hide掉 因为一开始就hide掉content 所以当他发现content看不到 一按那个button content就会show出来
            {
                content.Show();
            }
            else
            {
                content.Hide(); //反之如果今天content是看得到的 那就按button content就会hide掉
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                MessageBox.Show("Posted: " + button1.Text);
            }
        }

        //AI chat
        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = rtbUser.Text;
            rtbUser.Text = null;
            rtbDisplay.Text += $"User: {userInput}\n";
            thinkingStartIndex = rtbDisplay.TextLength;

            dotCount = 0;
            timerPlaceHolder.Start();
            timerTyping.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtbUser_TextChanged(object sender, EventArgs e)
        {
            while (string.IsNullOrEmpty(rtbUser.Text))
            {
                btnSend.Enabled = false;
                return;
            }
            btnSend.Enabled = true;
        }

        private void timerPlaceHolder_Tick(object sender, EventArgs e)
        {
            timerPlaceHolder.Stop();
            timerTyping.Stop();
            string aiResponse = "Hello World!";

            rtbDisplay.SelectionStart = thinkingStartIndex;
            rtbDisplay.SelectionLength = rtbDisplay.TextLength - thinkingStartIndex;
            rtbDisplay.SelectedText = $"AI: {aiResponse}\n";
        }

        private void timerTyping_Tick(object sender, EventArgs e)
        {
            dotCount = (dotCount + 1) % 4;

            rtbDisplay.SelectionStart = thinkingStartIndex;
            rtbDisplay.SelectionLength = rtbDisplay.TextLength - thinkingStartIndex;
            rtbDisplay.SelectedText = "AI: Thinking" + new string('.', dotCount) + Environment.NewLine;


            //rtbDisplay.SelectionStart = rtbDisplay.Text.Length;
            //rtbDisplay.ScrollToCaret();

        }
    }
}
