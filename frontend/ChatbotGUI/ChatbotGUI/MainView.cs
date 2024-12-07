using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void quit_btn_Click(object sender, EventArgs e)
        {
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
        }
    }
}
