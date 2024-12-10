using ChatbotGUI.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatbotGUI.Commands
{
    internal class CommonFunctions
    {
        public static List<Dictionary<string, string>> ParseBotData(string json)
        {
            var jsonResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            var data = JsonConvert.DeserializeObject<List<List<object>>>(jsonResponse["data"].ToString());
            List<Dictionary<string, string>> botList = new List<Dictionary<string, string>>();
            foreach (var bot in data)
            {
                Dictionary<string, string> botDict = new Dictionary<string, string>
            {
                { "bot_id", bot[0].ToString() },
                { "bot_name", bot[1].ToString() }
            };
                botList.Add(botDict);
            }

            return botList;
        }


        public static async Task ListAllBotView(ListView listView)
        {
            var allBots = await ApiService.GetAllBots();
            listView.View = View.Details;
            listView.FullRowSelect = true;

            listView.Columns.Clear();
            listView.Items.Clear();

            listView.Columns.Add("Bot Name: ", listView.Width - 20);
            foreach (var bot in allBots)
            {
                ListViewItem item = new ListViewItem(bot["bot_name"]);
                item.SubItems.Add(bot["bot_id"]);
                listView.Items.Add(item);
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
