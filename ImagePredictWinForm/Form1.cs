using Newtonsoft.Json;

namespace ImagePredictWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var url = openFileDialog1.FileName;
            pictureBox1.ImageLocation = url;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var imageUri = pictureBox1.ImageLocation;
            if(imageUri != null) 
            {
                resultIntoLabel.Text = "Carregando...";
                var result = await client.PostAsync($"https://localhost:52322/predict?imagePath={imageUri}", null);
                if(result != null) 
                {
                    var res = await result.Content.ReadAsStringAsync();
                    resultIntoLabel.Text = $"Este item está mais próximo de ser um(a) {res}";
                }
                

            }
        }
    }
}