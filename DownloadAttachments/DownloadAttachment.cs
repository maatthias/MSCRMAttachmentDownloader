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
    public partial class DownloadAttachment : Form
    {
        IOrganizationService _service = null;
        public DownloadAttachment(IOrganizationService service)
        {

            InitializeComponent();
            _service = service;
        }

        private void MessageText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadButton.Enabled = false;
            BackButton.Enabled = false;

            MessageText.Text = "";
            

            if (String.IsNullOrEmpty(outputpath.Text))
            { MessageText.Text = "Please select a folder to download."; DownloadButton.Enabled = true; BackButton.Enabled = true; return; }
            if (String.IsNullOrEmpty(FetchXMLData.Text))
            { MessageText.Text = "Please provide a valid fetch xml."; DownloadButton.Enabled = true; BackButton.Enabled = true; return; }

         

            String Location = @"" + outputpath.Text;
            String fetch = FetchXMLData.Text.Replace("\"", "\'");
            EntityCollection enColl = _service.RetrieveMultiple(new FetchExpression(fetch));
            int i = 0;
            MessageText.AppendText("Total records found: " + enColl.Entities.Count);
            MessageText.AppendText(Environment.NewLine);
            if (enColl.Entities.Count == 0)
            {
                MessageText.AppendText("No records found for this fetch xml. Please try again");
                MessageText.AppendText(Environment.NewLine);

                DownloadButton.Enabled = true;
                BackButton.Enabled = false;
                return;
            }
            else if (enColl.Entities.Count == 5000)
            {
                MessageText.AppendText("More than 4999 records can't be processed in one go for downloading. Please provide smaller set xml.");
                MessageText.AppendText(Environment.NewLine);
                DownloadButton.Enabled = true;
                BackButton.Enabled = false;
                return;
            }

            foreach (Entity en in enColl.Entities)
            {
                try
                {
                    QueryExpression qe = new QueryExpression("annotation");
                    qe.Criteria.AddCondition("objectid", ConditionOperator.Equal, en.Id);
                    qe.ColumnSet = new ColumnSet(true);
                    EntityCollection AnnotationColl = _service.RetrieveMultiple(qe);
                   
                    foreach (Entity annotationRec in AnnotationColl.Entities)
                    {
                        if (annotationRec.Contains("filename"))
                        {
                            // String Location = @"C:\test\";
                            String filename = annotationRec.GetAttributeValue<String>("filename");
                            String noteBody = annotationRec.GetAttributeValue<String>("documentbody");
                            string outputFileName = @"" + Location +"\\"+ filename;

                            if (!string.IsNullOrEmpty(noteBody))
                            {
                                // Download the attachment in the current execution folder.
                                byte[] fileContent = Convert.FromBase64String(noteBody);
                                System.IO.File.WriteAllBytes(outputFileName, fileContent);
                                MessageText.AppendText(++i + " files downloaded. File name: " + filename);
                                MessageText.AppendText(Environment.NewLine);
                                
                            }
                            else
                            {
                                MessageText.AppendText("File content is empty or cannot be retrieved");
                                MessageText.AppendText(Environment.NewLine);
                            }


                        }
                    }
                } catch (Exception ex)
                {
                    MessageText.AppendText("Error in downloading attachments.Details:" + ex.Message);
                    MessageText.AppendText(Environment.NewLine);
                    DownloadButton.Enabled = true;
                    BackButton.Enabled = true;
                    return;
                }

            }
            MessageText.AppendText("Downloading completed.");
            MessageText.AppendText(Environment.NewLine);
         
            DownloadButton.Enabled = true;
            BackButton.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1  = new System.Windows.Forms.FolderBrowserDialog(); ;
            folderBrowserDialog1.Description = "Please create/select a folder";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)

            {
                outputpath.Text = folderBrowserDialog1.SelectedPath;

                Environment.SpecialFolder root = folderBrowserDialog1.RootFolder;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(outputpath.Text))
            {
                System.Diagnostics.Process.Start(outputpath.Text);
            }
            else
            {
                MessageText.AppendText("First select a download location.");
                MessageText.AppendText(Environment.NewLine);

            }
        }
    }
}
