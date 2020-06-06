using MCHomem.Prototype.SMS.Services;
using System;
using System.Windows.Forms;

namespace MCHomem.Prototype.SMS.Sender
{
    public partial class FrmConfigureCredentials : Form
    {
        #region Constructors

        public FrmConfigureCredentials()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmConfigureCredentials_Load(object sender, System.EventArgs e)
        {
            this.Laod();
        }

        private void FrmConfigureCredentials_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmSMSSender.frmConfigureCredentials = null;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            this.Save();
        }

        #endregion

        #region Methods

        private void Laod()
        {
            try
            {
                this.txtPhoneNumber.Text = TwilioKey.Read("A");
                this.txtUser.Text = TwilioKey.Read("B");
                this.txtPassword.Text = TwilioKey.Read("C");
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

        private void Save()
        {
            try
            {
                if (TwilioKey.IsExistsFile)
                {
                    DialogResult dr =
                        MessageBox.Show
                            (
                                this
                                , "Do you want to overwrite the existent credentials configurate?"
                                , "Question"
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Exclamation
                            );

                    if (dr.Equals(DialogResult.No) || dr.Equals(DialogResult.Cancel))
                    {
                        return;
                    }
                }

                if (String.IsNullOrEmpty(this.txtPhoneNumber.Text)
                    || String.IsNullOrEmpty(this.txtUser.Text)
                    || String.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show
                        (
                            this
                            , "Type all fields."
                            , "Warning."
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Warning
                        );
                    return;
                }

                TwilioKey.Save(this.txtPhoneNumber.Text, this.txtUser.Text, this.txtPassword.Text);

                MessageBox.Show
                    (
                        this
                        , "Done"
                        , "Information."
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information
                    );
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
