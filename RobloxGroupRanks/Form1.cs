using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RobloxGroupRanks.Objects;
using System.Net;

namespace RobloxGroupRanks
{
    public partial class Form1 : Form
    {


        private dynamic WebRequestGET(Uri url)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Method = "GET";
                request.Timeout = 10000;
                WebResponse webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();
                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();
                dynamic jsonData = JObject.Parse(data);
                request.Abort();
                webResponse.Close();
                webStream.Close();
                return jsonData;
            }
            catch (Exception e)
            {

                ranks_box.Text = $"Error occured while fetching data from HTTP Request{Environment.NewLine}{e.Message}";
                return null;
            }
        }

        private string WebRequestGET(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Method = "GET";
                request.Timeout = 10000;
                WebResponse webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();
                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();

                request.Abort();
                webResponse.Close();
                webStream.Close();
                return data;
            }
            catch (Exception e)
            {

                ranks_box.Text = $"Error occured while fetching data from HTTP Request{Environment.NewLine}{e.Message}";
                return null;
            }
        }

        public List<Dictionary<string, string>> GetAllRoles(int groupId)
        {
            string text = WebRequestGET($"https://groups.roblox.com/v1/groups/{groupId}/roles");
            if (text == null)
            {
                return null;
            }
            AllRoles list = JsonConvert.DeserializeObject<AllRoles>(text);
            return list.roles;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void button_check_Click(object sender, EventArgs e)
        {
            var roles = GetAllRoles(int.Parse(groupId_box.Text));
            if (roles != null)
            {
                ranks_box.Items.Clear();
                foreach (var role in roles)
                {
                    int index = ranks_box.Items.Add(role["name"] + ": " + role["rank"]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content = "";
            foreach (string item in ranks_box.Items)
            {
                content += item + "\n";
            }
            Clipboard.SetText(content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = (string)ranks_box.SelectedItem;
            string[] split = item.Split(": ");
            Clipboard.SetText(split[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string item = (string)ranks_box.SelectedItem;
            string[] split = item.Split(": ");
            Clipboard.SetText(split[0]);
        }
    }
}