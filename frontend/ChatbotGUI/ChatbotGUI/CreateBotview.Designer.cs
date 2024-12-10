namespace ChatbotGUI
{
    partial class CreateBotview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBotview));
            this.upload_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.source_panel = new System.Windows.Forms.Panel();
            this.botSource = new System.Windows.Forms.RichTextBox();
            this.source_lb = new System.Windows.Forms.Label();
            this.name_panel = new System.Windows.Forms.Panel();
            this.botName = new System.Windows.Forms.RichTextBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Panel();
            this.botid = new System.Windows.Forms.RichTextBox();
            this.id_lb = new System.Windows.Forms.Label();
            this.sub_panel = new System.Windows.Forms.Panel();
            this.listViewBot = new System.Windows.Forms.ListView();
            this.main_title = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.createResult = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.source_panel.SuspendLayout();
            this.name_panel.SuspendLayout();
            this.id_label.SuspendLayout();
            this.sub_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.logo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // upload_btn
            // 
            this.upload_btn.BackColor = System.Drawing.Color.MintCream;
            this.upload_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.upload_btn.Location = new System.Drawing.Point(21, 80);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(167, 71);
            this.upload_btn.TabIndex = 0;
            this.upload_btn.Text = "Upload Files";
            this.upload_btn.UseVisualStyleBackColor = false;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.MintCream;
            this.quit_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.ForeColor = System.Drawing.Color.Crimson;
            this.quit_btn.Location = new System.Drawing.Point(21, 157);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(167, 80);
            this.quit_btn.TabIndex = 1;
            this.quit_btn.Text = "Back to menu";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightCyan;
            this.menu_panel.Controls.Add(this.pictureBox2);
            this.menu_panel.Controls.Add(this.panel2);
            this.menu_panel.Controls.Add(this.quit_btn);
            this.menu_panel.Controls.Add(this.upload_btn);
            this.menu_panel.Location = new System.Drawing.Point(7, 90);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(213, 513);
            this.menu_panel.TabIndex = 6;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Azure;
            this.main_panel.Controls.Add(this.createResult);
            this.main_panel.Controls.Add(this.button1);
            this.main_panel.Controls.Add(this.source_panel);
            this.main_panel.Controls.Add(this.name_panel);
            this.main_panel.Controls.Add(this.id_label);
            this.main_panel.Location = new System.Drawing.Point(448, 91);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(512, 512);
            this.main_panel.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(367, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save BOT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // source_panel
            // 
            this.source_panel.Controls.Add(this.botSource);
            this.source_panel.Controls.Add(this.source_lb);
            this.source_panel.Location = new System.Drawing.Point(29, 286);
            this.source_panel.Name = "source_panel";
            this.source_panel.Size = new System.Drawing.Size(456, 163);
            this.source_panel.TabIndex = 2;
            // 
            // botSource
            // 
            this.botSource.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botSource.Location = new System.Drawing.Point(16, 38);
            this.botSource.Name = "botSource";
            this.botSource.Size = new System.Drawing.Size(418, 110);
            this.botSource.TabIndex = 5;
            this.botSource.Text = "";
            this.botSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.botSource_KeyDown);
            // 
            // source_lb
            // 
            this.source_lb.AutoSize = true;
            this.source_lb.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_lb.Location = new System.Drawing.Point(11, 5);
            this.source_lb.Name = "source_lb";
            this.source_lb.Size = new System.Drawing.Size(129, 30);
            this.source_lb.TabIndex = 4;
            this.source_lb.Text = "Bot\'s source:";
            // 
            // name_panel
            // 
            this.name_panel.Controls.Add(this.botName);
            this.name_panel.Controls.Add(this.name_lb);
            this.name_panel.Location = new System.Drawing.Point(29, 177);
            this.name_panel.Name = "name_panel";
            this.name_panel.Size = new System.Drawing.Size(456, 90);
            this.name_panel.TabIndex = 1;
            // 
            // botName
            // 
            this.botName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botName.Location = new System.Drawing.Point(16, 46);
            this.botName.Name = "botName";
            this.botName.Size = new System.Drawing.Size(418, 34);
            this.botName.TabIndex = 4;
            this.botName.Text = "";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(11, 14);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(107, 30);
            this.name_lb.TabIndex = 3;
            this.name_lb.Text = "Bot name:";
            // 
            // id_label
            // 
            this.id_label.Controls.Add(this.botid);
            this.id_label.Controls.Add(this.id_lb);
            this.id_label.Location = new System.Drawing.Point(29, 68);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(456, 90);
            this.id_label.TabIndex = 0;
            // 
            // botid
            // 
            this.botid.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botid.Location = new System.Drawing.Point(16, 37);
            this.botid.Name = "botid";
            this.botid.Size = new System.Drawing.Size(418, 34);
            this.botid.TabIndex = 3;
            this.botid.Text = "";
            this.botid.TextChanged += new System.EventHandler(this.botid_TextChanged);
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(11, 5);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(76, 30);
            this.id_lb.TabIndex = 2;
            this.id_lb.Text = "Bot ID:";
            // 
            // sub_panel
            // 
            this.sub_panel.BackColor = System.Drawing.Color.LightCyan;
            this.sub_panel.Controls.Add(this.panel1);
            this.sub_panel.Controls.Add(this.listViewBot);
            this.sub_panel.Location = new System.Drawing.Point(227, 90);
            this.sub_panel.Name = "sub_panel";
            this.sub_panel.Size = new System.Drawing.Size(214, 513);
            this.sub_panel.TabIndex = 7;
            // 
            // listViewBot
            // 
            this.listViewBot.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBot.HideSelection = false;
            this.listViewBot.Location = new System.Drawing.Point(20, 74);
            this.listViewBot.Name = "listViewBot";
            this.listViewBot.Size = new System.Drawing.Size(178, 422);
            this.listViewBot.TabIndex = 1;
            this.listViewBot.UseCompatibleStateImageBehavior = false;
            this.listViewBot.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewBot_ItemSelectionChanged);
            this.listViewBot.SelectedIndexChanged += new System.EventHandler(this.listViewBot_SelectedIndexChanged);
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
            this.header.Location = new System.Drawing.Point(7, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(956, 80);
            this.header.TabIndex = 9;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 63);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "All your BOTs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 63);
            this.panel2.TabIndex = 7;
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
            // createResult
            // 
            this.createResult.AutoSize = true;
            this.createResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createResult.Location = new System.Drawing.Point(24, 466);
            this.createResult.Name = "createResult";
            this.createResult.Size = new System.Drawing.Size(61, 25);
            this.createResult.TabIndex = 3;
            this.createResult.Text = "result";
            this.createResult.Click += new System.EventHandler(this.createResult_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 249);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // CreateBotview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 609);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.sub_panel);
            this.Controls.Add(this.main_panel);
            this.Name = "CreateBotview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBotview";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreateBotview_Load);
            this.menu_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.source_panel.ResumeLayout(false);
            this.source_panel.PerformLayout();
            this.name_panel.ResumeLayout(false);
            this.name_panel.PerformLayout();
            this.id_label.ResumeLayout(false);
            this.id_label.PerformLayout();
            this.sub_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.logo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel sub_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel source_panel;
        private System.Windows.Forms.Panel name_panel;
        private System.Windows.Forms.Panel id_label;
        private System.Windows.Forms.ListView listViewBot;
        private System.Windows.Forms.Label source_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.RichTextBox botName;
        private System.Windows.Forms.RichTextBox botid;
        private System.Windows.Forms.RichTextBox botSource;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label createResult;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}