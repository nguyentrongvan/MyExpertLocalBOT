using ChatbotGUI.Commands;
using ChatbotGUI.Services;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace ChatbotGUI
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }
        private CreateBotview botView = null;
        private ConversationView conversationView = null;
        private PictureBox loadingStartPictureBox;

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createbot_btn_Click(object sender, EventArgs e)
        {
            if (this.botView == null)
                botView = new CreateBotview();
            //changeStatusofAllButtons(false);
            botView.ShowDialog();
        }

        private void convesation_btn_Click(object sender, EventArgs e)
        {
            if (this.conversationView == null)
                conversationView = new ConversationView();
            //changeStatusofAllButtons(false);
            conversationView.ShowDialog();
        }

        private async void quit_btn_Click(object sender, EventArgs e)
        {
            await ApiService.CloseBOTServer();
            if (this.botView != null)
            {
                this.botView.Close();
            }
            if (this.conversationView != null)
            {
                this.conversationView.Close();
            }
            this.Close();
        }

        public  void changeStatusofAllButtons(bool status)
        {
            createbot_btn.Enabled = status;
            convesation_btn.Enabled = status;
            quit_btn.Enabled = status;
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            GlobalVaribales.config = new ConfigReader("AppConfig.ini");
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            LaunchBOTServer();
        }

        private async void LaunchBOTServer()
        {
            ShowLoading();
            bool serverReady = false;

            while (!serverReady) {
                Thread.Sleep(1000);
                serverReady = await ApiService.HeathCheck();
            }
            HideLoading();
        }

        private void ShowLoading()
        {
            if (loadingStartPictureBox == null)
            {
                loadingStartPictureBox = new PictureBox
                {
                    Size = this.ClientSize,
                    BackColor = Color.FromArgb(128, 0, 0, 0),
                    Location = new Point(0, 0),
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Image = Image.FromFile("Resources/starting.gif"),
                    Visible = false
                };

                this.Controls.Add(loadingStartPictureBox);
            }

            loadingStartPictureBox.BringToFront();
            loadingStartPictureBox.Visible = true;
        }

        private void HideLoading()
        {
            if (loadingStartPictureBox != null)
            {
                loadingStartPictureBox.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
