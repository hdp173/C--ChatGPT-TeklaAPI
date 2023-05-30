using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System.Windows.Forms;

namespace ChatGPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SendBtn.Enabled = false;
            Conversation.Text += "\nUser: " + UserInput.Text + "\n";
            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = "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"
            });

            var Messages = new List<ChatMessage>
            {
                ChatMessage.FromSystem("You are the top talented Tekla Structures C# Developer Assistant."),
            };
            for (int i = 0;i < Examples.questions.Count;i ++)
            {
                Messages.Add(ChatMessage.FromUser(Examples.questions[i]));
                Messages.Add(ChatMessage.FromAssistant(Examples.answers[i]));
            }
            Messages.Add(ChatMessage.FromUser(UserInput.Text));
            string currentConversationText = Conversation.Text;
            Conversation.Text += "\nGenerating...";
            var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = Messages,
                Model = Models.ChatGpt3_5Turbo
            });

            SendBtn.Enabled = true;
            if (completionResult.Successful)
            {
                Conversation.Text = currentConversationText + "\nAssistant:\n " + completionResult.Choices.First().Message.Content;
                UserInput.Text = "";
            }
            else
            {
                Console.Write(completionResult.Error.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Conversation.SelectionStart = Conversation.Text.Length;
            // scroll it automatically
            Conversation.ScrollToCaret();
        }
    }
}