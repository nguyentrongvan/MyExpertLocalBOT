namespace ChatbotGUI
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.header = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createbot_btn = new System.Windows.Forms.Button();
            this.convesation_btn = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.quit_btn = new System.Windows.Forms.Button();
            this.sub_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MintCream;
            this.header.Controls.Add(this.main_title);
            this.header.Controls.Add(this.title);
            this.header.Controls.Add(this.logo);
            this.header.Location = new System.Drawing.Point(-1, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(956, 80);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.DarkCyan;
            this.title.Location = new System.Drawing.Point(0, 72);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(953, 5);
            this.title.TabIndex = 1;
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
            // createbot_btn
            // 
            this.createbot_btn.BackColor = System.Drawing.Color.MintCream;
            this.createbot_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbot_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.createbot_btn.Location = new System.Drawing.Point(13, 92);
            this.createbot_btn.Name = "createbot_btn";
            this.createbot_btn.Size = new System.Drawing.Size(177, 68);
            this.createbot_btn.TabIndex = 1;
            this.createbot_btn.Text = "Create BOT";
            this.createbot_btn.UseVisualStyleBackColor = false;
            this.createbot_btn.Click += new System.EventHandler(this.createbot_btn_Click);
            // 
            // convesation_btn
            // 
            this.convesation_btn.BackColor = System.Drawing.Color.MintCream;
            this.convesation_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convesation_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.convesation_btn.Location = new System.Drawing.Point(13, 166);
            this.convesation_btn.Name = "convesation_btn";
            this.convesation_btn.Size = new System.Drawing.Size(177, 68);
            this.convesation_btn.TabIndex = 2;
            this.convesation_btn.Text = "Conversation";
            this.convesation_btn.UseVisualStyleBackColor = false;
            this.convesation_btn.Click += new System.EventHandler(this.convesation_btn_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightCyan;
            this.menu_panel.Controls.Add(this.quit_btn);
            this.menu_panel.Controls.Add(this.convesation_btn);
            this.menu_panel.Controls.Add(this.createbot_btn);
            this.menu_panel.Controls.Add(this.panel1);
            this.menu_panel.Location = new System.Drawing.Point(2, 86);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(213, 513);
            this.menu_panel.TabIndex = 3;
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.MintCream;
            this.quit_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.ForeColor = System.Drawing.Color.Crimson;
            this.quit_btn.Location = new System.Drawing.Point(13, 240);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(177, 68);
            this.quit_btn.TabIndex = 3;
            this.quit_btn.Text = "Quit App";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // sub_panel
            // 
            this.sub_panel.BackColor = System.Drawing.Color.LightCyan;
            this.sub_panel.Location = new System.Drawing.Point(222, 86);
            this.sub_panel.Name = "sub_panel";
            this.sub_panel.Size = new System.Drawing.Size(214, 513);
            this.sub_panel.TabIndex = 4;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Azure;
            this.main_panel.Controls.Add(this.pictureBox2);
            this.main_panel.Location = new System.Drawing.Point(443, 87);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(512, 512);
            this.main_panel.TabIndex = 5;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tools";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 63);
            this.panel1.TabIndex = 5;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 198);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 609);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.sub_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Expert ChatBOT";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button createbot_btn;
        private System.Windows.Forms.Button convesation_btn;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel sub_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

