namespace ChatbotGUI
{
    partial class ConversationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversationView));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.quit_btn = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.Botnam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainChat = new System.Windows.Forms.RichTextBox();
            this.sub_panel = new System.Windows.Forms.Panel();
            this.listViewBot = new System.Windows.Forms.ListView();
            this.main_title = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.main_panel.SuspendLayout();
            this.sub_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.logo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightCyan;
            this.menu_panel.Controls.Add(this.pictureBox2);
            this.menu_panel.Controls.Add(this.quit_btn);
            this.menu_panel.Location = new System.Drawing.Point(6, 91);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(213, 513);
            this.menu_panel.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.MintCream;
            this.quit_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.ForeColor = System.Drawing.Color.Crimson;
            this.quit_btn.Location = new System.Drawing.Point(18, 84);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(177, 68);
            this.quit_btn.TabIndex = 3;
            this.quit_btn.Text = "Back to menu";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Azure;
            this.main_panel.Controls.Add(this.Botnam);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.send_btn);
            this.main_panel.Controls.Add(this.inputBox);
            this.main_panel.Controls.Add(this.chatPanel);
            this.main_panel.Controls.Add(this.mainChat);
            this.main_panel.Location = new System.Drawing.Point(447, 92);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(512, 512);
            this.main_panel.TabIndex = 8;
            // 
            // Botnam
            // 
            this.Botnam.AutoSize = true;
            this.Botnam.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botnam.Location = new System.Drawing.Point(69, 18);
            this.Botnam.Name = "Botnam";
            this.Botnam.Size = new System.Drawing.Size(367, 25);
            this.Botnam.TabIndex = 5;
            this.Botnam.Text = "Choose your BOT to start the conversation";
            this.Botnam.Click += new System.EventHandler(this.Botnam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "BOT:";
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.Honeydew;
            this.send_btn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.send_btn.Location = new System.Drawing.Point(443, 440);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(60, 57);
            this.send_btn.TabIndex = 2;
            this.send_btn.Text = "➤";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(15, 439);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(421, 58);
            this.inputBox.TabIndex = 1;
            this.inputBox.Text = "";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatPanel.ForeColor = System.Drawing.Color.MintCream;
            this.chatPanel.Location = new System.Drawing.Point(28, 67);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(463, 355);
            this.chatPanel.TabIndex = 6;
            this.chatPanel.WrapContents = false;
            this.chatPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chatPanel_Paint);
            // 
            // mainChat
            // 
            this.mainChat.Location = new System.Drawing.Point(15, 56);
            this.mainChat.Name = "mainChat";
            this.mainChat.Size = new System.Drawing.Size(488, 377);
            this.mainChat.TabIndex = 0;
            this.mainChat.Text = "";
            this.mainChat.TextChanged += new System.EventHandler(this.mainChat_TextChanged);
            // 
            // sub_panel
            // 
            this.sub_panel.BackColor = System.Drawing.Color.LightCyan;
            this.sub_panel.Controls.Add(this.listViewBot);
            this.sub_panel.Location = new System.Drawing.Point(226, 91);
            this.sub_panel.Name = "sub_panel";
            this.sub_panel.Size = new System.Drawing.Size(214, 513);
            this.sub_panel.TabIndex = 7;
            // 
            // listViewBot
            // 
            this.listViewBot.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBot.HideSelection = false;
            this.listViewBot.Location = new System.Drawing.Point(18, 84);
            this.listViewBot.Name = "listViewBot";
            this.listViewBot.Size = new System.Drawing.Size(178, 414);
            this.listViewBot.TabIndex = 3;
            this.listViewBot.UseCompatibleStateImageBehavior = false;
            this.listViewBot.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewBot_ItemSelectionChanged);
            // 
            // main_title
            // 
            this.main_title.AllowDrop = true;
            this.main_title.AutoSize = true;
            this.main_title.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.main_title.Location = new System.Drawing.Point(93, 21);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(546, 39);
            this.main_title.TabIndex = 2;
            this.main_title.Text = "My Expert Local Chatbot";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.DarkCyan;
            this.title.Location = new System.Drawing.Point(0, 72);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(953, 5);
            this.title.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MintCream;
            this.header.Controls.Add(this.main_title);
            this.header.Controls.Add(this.title);
            this.header.Controls.Add(this.logo);
            this.header.Location = new System.Drawing.Point(6, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(956, 80);
            this.header.TabIndex = 9;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.MintCream;
            this.logo.Controls.Add(this.pictureBox1);
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(84, 74);
            this.logo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 63);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tools";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(226, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 63);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "All your BOTs";
            // 
            // ConversationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.sub_panel);
            this.Name = "ConversationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConversationView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConversationView_Load);
            this.menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.sub_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.logo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel sub_panel;
        private System.Windows.Forms.RichTextBox mainChat;
        private System.Windows.Forms.ListView listViewBot;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label Botnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}