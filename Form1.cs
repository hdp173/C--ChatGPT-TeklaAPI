using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System.Windows.Forms;
using System.Text.Json;
using System.Text;
using System.Net;
using System.Net.Http.Json;

namespace ChatGPT
{
    public partial class Form1 : Form
    {
        private static HttpClient gptClient = new()
        {
            BaseAddress = Constant.BackEndURL,
        };

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SendBtn.Enabled = false;
            Conversation.Text += "\nUser: " + UserInput.Text + "\n";
            string currentConversationText = Conversation.Text;
            Conversation.Text += "\nGenerating...";
            
            using StringContent jsonContent = new(
            JsonSerializer.Serialize(new
            {
                input = UserInput.Text,
                remember = rememberConversation.Checked
            }),
            Encoding.UTF8,
            "application/json");
            using HttpResponseMessage response = await gptClient.PostAsync("get-answer", jsonContent);
            SendBtn.Enabled = true;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var jsonResponse = response.Content.ReadAsStringAsync();
                    string result = jsonResponse.Result;
                    string cleanString = result.Trim('"', '\\');

                    // Replace escaped newlines with actual newlines
                    cleanString = cleanString.Replace("\\n", "\n");

                    Conversation.Text = currentConversationText + "\nAssistant:\n " + cleanString + "\n";
                    UserInput.Text = "";                    
                } catch(Exception ex)
                {
                    MessageBox.Show("Error ocurred!");
                    Conversation.Text = currentConversationText;
                }
            }
            else
            {
                MessageBox.Show("Error ocurred!");
                Conversation.Text = currentConversationText;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Conversation.SelectionStart = Conversation.Text.Length;
            // scroll it automatically
            Conversation.ScrollToCaret();
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            ExampleForm exampleForm = new ExampleForm();
            exampleForm.ShowDialog();
        }
    }
}