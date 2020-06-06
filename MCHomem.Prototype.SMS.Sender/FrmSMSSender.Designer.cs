namespace MCHomem.Prototype.SMS.Sender
{
    partial class FrmSMSSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMSSender));
            this.lblMaxCharacter = new System.Windows.Forms.Label();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDestiyPhone = new System.Windows.Forms.TextBox();
            this.lblDestinyPhone = new System.Windows.Forms.Label();
            this.btnConfigurarCredenciais = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMaxCharacter
            // 
            this.lblMaxCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharacter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMaxCharacter.Location = new System.Drawing.Point(15, 118);
            this.lblMaxCharacter.Name = "lblMaxCharacter";
            this.lblMaxCharacter.Size = new System.Drawing.Size(233, 20);
            this.lblMaxCharacter.TabIndex = 4;
            this.lblMaxCharacter.Text = "0";
            this.lblMaxCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbServices
            // 
            this.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(15, 166);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(85, 21);
            this.cbServices.TabIndex = 6;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(14, 150);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(48, 13);
            this.lblServices.TabIndex = 5;
            this.lblServices.Text = "Services";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(182, 165);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send SMS";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 49);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 65);
            this.txtMessage.MaxLength = 140;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(233, 50);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // txtDestiyPhone
            // 
            this.txtDestiyPhone.Location = new System.Drawing.Point(15, 26);
            this.txtDestiyPhone.Name = "txtDestiyPhone";
            this.txtDestiyPhone.Size = new System.Drawing.Size(233, 20);
            this.txtDestiyPhone.TabIndex = 1;
            // 
            // lblDestinyPhone
            // 
            this.lblDestinyPhone.AutoSize = true;
            this.lblDestinyPhone.Location = new System.Drawing.Point(12, 10);
            this.lblDestinyPhone.Name = "lblDestinyPhone";
            this.lblDestinyPhone.Size = new System.Drawing.Size(75, 13);
            this.lblDestinyPhone.TabIndex = 0;
            this.lblDestinyPhone.Text = "Destiny phone";
            // 
            // btnConfigurarCredenciais
            // 
            this.btnConfigurarCredenciais.Image = global::MCHomem.Prototype.SMS.Sender.Properties.Resources.cog;
            this.btnConfigurarCredenciais.Location = new System.Drawing.Point(106, 165);
            this.btnConfigurarCredenciais.Name = "btnConfigurarCredenciais";
            this.btnConfigurarCredenciais.Size = new System.Drawing.Size(23, 23);
            this.btnConfigurarCredenciais.TabIndex = 7;
            this.btnConfigurarCredenciais.UseVisualStyleBackColor = true;
            this.btnConfigurarCredenciais.Click += new System.EventHandler(this.btnConfigurarCredenciais_Click);
            this.btnConfigurarCredenciais.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSetup_MouseMove);
            // 
            // FrmSMSSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 199);
            this.Controls.Add(this.btnConfigurarCredenciais);
            this.Controls.Add(this.lblMaxCharacter);
            this.Controls.Add(this.cbServices);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtDestiyPhone);
            this.Controls.Add(this.lblDestinyPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSMSSender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Sender";
            this.Load += new System.EventHandler(this.FrmSMSSender_Load);
            this.Move += new System.EventHandler(this.FrmSMSSender_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxCharacter;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDestiyPhone;
        private System.Windows.Forms.Label lblDestinyPhone;
        private System.Windows.Forms.Button btnConfigurarCredenciais;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

