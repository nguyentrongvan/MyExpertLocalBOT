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
            this.header = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.createbot_btn = new System.Windows.Forms.Button();
            this.convesation_btn = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.sub_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.quit_btn = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
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
            this.title.Location = new System.Drawing.Point(93, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(863, 61);
            this.title.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(84, 74);
            this.logo.TabIndex = 0;
            // 
            // createbot_btn
            // 
            this.createbot_btn.Location = new System.Drawing.Point(13, 70);
            this.createbot_btn.Name = "createbot_btn";
            this.createbot_btn.Size = new System.Drawing.Size(177, 68);
            this.createbot_btn.TabIndex = 1;
            this.createbot_btn.Text = "Create Bot";
            this.createbot_btn.UseVisualStyleBackColor = true;
            this.createbot_btn.Click += new System.EventHandler(this.createbot_btn_Click);
            // 
            // convesation_btn
            // 
            this.convesation_btn.Location = new System.Drawing.Point(13, 175);
            this.convesation_btn.Name = "convesation_btn";
            this.convesation_btn.Size = new System.Drawing.Size(177, 68);
            this.convesation_btn.TabIndex = 2;
            this.convesation_btn.Text = "Conversation";
            this.convesation_btn.UseVisualStyleBackColor = true;
            this.convesation_btn.Click += new System.EventHandler(this.convesation_btn_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.quit_btn);
            this.menu_panel.Controls.Add(this.convesation_btn);
            this.menu_panel.Controls.Add(this.createbot_btn);
            this.menu_panel.Location = new System.Drawing.Point(2, 86);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(213, 513);
            this.menu_panel.TabIndex = 3;
            // 
            // sub_panel
            // 
            this.sub_panel.Location = new System.Drawing.Point(222, 86);
            this.sub_panel.Name = "sub_panel";
            this.sub_panel.Size = new System.Drawing.Size(214, 513);
            this.sub_panel.TabIndex = 4;
            // 
            // main_panel
            // 
            this.main_panel.Location = new System.Drawing.Point(443, 87);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(512, 512);
            this.main_panel.TabIndex = 5;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(13, 282);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(177, 68);
            this.quit_btn.TabIndex = 3;
            this.quit_btn.Text = "Quit";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(962, 606);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.sub_panel);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Expert ChatBOT";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.header.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
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
    }
}

