﻿using MCHomem.Prototype.SMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MCHomem.Prototype.SMS.Sender
{
    public partial class FrmSMSSender : Form
    {
        #region Construtors

        public FrmSMSSender()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmSMSSender_Load(object sender, EventArgs e)
        {
            this.LoadServices();
            this.LoadFormFields();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtDestiyPhone.Text)
                || String.IsNullOrEmpty(this.txtMessage.Text)
                || this.cbServices.SelectedIndex == 0)
            {
                MessageBox.Show
                    (
                        this
                        , "The follow fields: \"Destiny phone\", \"Message\" and \"Services\" are required."
                        , "Warning"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Warning
                    );
                return;
            }

            switch (this.cbServices.Text)
            {
                case "Twilio":
                    this.SendSMSByTwilio();
                    break;

                case "Amazon - AWS":
                    this.SendSMSByAWS();
                    break;

                default:
                    break;
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            this.lblMaxCharacter.Text = String.Format("{0}/{1}", this.txtMessage.Text.Length, this.txtMessage.MaxLength);
        }

        #endregion

        #region Methods

        private void LoadFormFields()
        {
            this.txtDestiyPhone.Text = "+5551997400267";
            this.txtMessage.Text = "Olá! Isso é um teste de envio de SMS!";
            this.txtDestiyPhone.Select(0, 0);
        }

        private void LoadServices()
        {
            Dictionary<Int32, String> services = new Dictionary<int, string>();
            services.Add(0, "");
            services.Add(1, "Twilio");
            services.Add(2, "Amazon - AWS");
            this.cbServices.DataSource = services.ToList();
            this.cbServices.DisplayMember = "Value";
            this.cbServices.ValueMember = "Key";
        }

        private void SendSMSByTwilio()
        {
            try
            {
                TwilioServices ts = new TwilioServices();
                String returnSid = ts.SendSMS(this.txtDestiyPhone.Text, this.txtMessage.Text);
                MessageBox.Show(this, String.Format("SMS sended. SID: {0}", returnSid));
            }
            catch (Exception e)
            {
                MessageBox.Show
                    (
                        this
                        , "Error on the sms send process.\r\nDetails: " + e.Message
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error
                    );
            }
        }

        private void SendSMSByAWS()
        {
            try
            {
                AWSServices aws = new AWSServices();
                String returnSid = aws.SendSMS(this.txtDestiyPhone.Text, this.txtMessage.Text);
                MessageBox.Show(this, String.Format("SMS sended. SID: {0}", returnSid));
            }
            catch (Exception e)
            {
                MessageBox.Show
                    (
                        this
                        , "Error on the sms send process.\r\nDetails: " + e.Message
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error
                    );
            }
        }

        #endregion
    }
}

