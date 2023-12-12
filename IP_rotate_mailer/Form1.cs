using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IP_rotate_mailer
{
    public partial class Form1 : Form
    {

        string[] smtps;
        string[] emails;
        int smtpCount;
        int emailCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the selected file
                    string filePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);
                    smtps = lines;
                    // Display line count on the label
                    label3.Text = $"{lines.Length}";
                    smtpCount = lines.Length;




                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            smtps = new string[0]; ;
            smtpCount = 0;
            MessageBox.Show("Your SMPT's have been loaded");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the selected file
                    string filePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);
                    emails = lines;
                    // Display line count on the label
                    label5.Text = $"{lines.Length}";
                    emailCount = lines.Length;




                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            emails = new string[0]; ;
            emailCount = 0;
            MessageBox.Show("Your Email's have been loaded");

        }

        //start sending emails


        private void PerformProgress()
        {
           
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(300);
                
                // Check if the form is disposed before updating the UI
                if (IsDisposed)
                    return;

                // Use Invoke to update the UI from the worker thread
                Invoke(new Action(() =>
                {
                    progressBar2.Value = i;
                    label8.Text = i.ToString();
                  
                }));

                // Simulate some work being done
                Thread.Sleep(1);
            }

            // Enable the button when the progress is complete
            Invoke(new Action(() =>
            {
                button6.Enabled = true;
            }));
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Disable the button during the progress
            button6.Enabled = false;

            // Start a new thread to perform the progress
            Thread progressThread = new Thread(new ThreadStart(PerformProgress));
            progressThread.Start();
        }
    }
}
