using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace telnet25
{
    public partial class Telnet : Form
    {
        public Telnet()
        {
            InitializeComponent();
        }

        TcpClient clientSmtp;

        NetworkStream streamSmtp;

        StreamReader readerSmtp;

        StreamWriter writerSmtp;

        DateTime initialTime;

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (stepByStepCheckBox.Checked)
                DoConnect();
            else
            {
                DoConnect();

                DoEhlo();
                if (enableBasicAuthCheckBox.Checked)
                    DoAuth();
                DoMailFrom();
                DoRcptTo();
                DoSendData();
            }
        }

        private void ehloButton_Click(object sender, EventArgs e)
        {
            DoEhlo();
        }

        private void mailFromButton_Click(object sender, EventArgs e)
        {
            DoMailFrom();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            DoAuth();
        }

        static public string EncodeTo64(string toEncode)
        {

            byte[] toEncodeAsBytes

                  = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue

                  = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;

        }

        private void rcptToButton_Click(object sender, EventArgs e)
        {
            DoRcptTo();
        }

        private void sendDataButton_Click(object sender, EventArgs e)
        {
            DoSendData();
        }

        private void enableHELOCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableHELOCheckBox.Checked)
            {
                ehloDomainBox.ReadOnly = true;
                ehloButton.Text = "HELO";
            }
            else
            {
                ehloDomainBox.ReadOnly = false;
                ehloButton.Text = "EHLO";
            }
        }

        private void enableCcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableCcCheckBox.Checked)
            {
                ccBox.ReadOnly = false;
            }
            else
            {
                ccBox.ReadOnly = true;
            }
        }

        private void enableSizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSizeCheckBox.Checked)
            {
                sizeBox.ReadOnly = false;
            }
            else
            {
                sizeBox.ReadOnly = true;
            }
        }

        private void enableReplyToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableReplyToCheckBox.Checked)
            {
                returnPathBox.ReadOnly = false;
            }
            else
            {
                returnPathBox.ReadOnly = true;
            }
        }

        private void enableAdditionalHeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableAdditionalHeaderCheckBox.Checked)
            {
                headerNameBox.ReadOnly = false;
                headerValueBox.ReadOnly = false;
            }
            else
            {
                headerNameBox.ReadOnly = true;
                headerValueBox.ReadOnly = true;
            }
        }

        private void enableBasicAuthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stepByStepCheckBox.Checked)
                authButton.Enabled = true;
            if (enableBasicAuthCheckBox.Checked)
            {
                usernameBox.ReadOnly = false;
                passwordBox.ReadOnly = false;
                enableClearPasswordCheckBox.Enabled = true;
            }
            else
            {
                usernameBox.ReadOnly = true;
                passwordBox.ReadOnly = true;
                enableClearPasswordCheckBox.Enabled = false;
                authButton.Enabled = false;
            }
        }

        private void enableClearPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableClearPasswordCheckBox.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {
            outputTextBox.SelectionStart = outputTextBox.Text.Length;
            outputTextBox.ScrollToCaret();
            outputTextBox.Refresh();
        }

        private void stepByStepCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stepByStepCheckBox.Checked)
            {
                connectButton.Text = "CONNECT";
                ehloButton.Enabled = true;
                if (enableBasicAuthCheckBox.Checked)
                    authButton.Enabled = true;
                mailFromButton.Enabled = true;
                rcptToButton.Enabled = true;
                sendDataButton.Enabled = true;
            }
            else
            {
                connectButton.Text = "SEND";
                ehloButton.Enabled = false;
                authButton.Enabled = false;
                mailFromButton.Enabled = false;
                rcptToButton.Enabled = false;
                sendDataButton.Enabled = false;
            }
        }

        private void DoConnect() //////////////////////////////////////////////////////////////////////////DO CONNECT
        {
            clientSmtp = new TcpClient();
            if (clientSmtp.Connected)
                clientSmtp.Close();
            try
            {
                outputTextBox.Text = "trying to connect to " + connectorIpBox.Text + ":" + connectorPortBox.Text;
                clientSmtp.Connect(connectorIpBox.Text, Convert.ToInt32(connectorPortBox.Text));
                streamSmtp = clientSmtp.GetStream();

                readerSmtp = new StreamReader(streamSmtp);

                outputTextBox.Text = readResponse();
                connectButton.Text = "RECONNECT";
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                outputTextBox.Text = "****CONNECTION ERROR****";
                clientSmtp.Close();
            }

        }

        private void DoEhlo() /////////////////////////////////////////////////////////////////////////////////DO EHLO
        {
            try
            {
                readerSmtp = new StreamReader(streamSmtp);
                writerSmtp = new StreamWriter(streamSmtp);

                if (enableHELOCheckBox.Checked)
                {
                    writerSmtp.WriteLine("HELO");
                    writerSmtp.Flush();

                    outputTextBox.Text += "\r\n" + "HELO";
                }
                else
                {
                    writerSmtp.WriteLine("EHLO " + ehloDomainBox.Text);
                    writerSmtp.Flush();

                    outputTextBox.Text += "\r\n" + "EHLO " + ehloDomainBox.Text;
                }

                outputTextBox.Text += "\r\n" + readResponse();
                waitingForResponseString.Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DoAuth() ///////////////////////////////////////////////////////////////////////////////////////// DO AUTH
        {
            try
            {
                writerSmtp = new StreamWriter(streamSmtp);

                writerSmtp.WriteLine("auth login");
                writerSmtp.Flush();

                outputTextBox.Text += "\r\n" + "auth login";

                outputTextBox.Text += "\r\n" + readResponse();

                if (usernameBox.Text == "")
                    usernameBox.Text = " ";
                writerSmtp.WriteLine(EncodeTo64(usernameBox.Text));
                writerSmtp.Flush();

                outputTextBox.Text += "\r\n" + EncodeTo64(usernameBox.Text);

                outputTextBox.Text += "\r\n" + readResponse();

                if (passwordBox.Text == "")
                    passwordBox.Text = " ";
                writerSmtp.WriteLine(EncodeTo64(passwordBox.Text));
                writerSmtp.Flush();

                outputTextBox.Text += "\r\n" + EncodeTo64(passwordBox.Text);

                outputTextBox.Text += "\r\n" + readResponse();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void DoMailFrom()
        {
            try
            {
                writerSmtp = new StreamWriter(streamSmtp);
                if (!enableSizeCheckBox.Checked)
                {
                    writerSmtp.WriteLine(@"mail from: " + mailFromBox.Text);
                    writerSmtp.Flush();
                    outputTextBox.Text += "\r\n" + @"mail from: " + mailFromBox.Text;
                }
                else
                {
                    writerSmtp.WriteLine(@"mail from: " + mailFromBox.Text + " SIZE=" + sizeBox.Text);
                    writerSmtp.Flush();
                    outputTextBox.Text += "\r\n" + @"mail from: " + mailFromBox.Text + " SIZE=" + sizeBox.Text;
                }
                outputTextBox.Text += "\r\n" + readResponse();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void DoRcptTo()
        {
            try
            {
                writerSmtp = new StreamWriter(streamSmtp);

                writerSmtp.WriteLine(@"rcpt to: " + rcptToBox.Text);
                writerSmtp.Flush();

                outputTextBox.Text += "\r\n" + @"rcpt to: " + rcptToBox.Text;

                outputTextBox.Text += "\r\n" + readResponse();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DoSendData()
        {
            try
            {
                writerSmtp = new StreamWriter(streamSmtp);

                writerSmtp.WriteLine(@"DATA");
                writerSmtp.Flush();

                outputTextBox.Text += "\r\n" + @"DATA";

                outputTextBox.Text += "\r\n" + readResponse();

                string strBody = "";
                if (enableReplyToCheckBox.Checked)
                    strBody = "Reply-To: " + returnPathBox.Text + Environment.NewLine;
                strBody += "From: " + mailFromBox.Text + Environment.NewLine;
                strBody += "To: " + rcptToBox.Text + Environment.NewLine;
                if (enableCcCheckBox.Checked)
                    strBody += "CC: " + ccBox.Text + Environment.NewLine;
                if (subjectBox.Text.Length >= 1)
                    strBody += "Subject: " + "=?iso-8859-3?Q?" + subjectBox.Text.Replace("ğ", "=BB").Replace("ş", "=BA").Replace("ç", "=E7").Replace("ö", "=F6").Replace("ı", "=B9").Replace("ü", "=FC").Replace("Ğ", "=AB").Replace("Ü", "=DC").Replace("Ş", "=AA").Replace("İ", "=A9").Replace("Ö", "=D6").Replace("Ç", "=C7") + "?=" + Environment.NewLine;
                if (enableReadReceiptCheckBox.Checked && enableReplyToCheckBox.Checked)
                    strBody += "Disposition-Notification-To: " + returnPathBox.Text + Environment.NewLine;
                if (enableReadReceiptCheckBox.Checked && !enableReplyToCheckBox.Checked)
                    strBody += "Disposition-Notification-To: " + mailFromBox.Text + Environment.NewLine;
                if (enableAdditionalHeaderCheckBox.Checked)
                    strBody += headerNameBox.Text + ": " + headerValueBox.Text + Environment.NewLine;
                strBody += "X-Mailer: Receive Connector Editor 1.0 For comments please email to candedeoglu@hotmail.com" + Environment.NewLine;
                strBody += "Content-Type: text/plain; format=flowed; charset=\"iso-8859-9\"" + Environment.NewLine;
                strBody += Environment.NewLine;
                strBody += BodyTextBox.Text + Environment.NewLine;
                strBody += Environment.NewLine + "." + Environment.NewLine;

                writerSmtp.Write(strBody);
                writerSmtp.Flush();

                outputTextBox.Text += "\r\n" + @"transmitting body";

                outputTextBox.Text += "\r\n" + readResponse();

                clientSmtp.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        string readResponse()
        {
            byte[] buffer = new byte[1024];
            ASCIIEncoding encoding = new ASCIIEncoding();

            initialTime = DateTime.Now;
            TimeSpan waitInterval = DateTime.Now - initialTime;

            waitForResponse(true);

            while (waitInterval.Seconds < 10)
            {
                try
                {
                    if (streamSmtp.DataAvailable)
                    {
                        int readbytes = streamSmtp.Read(buffer, 0, 1024);
                        string incomingData = encoding.GetString(buffer, 0, readbytes);
                        if (incomingData != null)
                        {
                            waitForResponse(false);
                            return incomingData;
                        }
                    }
                    //clientSmtp.Close();
                    waitInterval = DateTime.Now - initialTime;
                }
                catch (Exception e)
                {
                    clientSmtp.Close();
                    waitForResponse(false);
                    return (e.Message);
                }
            }
            waitForResponse(false);
            clientSmtp.Close();
            return "no data for 60secs";
        }

        //string readLineResponse()
        //{
        //    initialTime = DateTime.Now;
        //    TimeSpan waitInterval = DateTime.Now - initialTime;

        //    waitForResponse(true);

        //    while (waitInterval.Seconds < 60)
        //    {
        //        if (streamSmtp.DataAvailable)
        //        {
        //            string incomingData = readerSmtp.ReadLine();


        //            if (incomingData != null)
        //            {
        //                waitForResponse(false);
        //                readerSmtp.DiscardBufferedData();
        //                return incomingData;
        //            }
        //        }
        //        waitInterval = DateTime.Now - initialTime;

        //    }
        //    clientSmtp.Close();
        //    waitForResponse(false);
        //    return "no data for 60secs";
        //}

        private void waitForResponse(bool wait)
        {
            if (wait)
            {
                waitingForResponseString.Visible = true;
                //connectButton.Enabled = false;
                //ehloButton.Enabled = false;
                //authButton.Enabled = false;
                //mailFromButton.Enabled = false;
                //rcptToButton.Enabled = false;
                //sendDataButton.Enabled = false;
                this.Refresh();
            }
            else
            {
                waitingForResponseString.Visible = false;
                //connectButton.Enabled = true;
                //ehloButton.Enabled = true;
                //if(enableBasicAuthCheckBox.Checked)
                //    authButton.Enabled = true;
                //mailFromButton.Enabled = true;
                //rcptToButton.Enabled = true;
                //sendDataButton.Enabled = true;
            }

        }

        private void connectorIpBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "SMTP Connection to " + connectorIpBox.Text + ":" + connectorPortBox.Text;
        }

        private void connectorPortBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "SMTP Connection to " + connectorIpBox.Text + ":" + connectorPortBox.Text;
        }

        private void Telnet_Load(object sender, EventArgs e)
        {
            connectorIpBox.Focus();
            connectorIpBox.Select();
        }


    }
}
