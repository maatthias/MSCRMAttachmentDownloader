namespace DownloadAttachments
{
    partial class dyn365
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
            this.btn365Connect = new System.Windows.Forms.Button();
            this.discoverySvcUrl = new System.Windows.Forms.TextBox();
            this.lblDiscoverySvcUrl = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblOrg = new System.Windows.Forms.Label();
            this.txtOrg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn365Connect
            // 
            this.btn365Connect.Location = new System.Drawing.Point(195, 157);
            this.btn365Connect.Name = "btn365Connect";
            this.btn365Connect.Size = new System.Drawing.Size(75, 23);
            this.btn365Connect.TabIndex = 0;
            this.btn365Connect.Text = "connect";
            this.btn365Connect.UseVisualStyleBackColor = true;
            this.btn365Connect.Click += new System.EventHandler(this.btn365Connect_Click);
            // 
            // discoverySvcUrl
            // 
            this.discoverySvcUrl.Location = new System.Drawing.Point(170, 37);
            this.discoverySvcUrl.Name = "discoverySvcUrl";
            this.discoverySvcUrl.Size = new System.Drawing.Size(506, 20);
            this.discoverySvcUrl.TabIndex = 1;
            this.discoverySvcUrl.Text = "https://disco.crm.dynamics.com/XRMServices/2011/Discovery.svc";
            // 
            // lblDiscoverySvcUrl
            // 
            this.lblDiscoverySvcUrl.AutoSize = true;
            this.lblDiscoverySvcUrl.Location = new System.Drawing.Point(46, 37);
            this.lblDiscoverySvcUrl.Name = "lblDiscoverySvcUrl";
            this.lblDiscoverySvcUrl.Size = new System.Drawing.Size(118, 13);
            this.lblDiscoverySvcUrl.TabIndex = 2;
            this.lblDiscoverySvcUrl.Text = "Discovery Service URL";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(46, 63);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(170, 63);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(46, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Location = new System.Drawing.Point(46, 115);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(86, 13);
            this.lblOrg.TabIndex = 8;
            this.lblOrg.Text = "unique org name";
            // 
            // txtOrg
            // 
            this.txtOrg.Location = new System.Drawing.Point(170, 115);
            this.txtOrg.Name = "txtOrg";
            this.txtOrg.Size = new System.Drawing.Size(100, 20);
            this.txtOrg.TabIndex = 7;

            // 
            // dyn365
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 279);
            this.Controls.Add(this.lblOrg);
            this.Controls.Add(this.txtOrg);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lblDiscoverySvcUrl);
            this.Controls.Add(this.discoverySvcUrl);
            this.Controls.Add(this.btn365Connect);
            this.Name = "dyn365";
            this.Text = "dyn365";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn365Connect;
        private System.Windows.Forms.TextBox discoverySvcUrl;
        private System.Windows.Forms.Label lblDiscoverySvcUrl;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.TextBox txtOrg;
    }
}