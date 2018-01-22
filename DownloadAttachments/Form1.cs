using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
namespace DownloadAttachments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {

            MessageText.Text = "";
            Connect.Enabled = false;
            
            if (String.IsNullOrEmpty(orgurl.Text))
            { MessageText.Text = "Org url is empty.";Connect.Enabled = true;return; }
            if (String.IsNullOrEmpty(domainname.Text))
            { MessageText.Text = "Domain Name is empty."; Connect.Enabled = true; return; }
            if (String.IsNullOrEmpty(username.Text))
            { MessageText.Text = "User Name is empty."; Connect.Enabled = true; return; }
            if (String.IsNullOrEmpty(password.Text))
            { MessageText.Text = "Password is empty."; Connect.Enabled = true; return; }
           
          
            else { MessageText.Text = ""; }


            #region ConnecttoCRM
            IOrganizationService service = null;
            try
            {
                ClientCredentials cre = new ClientCredentials();
                cre.Windows.ClientCredential.Domain = domainname.Text;
                cre.Windows.ClientCredential.UserName = username.Text;
                cre.Windows.ClientCredential.Password = password.Text;

                Uri serviceUri = new Uri(orgurl.Text);
                OrganizationServiceProxy proxy = new OrganizationServiceProxy(serviceUri, null, cre, null);
                proxy.EnableProxyTypes();
                service = (IOrganizationService)proxy;
            }
            catch (Exception ex)
            {
                MessageText.AppendText("Error in connecting to crm instance.");
                MessageText.AppendText(Environment.NewLine);
                MessageText.AppendText(ex.Message);
                MessageText.AppendText(Environment.NewLine);
                Connect.Enabled = true;
                return;
            }
            #endregion

            if (service == null)
            {
                MessageText.Text = "Organisation service object is null. Contact administrator.";
                Connect.Enabled = true;
                return;
            }

            // DownloadAttachment obj1 = new DownloadAttachment();
            //this.Hide();
            //obj1.Show();


            DownloadAttachment obj1 = new DownloadAttachment(service);
            obj1.Show();
            this.Hide();

        }


     


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/dynamics365blocks/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://crmblocks.blogspot.in/");

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://dynamics365blocks.wordpress.com/");
        }
            
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://msdn.microsoft.com/en-in/library/gg328127.aspx");
        }
    }
}
