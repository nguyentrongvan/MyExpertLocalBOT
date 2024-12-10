using ChatbotGUI.Commands;
using ChatbotGUI.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ChatbotGUI
{
    public partial class ConversationView : Form
    {
        public ConversationView()
        {
            InitializeComponent();
        }

        private class Conversation
        {
            public string botId = null;
            public string botName = null;
            public string userInput = null;
            public string botOutput = null;
            public bool haveResponse = false;
        }
        private Conversation conversation = new Conversation();

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.conversation.botId = null;
            this.conversation.botName = null;
            this.Close();
        }

        private async void RefeshListView()
        {
            this.listViewBot.Clear();
            var allBots = await ApiService.GetAllBots();
            await CommonFunctions.ListAllBotView(this.listViewBot);
        }

        private void ConversationView_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            RefeshListView();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            inputBox.Enabled = false;
        }

        private void listViewBot_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string botName = e.Item.Text;
                string botId = e.Item.SubItems[1].Text;
                this.Botnam.Text = botName;
                this.conversation = new Conversation();
                this.conversation.botId = botId;
                this.conversation.botName = botName;
                this.mainChat.Clear();
                this.chatPanel.Controls.Clear();
                inputBox.Enabled = true;
            }
        }

        private void Botnam_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private List<string> WrapText(string text, int maxLineLength)
        {
            var lines = new List<string>();
            var words = text.Split(' ');

            StringBuilder currentLine = new StringBuilder();
            foreach (var word in words)
            {
                if (currentLine.Length + word.Length + 1 > maxLineLength)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                }
                if (currentLine.Length > 0)
                    currentLine.Append(" ");
                currentLine.Append(word);
            }

            if (currentLine.Length > 0)
                lines.Add(currentLine.ToString());

            return lines;
        }

        private void AppendMessage(string message, Color color, string prefix, Font font, HorizontalAlignment alignment)
        {
            int maxLineLength = mainChat.Width / 3;
            List<string> lines = WrapText(message, maxLineLength);
            mainChat.SelectionAlignment = alignment;

            foreach (var line in lines)
            {
                mainChat.SelectionColor = Color.Gray;
                mainChat.SelectionFont = new Font("Arial", 8, FontStyle.Italic);
                mainChat.AppendText(prefix);

                mainChat.SelectionColor = color;
                mainChat.SelectionFont = font;
                mainChat.AppendText(line + Environment.NewLine);
            }
        }

        private void AppendMessageToChat(string message, Color bgColor, string sender, HorizontalAlignment alignment)
        {
            Panel messagePanel = new Panel
            {
                AutoSize = true,
                BackColor = bgColor,
                Margin = new Padding(10),
                Padding = new Padding(10),
                MaximumSize = new Size(chatPanel.Width, 0),
            };



            Label messageLabel = new Label
            {
                Text = message,
                Font = new Font("Arial", 10),
                AutoSize = true,
                MaximumSize = new Size(chatPanel.Width / 2, 0),
                TextAlign = ContentAlignment.MiddleCenter
            };
            messagePanel.Controls.Add(messageLabel);
            if (alignment == HorizontalAlignment.Right)
            {
                messagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                messagePanel.Dock = DockStyle.Right;
            }
            else
            {
                messagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                messagePanel.Dock = DockStyle.Left;
            }
            chatPanel.Controls.Add(messagePanel);
            chatPanel.ScrollControlIntoView(messagePanel);
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        private async void conversationProcess()
        {
            string message = inputBox.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                this.conversation.userInput = message;
                inputBox.Clear();
                AppendMessageToChat(this.conversation.userInput, Color.MediumPurple, "You", HorizontalAlignment.Right);

                var response = await ApiService.Conversation(message, this.conversation.botId);
                this.conversation.botOutput = response.data;
                AppendMessageToChat(this.conversation.botOutput, Color.DarkCyan, "Bot", HorizontalAlignment.Left);
            }
        }


        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                conversationProcess();
            }
        }

        private void mainChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            conversationProcess();
        }

        private void chatPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
