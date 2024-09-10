using MunicipalServicesApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class FormReportIssues : Form
    {
        List<IssueReport> issueReports = new List<IssueReport>();
        private bool isImageUploaded = false;

        public FormReportIssues()
        {
            InitializeComponent();
            this.FormClosed += FormReportIssues_FormClosed;


            // Attach the FormFieldChanged method to the relevant events
            //LocationTxtbx.TextChanged += FormFieldChanged;
            //CategoryComboBx.SelectedIndexChanged += FormFieldChanged;
            //DescriptionRichTxtbox.TextChanged += FormFieldChanged;

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Exception Handling for the form fields
                ExceptionHandling.ValidateFormFields(LocationTxtbx.Text, CategoryComboBx.Text, DescriptionRichTxtbox.Text);

                IssueReport newReport = new IssueReport
                {
                    Location = LocationTxtbx.Text,
                    Category = CategoryComboBx.SelectedItem.ToString(),
                    Description = DescriptionRichTxtbox.Text,
                    Attachment = lblFileName.Text
                };

                issueReports.Add(newReport);

                // After validating and storing the issue
                MessageBox.Show("Thank you for reporting! Your issue has been submitted.", "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LocationTxtbx.Clear();
                CategoryComboBx.SelectedIndex = -1;
                DescriptionRichTxtbox.Clear();
                lblFileName.Text = "";
                labelMsg.Text = "";
                progressBar.Value = 0;
                //isImageUploaded = false;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackToMainMenuBtn_Click(object sender, EventArgs e)
        {
            // Going back to Main Menu
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Hide();
        }

        private void MediaAttachBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;

                // Reset the progress bar for image upload
                progressBar.Value = 0;
                ProgressBarMeasure();

                lblFileName.Text = Path.GetFileName(filepath);

                //set the image to the picture box
                //isImageUploaded = true;

                //FormFieldChanged(sender, e);
                // Optionally, display a message or update the UI to indicate completion
                labelMsg.Text = "Media attached successfully!";
            }
        }

        private void ProgressBarMeasure()
        {
            // Simulate loading the media file
            progressBar.Value = 0;
            progressBar.Visible = true; // Show the progress bar
            for (int i = 0; i <= 100; i++)
            {
                // Update the progress bar
                progressBar.Value = i;
                System.Threading.Thread.Sleep(20); // Simulate work
            }
        }

        /// <summary>
        /// It allows to close the Form safely and exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormReportIssues_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormFieldChanged(object sender, EventArgs e)
        {
            int progress = 0;

            // Check if Location is filled
            if (!string.IsNullOrEmpty(LocationTxtbx.Text))
            {
                progress += 25;
            }

            // Check if Category is selected
            if (CategoryComboBx.SelectedIndex != -1)
            {
                progress += 25;
            }

            // Check if Description is filled
            if (!string.IsNullOrEmpty(DescriptionRichTxtbox.Text))
            {
                progress += 25;
            }

            // Check if Image is uploaded
            if (isImageUploaded)
            {
                progress += 25;
            }

            // Update the progress bar
            progressBar.Value = progress;
        }

    }
}
