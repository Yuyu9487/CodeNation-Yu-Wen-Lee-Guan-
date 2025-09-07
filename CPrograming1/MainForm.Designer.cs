namespace CPrograming1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("AI");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("APU", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("coming soon");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("AWS", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.btnPost = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPpl = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.socialPlatformPanel = new System.Windows.Forms.Panel();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnSocial = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnAIChat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.rtbUser = new System.Windows.Forms.RichTextBox();
            this.timerPlaceHolder = new System.Windows.Forms.Timer(this.components);
            this.timerTyping = new System.Windows.Forms.Timer(this.components);
            this.aiChatPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.socialPlatformPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.aiChatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(544, 33);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(82, 34);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Posting";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Noto Sans SC", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(96, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "SEARCHING";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "———";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(14, 72);
            this.content.Name = "content";
            treeNode1.Name = "Node2";
            treeNode1.Text = "AI";
            treeNode2.Name = "Node0";
            treeNode2.Text = "APU";
            treeNode3.Name = "Node0";
            treeNode3.Text = "coming soon";
            treeNode4.Name = "Node1";
            treeNode4.Text = "AWS";
            this.content.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.content.Size = new System.Drawing.Size(137, 507);
            this.content.TabIndex = 6;
            this.content.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.richTextBox5);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.richTextBox4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPpl);
            this.panel1.Location = new System.Drawing.Point(14, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 528);
            this.panel1.TabIndex = 7;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox5.Location = new System.Drawing.Point(20, 768);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(582, 45);
            this.richTextBox5.TabIndex = 29;
            this.richTextBox5.Text = "OMGGGGG!!! LuHan will held a concert in KL soonnnnnn!!!!!!!!!\nWho wants to join w" +
    "ith meeeeeeeee";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 768);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 739);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Public";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 714);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "KL Forum";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 710);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 45);
            this.button6.TabIndex = 25;
            this.button6.Text = "头像";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox4.Location = new System.Drawing.Point(20, 612);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(582, 45);
            this.richTextBox4.TabIndex = 24;
            this.richTextBox4.Text = "Are you boring with the class in university?\nWhy dont you join a club to rich you" +
    "r uni life?!!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 612);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 583);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "APU";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "APU Club Forum";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 554);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 45);
            this.button5.TabIndex = 20;
            this.button5.Text = "头像";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox3.Location = new System.Drawing.Point(18, 427);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(582, 77);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "OMGGGGG!!! Ms Chong is very prettyyyyyyy!!!!!!!!!\nEspecially when she is teaching" +
    " me the C# coding.\nHow could APU have such beautiful lecturer!!!\nCant wait for h" +
    "er class already";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "APU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "APU Gossip Forum";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "头像";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox2.Location = new System.Drawing.Point(20, 250);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(582, 77);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "FYPPPPPPP!!!\nI need powerful lecturer to help me on my Final Year Project.\nDo any" +
    "one plan to do FYP also?\nWe can work togetherrrrrrrr!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "APU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "APU Study Forum";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "头像";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(18, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(584, 64);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Anyone can suggest your favourite Food in APU???\nCome onnnnnn!!! I really need it" +
    "!!\nI cant live without food ^_^";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "APU Relationship Forum";
            // 
            // btnPpl
            // 
            this.btnPpl.Location = new System.Drawing.Point(18, 18);
            this.btnPpl.Name = "btnPpl";
            this.btnPpl.Size = new System.Drawing.Size(53, 45);
            this.btnPpl.TabIndex = 0;
            this.btnPpl.Text = "头像";
            this.btnPpl.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // socialPlatformPanel
            // 
            this.socialPlatformPanel.Controls.Add(this.content);
            this.socialPlatformPanel.Controls.Add(this.panel1);
            this.socialPlatformPanel.Controls.Add(this.button2);
            this.socialPlatformPanel.Controls.Add(this.btnPost);
            this.socialPlatformPanel.Controls.Add(this.button1);
            this.socialPlatformPanel.Location = new System.Drawing.Point(1, 1);
            this.socialPlatformPanel.Name = "socialPlatformPanel";
            this.socialPlatformPanel.Size = new System.Drawing.Size(713, 451);
            this.socialPlatformPanel.TabIndex = 8;
            this.socialPlatformPanel.Visible = false;
            // 
            // btnGame
            // 
            this.btnGame.Font = new System.Drawing.Font("Noto Sans HK", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(30, 23);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(161, 72);
            this.btnGame.TabIndex = 9;
            this.btnGame.Text = "GAME";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnSocial
            // 
            this.btnSocial.Font = new System.Drawing.Font("Noto Sans HK", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocial.Location = new System.Drawing.Point(30, 115);
            this.btnSocial.Name = "btnSocial";
            this.btnSocial.Size = new System.Drawing.Size(161, 72);
            this.btnSocial.TabIndex = 10;
            this.btnSocial.Text = "Social";
            this.btnSocial.UseVisualStyleBackColor = true;
            this.btnSocial.Click += new System.EventHandler(this.btnSocial_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.btnAIChat);
            this.MenuPanel.Controls.Add(this.btnSocial);
            this.MenuPanel.Controls.Add(this.btnGame);
            this.MenuPanel.Location = new System.Drawing.Point(12, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(227, 427);
            this.MenuPanel.TabIndex = 11;
            // 
            // btnAIChat
            // 
            this.btnAIChat.Font = new System.Drawing.Font("Noto Sans HK", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAIChat.Location = new System.Drawing.Point(30, 205);
            this.btnAIChat.Name = "btnAIChat";
            this.btnAIChat.Size = new System.Drawing.Size(161, 72);
            this.btnAIChat.TabIndex = 11;
            this.btnAIChat.Text = "AI Chat";
            this.btnAIChat.UseVisualStyleBackColor = true;
            this.btnAIChat.Click += new System.EventHandler(this.btnAIChat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(671, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(683, 483);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(106, 68);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(36, 44);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(753, 407);
            this.rtbDisplay.TabIndex = 2;
            this.rtbDisplay.Text = "";
            // 
            // rtbUser
            // 
            this.rtbUser.Location = new System.Drawing.Point(36, 483);
            this.rtbUser.Name = "rtbUser";
            this.rtbUser.Size = new System.Drawing.Size(641, 68);
            this.rtbUser.TabIndex = 3;
            this.rtbUser.Text = "";
            this.rtbUser.TextChanged += new System.EventHandler(this.rtbUser_TextChanged);
            // 
            // timerPlaceHolder
            // 
            this.timerPlaceHolder.Interval = 3000;
            this.timerPlaceHolder.Tick += new System.EventHandler(this.timerPlaceHolder_Tick);
            // 
            // timerTyping
            // 
            this.timerTyping.Interval = 300;
            this.timerTyping.Tick += new System.EventHandler(this.timerTyping_Tick);
            // 
            // aiChatPanel
            // 
            this.aiChatPanel.Controls.Add(this.rtbUser);
            this.aiChatPanel.Controls.Add(this.rtbDisplay);
            this.aiChatPanel.Controls.Add(this.btnSend);
            this.aiChatPanel.Location = new System.Drawing.Point(4, 4);
            this.aiChatPanel.Name = "aiChatPanel";
            this.aiChatPanel.Size = new System.Drawing.Size(813, 685);
            this.aiChatPanel.TabIndex = 4;
            this.aiChatPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(712, 610);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.socialPlatformPanel);
            this.Controls.Add(this.aiChatPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.socialPlatformPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.aiChatPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPpl;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel socialPlatformPanel;
        private System.Windows.Forms.Button btnSocial;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnExit;

        //AI Chat
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.RichTextBox rtbUser;
        private System.Windows.Forms.Timer timerPlaceHolder;
        private System.Windows.Forms.Timer timerTyping;
        private System.Windows.Forms.Panel aiChatPanel;
        private System.Windows.Forms.Button btnAIChat;
    }
}

