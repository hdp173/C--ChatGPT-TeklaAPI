using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGPT
{
    public partial class ExampleForm : Form
    {
        private static HttpClient gptClient = new()
        {
            BaseAddress = Constant.BackEndURL,
        };
        public ExampleForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void TrainBtn_Click(object sender, EventArgs e)
        {
            using StringContent jsonContent = new(
            JsonSerializer.Serialize(new
            {
                input = InputEdit.Text,
                output = OutputEdit.Text,
            }),
            Encoding.UTF8,
            "application/json");
            TrainBtn.Enabled = false;
            using HttpResponseMessage response = await gptClient.PostAsync("train", jsonContent);
            var jsonResponse = response.Content.ReadAsStringAsync();
            TrainBtn.Enabled = true;
            MessageBox.Show("Successful!");
        }
    }
}
