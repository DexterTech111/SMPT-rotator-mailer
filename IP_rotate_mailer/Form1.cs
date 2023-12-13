using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;

namespace IP_rotate_mailer
{
    public partial class Form1 : Form
    {

        string[] smtps;
        string[] emails;
        string html_;
        int total;
        int smtpCount;
        int emailCount;
        int currentbAR;
        int sent;
        int failed;
        int pending;
        int pauseEvery;
        int sendPerSmtp;
        bool flag1;
        double currentDouble;
        static Queue<string> emailQueue = new Queue<string>();
        static Queue<string> sentQueue = new Queue<string>();
        static Queue<string> failedQueue = new Queue<string>();
        static Queue<string> pendingQueue = new Queue<string>();
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
                    labelSmtp.Text = $"{lines.Length}";
                    smtpCount = lines.Length;




                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelSmtp.Text = "0";
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
                    labelEMails.Text = $"{lines.Length}";
                    emailCount = lines.Length;




                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelSmtp.Text = "0";
            emails = new string[0]; ;
            emailCount = 0;
            MessageBox.Show("Your Email's have been loaded");

        }

        //start sending emails


        private void PerformProgress()
        {

            while (true)
            {

                Thread.Sleep(300);

                // Check if the form is disposed before updating the UI
                if (IsDisposed)
                    return;

                // Use Invoke to update the UI from the worker thread
                Invoke(new Action(() =>
                {
                    progressBar2.Value =(int)Math.Round(currentDouble); 
                    labelSent.Text = sent.ToString();
                    labelFailed.Text = failed.ToString();
                    labelPending.Text = pending.ToString();

                }));

                // Simulate some work being done
                Thread.Sleep(1);
            }

            // Enable the button when the progress is complete
            Invoke(new Action(() =>
            {
                btnStart.Enabled = true;
            }));
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Disable the button during the progress
            btnStart.Enabled = false;

            // Start a new thread to perform the progress
            Thread progressThread = new Thread(new ThreadStart(PerformProgress));
            progressThread.Start();

            pauseEvery = Convert.ToInt32(nPauseEvery.Value);
            sendPerSmtp = Convert.ToInt32(nSmtpEvery.Value);
            pauseEvery = pauseEvery * 1000;//convert to milliseconds

            // Add emails to the emailQueue

            Queue<string> emailQueue = new Queue<string>(emails);
            // Add more emails as needed

            //start flag
            flag1 = true;

            foreach (var smtpConfig in smtps)
            {
                //stops sending if flag is false
                if (!flag1)
                {
                    break;
                }
                string[] smtpDetails = smtpConfig.Split(':');

                if (smtpDetails.Length == 4)
                {
                    for (int i = 0; i < sendPerSmtp; i++)
                    {
                        
                        string host = smtpDetails[0];
                        int port = int.Parse(smtpDetails[1]);
                        string username = smtpDetails[2];
                        string password = smtpDetails[3];

                        SendEmails(host, port, username, password);
                        Thread.Sleep(pauseEvery);
                    }

                }
                else
                {
                    // Console.WriteLine("Invalid SMTP configuration: " + smtpConfig);
                }


            }

            // After iterating through SMTPs and sending emails from the queue
            SaveQueueContent("SentEmails.txt", sentQueue);
            SaveQueueContent("FailedEmails.txt", failedQueue);
            SaveQueueContent("PendingEmails.txt", pendingQueue);

            MessageBox.Show("Completed!");

        }


        private void SendEmails(string host, int port, string username, string password)
        {
            string subject = tSubject.Text;
            using (SmtpClient client = new SmtpClient(host))
            {
                client.Port = port;
                client.Credentials = new NetworkCredential(username, password);
                client.EnableSsl = true; // Set to true if your SMTP server requires SSL

                if (emailQueue.Count > 0)
                {
                    string emailData = emailQueue.Dequeue();
                    //string[] emailDetails = emailData.Split(':');

                    if (emailData.Contains('@'))
                    {
                        string recipient = emailData;
                        // string subject = emailDetails[1];
                        string body = html_;

                        MailMessage message = new MailMessage
                        {
                            From = new MailAddress(username),
                            Subject = subject,
                            Body = body,
                            IsBodyHtml = true
                        };

                        message.To.Add(recipient);

                        try
                        {
                            client.Send(message);
                            sentQueue.Enqueue(emailData);
                            sent++;
                            //Console.WriteLine($"Email sent to {recipient} using SMTP {host}:{port}");
                        }
                        catch (Exception ex)
                        {
                            failedQueue.Enqueue(emailData);
                            failed++;
                            // Console.WriteLine($"Failed to send email to {recipient} using SMTP {host}:{port}: {ex.Message}");
                        }
                    }
                    else
                    {
                        pendingQueue.Enqueue(emailData);
                        pending++;
                        //Console.WriteLine("Invalid email data: " + emailData);
                    }
                }
                else
                {
                    flag1 = false;
                }
            }
            total++;
            double res = 100 / emailCount;
            currentDouble += res;
            

        }

        static void SaveQueueContent(string fileName, Queue<string> queue)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                while (queue.Count > 0)
                {
                    writer.WriteLine(queue.Dequeue());
                }
            }
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the selected file
                    string filePath = openFileDialog.FileName;
                    html_ = File.ReadAllText(filePath);
                    // Display line count on the label
                    labelHtml.Text = filePath;
                    // MessageBox.Show(html_);




                }
            }
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this feature will be added in the comming update.");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            flag1 = false;
        }
    }
}
