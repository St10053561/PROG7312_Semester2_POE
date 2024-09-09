using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class FormReportIssues : Form
    {
        public FormReportIssues()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Handle form submission
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

                // Simulate loading the media file
                progressBar.Value = 0;
                for (int i = 0; i <= 100; i++)
                {
                    // Update the progress bar
                    progressBar.Value = i;
                    System.Threading.Thread.Sleep(20); // Simulate work
                }

                // Optionally, display a message or update the UI to indicate completion
                labelMsg.Text = "Media attached successfully!";
            }
        }

        private void FormFieldChanged(object sender, EventArgs e)
        {
            int progress = 0;

            // Check if Location is filled
            if (!string.IsNullOrEmpty(LocationTxtbx.Text))
            {
                progress += 33;
            }

            // Check if Category is selected
            if (CategoryComboBx.SelectedIndex != -1)
            {
                progress += 33;
            }

            // Check if Description is filled
            if (!string.IsNullOrEmpty(DescriptionRichTxtbox.Text))
            {
                progress += 34;
            }

            // Update the progress bar
            progressBar.Value = progress;
        }
    }
}
