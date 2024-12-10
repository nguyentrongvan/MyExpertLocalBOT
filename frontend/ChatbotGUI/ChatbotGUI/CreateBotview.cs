using ChatbotGUI.Commands;
using ChatbotGUI.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChatbotGUI
{
    public partial class CreateBotview : Form
    {
        public CreateBotview()
        {
            InitializeComponent();
        }
        private class CreateUpdateBot
        {
            public string botId = null;
            public string botName = null;
            public List<string> selectedFiles = new List<string>();
        }

        private CreateUpdateBot createUpdateCurrentBot = new CreateUpdateBot();
        private PictureBox loadingPictureBox;

        private void quit_btn_Click(object sender, EventArgs e)
        {
            if (this.createUpdateCurrentBot != null)
            {
                this.createUpdateCurrentBot.botId = null;
                this.createUpdateCurrentBot.botName = null;
            }
            this.Close();
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Supported files (*.pdf;*.docx;*.doc)|*.pdf;*.docx;*.doc";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.botSource.Clear();

                foreach (string fileName in openFileDialog.FileNames)
                {
                    this.botSource.AppendText(fileName + Environment.NewLine);
                    this.createUpdateCurrentBot.selectedFiles.Add(fileName.ToString());
                    //Process.Start(fileName);
                }
            }
        }

        private void CreateBotview_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            RefeshListView();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.createResult.Text = "";
        }

        private async void RefeshListView()
        {
            this.listViewBot.Clear();
            var allBots = await ApiService.GetAllBots();
            await CommonFunctions.ListAllBotView(this.listViewBot);
        }

        private void listViewBot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewBot_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) 
            {
                string botName = e.Item.Text;
                string botId = e.Item.SubItems[1].Text;
                this.botid.Text = botId;
                this.botName.Text = botName;
                this.createUpdateCurrentBot.botId = botId;
                this.createUpdateCurrentBot.botName = botName;
            }
        }

        private void botid_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowLoading()
        {
            if (loadingPictureBox == null)
            {
                loadingPictureBox = new PictureBox
                {
                    Size = this.ClientSize,
                    BackColor = Color.FromArgb(128, 0, 0, 0),
                    Location = new Point(0, 0),
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Image = Image.FromFile("Resources/loading.gif"),
                    Visible = false
                };

                this.Controls.Add(loadingPictureBox);
            }

            loadingPictureBox.BringToFront();
            loadingPictureBox.Visible = true;
        }

        private void HideLoading()
        {
            if (loadingPictureBox != null)
            {
                loadingPictureBox.Visible = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string botId = string.IsNullOrEmpty(this.botid.Text) ? null : this.botid.Text;
            string botName = string.IsNullOrEmpty(this.botName.Text) ? null : this.botName.Text;
            ShowLoading();
            var response = await ApiService.CreateBot(this.createUpdateCurrentBot.selectedFiles, botId, botName);
            if (Int16.Parse(response.status_code) == 200) {
                RefeshListView();
                this.createResult.Text = "Bot created successful!";
                this.createResult.ForeColor = Color.Green;
            }
            else
            {
                this.createResult.Text = "Bot created failed!";
                this.createResult.ForeColor = Color.Red;
            }
            HideLoading();
        }

        private void botSource_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createResult_Click(object sender, EventArgs e)
        {

        }
    }
}
