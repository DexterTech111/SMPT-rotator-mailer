namespace IP_rotate_mailer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            btnSmtpCl = new Button();
            btnSmtpIn = new Button();
            labelSmtp = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            label15 = new Label();
            btnText = new Button();
            tSubject = new TextBox();
            label20 = new Label();
            nSmtpEvery = new NumericUpDown();
            btnHtml = new Button();
            labelHtml = new Label();
            nPauseEvery = new NumericUpDown();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel5 = new Panel();
            comboBox1 = new ComboBox();
            panel6 = new Panel();
            progressBar2 = new ProgressBar();
            btnStart = new Button();
            btnStop = new Button();
            label7 = new Label();
            panel3 = new Panel();
            labelPending = new Label();
            label13 = new Label();
            labelFailed = new Label();
            label11 = new Label();
            labelSent = new Label();
            label9 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            btnEmailClear = new Button();
            btnEmailImport = new Button();
            labelEMails = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nSmtpEvery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nPauseEvery).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSmtpCl);
            panel2.Controls.Add(btnSmtpIn);
            panel2.Controls.Add(labelSmtp);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 59);
            panel2.TabIndex = 0;
            // 
            // btnSmtpCl
            // 
            btnSmtpCl.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSmtpCl.Location = new Point(233, 12);
            btnSmtpCl.Name = "btnSmtpCl";
            btnSmtpCl.Size = new Size(65, 33);
            btnSmtpCl.TabIndex = 5;
            btnSmtpCl.Text = "Clear";
            btnSmtpCl.UseVisualStyleBackColor = true;
            btnSmtpCl.Click += button2_Click;
            // 
            // btnSmtpIn
            // 
            btnSmtpIn.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSmtpIn.Location = new Point(158, 12);
            btnSmtpIn.Name = "btnSmtpIn";
            btnSmtpIn.Size = new Size(65, 33);
            btnSmtpIn.TabIndex = 4;
            btnSmtpIn.Text = "Import";
            btnSmtpIn.UseVisualStyleBackColor = true;
            btnSmtpIn.Click += button1_Click;
            // 
            // labelSmtp
            // 
            labelSmtp.AutoSize = true;
            labelSmtp.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSmtp.Location = new Point(98, 18);
            labelSmtp.Name = "labelSmtp";
            labelSmtp.Size = new Size(15, 17);
            labelSmtp.TabIndex = 3;
            labelSmtp.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 18);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 2;
            label2.Text = "Total SMTP :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 7);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 1;
            label1.Text = "SMTP";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 393);
            panel1.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label15);
            panel7.Controls.Add(btnText);
            panel7.Controls.Add(tSubject);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(nSmtpEvery);
            panel7.Controls.Add(btnHtml);
            panel7.Controls.Add(labelHtml);
            panel7.Controls.Add(nPauseEvery);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(comboBox1);
            panel7.Location = new Point(226, 102);
            panel7.Name = "panel7";
            panel7.Size = new Size(524, 166);
            panel7.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 47);
            label15.Name = "label15";
            label15.Size = new Size(145, 17);
            label15.TabIndex = 12;
            label15.Text = "Rotate SMTP Every      :";
            // 
            // btnText
            // 
            btnText.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnText.Location = new Point(312, 112);
            btnText.Name = "btnText";
            btnText.Size = new Size(127, 33);
            btnText.TabIndex = 18;
            btnText.Text = "Text";
            btnText.UseVisualStyleBackColor = true;
            btnText.Click += btnText_Click;
            // 
            // tSubject
            // 
            tSubject.Location = new Point(304, 19);
            tSubject.Name = "tSubject";
            tSubject.Size = new Size(144, 27);
            tSubject.TabIndex = 24;
            tSubject.Text = "Subject";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(314, 53);
            label20.Name = "label20";
            label20.Size = new Size(43, 17);
            label20.TabIndex = 6;
            label20.Text = "Status";
            // 
            // nSmtpEvery
            // 
            nSmtpEvery.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nSmtpEvery.Location = new Point(167, 48);
            nSmtpEvery.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nSmtpEvery.Name = "nSmtpEvery";
            nSmtpEvery.Size = new Size(88, 23);
            nSmtpEvery.TabIndex = 20;
            nSmtpEvery.Value = new decimal(new int[] { 250, 0, 0, 0 });
            // 
            // btnHtml
            // 
            btnHtml.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHtml.Location = new Point(312, 74);
            btnHtml.Name = "btnHtml";
            btnHtml.Size = new Size(127, 33);
            btnHtml.TabIndex = 17;
            btnHtml.Text = "Html";
            btnHtml.UseVisualStyleBackColor = true;
            btnHtml.Click += btnHtml_Click;
            // 
            // labelHtml
            // 
            labelHtml.AutoSize = true;
            labelHtml.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHtml.Location = new Point(167, 111);
            labelHtml.MaximumSize = new Size(100, 14);
            labelHtml.Name = "labelHtml";
            labelHtml.Size = new Size(15, 14);
            labelHtml.TabIndex = 23;
            labelHtml.Text = "0";
            // 
            // nPauseEvery
            // 
            nPauseEvery.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nPauseEvery.Location = new Point(167, 19);
            nPauseEvery.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nPauseEvery.Name = "nPauseEvery";
            nPauseEvery.Size = new Size(88, 23);
            nPauseEvery.TabIndex = 19;
            nPauseEvery.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(4, 19);
            label14.Name = "label14";
            label14.Size = new Size(144, 17);
            label14.TabIndex = 11;
            label14.Text = "Pause Every                :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(4, 75);
            label16.Name = "label16";
            label16.Size = new Size(145, 17);
            label16.TabIndex = 13;
            label16.Text = "Mail Priority                :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(4, 111);
            label17.Name = "label17";
            label17.Size = new Size(144, 17);
            label17.TabIndex = 22;
            label17.Text = "Letter                         :";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(304, 65);
            panel5.Name = "panel5";
            panel5.Size = new Size(144, 88);
            panel5.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "High", "Medium", "Low" });
            comboBox1.Location = new Point(167, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(88, 23);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Priority";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(progressBar2);
            panel6.Controls.Add(btnStart);
            panel6.Controls.Add(btnStop);
            panel6.Location = new Point(17, 290);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 83);
            panel6.TabIndex = 6;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(173, 26);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(545, 33);
            progressBar2.TabIndex = 10;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(15, 26);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(65, 33);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button6_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(86, 26);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(65, 33);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 90);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 5;
            label7.Text = "Status";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelPending);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(labelFailed);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(labelSent);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(17, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 166);
            panel3.TabIndex = 4;
            // 
            // labelPending
            // 
            labelPending.AutoSize = true;
            labelPending.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPending.Location = new Point(73, 75);
            labelPending.Name = "labelPending";
            labelPending.Size = new Size(15, 17);
            labelPending.TabIndex = 9;
            labelPending.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 75);
            label13.Name = "label13";
            label13.Size = new Size(62, 17);
            label13.TabIndex = 8;
            label13.Text = "Pending :";
            // 
            // labelFailed
            // 
            labelFailed.AutoSize = true;
            labelFailed.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFailed.Location = new Point(73, 47);
            labelFailed.Name = "labelFailed";
            labelFailed.Size = new Size(15, 17);
            labelFailed.TabIndex = 7;
            labelFailed.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(4, 47);
            label11.Name = "label11";
            label11.Size = new Size(61, 17);
            label11.TabIndex = 6;
            label11.Text = "Failed    :";
            // 
            // labelSent
            // 
            labelSent.AutoSize = true;
            labelSent.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSent.Location = new Point(73, 19);
            labelSent.Name = "labelSent";
            labelSent.Size = new Size(15, 17);
            labelSent.TabIndex = 3;
            labelSent.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 19);
            label9.Name = "label9";
            label9.Size = new Size(60, 17);
            label9.TabIndex = 2;
            label9.Text = "Sent      :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(351, 7);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 3;
            label4.Text = "EMAILS";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnEmailClear);
            panel4.Controls.Add(btnEmailImport);
            panel4.Controls.Add(labelEMails);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(344, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 59);
            panel4.TabIndex = 2;
            // 
            // btnEmailClear
            // 
            btnEmailClear.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmailClear.Location = new Point(326, 12);
            btnEmailClear.Name = "btnEmailClear";
            btnEmailClear.Size = new Size(65, 33);
            btnEmailClear.TabIndex = 5;
            btnEmailClear.Text = "Clear";
            btnEmailClear.UseVisualStyleBackColor = true;
            btnEmailClear.Click += button3_Click;
            // 
            // btnEmailImport
            // 
            btnEmailImport.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmailImport.Location = new Point(251, 12);
            btnEmailImport.Name = "btnEmailImport";
            btnEmailImport.Size = new Size(65, 33);
            btnEmailImport.TabIndex = 4;
            btnEmailImport.Text = "Import";
            btnEmailImport.UseVisualStyleBackColor = true;
            btnEmailImport.Click += button4_Click;
            // 
            // labelEMails
            // 
            labelEMails.AutoSize = true;
            labelEMails.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEMails.Location = new Point(106, 18);
            labelEMails.Name = "labelEMails";
            labelEMails.Size = new Size(15, 17);
            labelEMails.TabIndex = 3;
            labelEMails.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 18);
            label6.Name = "label6";
            label6.Size = new Size(91, 17);
            label6.TabIndex = 2;
            label6.Text = "Total EMAILS :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 422);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "IP ROtator";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nSmtpEvery).EndInit();
            ((System.ComponentModel.ISupportInitialize)nPauseEvery).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button btnSmtpCl;
        private Button btnSmtpIn;
        private Label labelSmtp;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Panel panel4;
        private Button btnEmailClear;
        private Button btnEmailImport;
        private Label labelEMails;
        private Label label6;
        private Label label7;
        private Label labelPending;
        private Label label13;
        private Label labelFailed;
        private Label label11;
        private Button btnStop;
        private Button btnStart;
        private Label labelSent;
        private Label label9;
        private ProgressBar progressBar2;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label20;
        private Button btnText;
        private Button btnHtml;
        private Label label17;
        private Label labelHtml;
        private Label label19;
        private Panel panel5;
        private NumericUpDown nSmtpEvery;
        private NumericUpDown nPauseEvery;
        private ComboBox comboBox1;
        private TextBox tSubject;
        private Panel panel6;
        private Panel panel7;
    }
}
