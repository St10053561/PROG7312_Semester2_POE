using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using MunicipalService.Classes;

namespace MunicipalService
{
    /// <summary>
    /// Interaction logic for FormReportIssues.xaml
    /// </summary>
    public partial class FormReportIssues : Window
    {
        List<IssueReport> issueReports = new List<IssueReport>();
        private bool isImageUploaded = false;
        private List<string> attachedFiles = new List<string>();
        private BackgroundWorker backgroundWorker;

        public FormReportIssues()
        {
            InitializeComponent();
            this.Closed += FormReportIssues_FormClosed;
            this.progressBar.Visibility = Visibility.Hidden;

            // Initialize BackgroundWorker
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Exception Handling for the form fields
                ExceptionHandling.ValidateFormFields(LocationTxtbx.Text, CategoryComboBx.Text, new TextRange(DescriptionRichTxtbox.Document.ContentStart, DescriptionRichTxtbox.Document.ContentEnd).Text);

                IssueReport newReport = new IssueReport
                {
                    Location = LocationTxtbx.Text,
                    Category = CategoryComboBx.SelectedItem.ToString(),
                    Description = new TextRange(DescriptionRichTxtbox.Document.ContentStart, DescriptionRichTxtbox.Document.ContentEnd).Text,
                    Attachment = string.Join(", ", attachedFiles)
                };

                issueReports.Add(newReport);

                // After validating and storing the issue
                MessageBox.Show("Thank you for reporting! Your issue has been submitted.", "Submission Successful", MessageBoxButton.OK, MessageBoxImage.Information);

                LocationTxtbx.Clear();
                CategoryComboBx.SelectedIndex = -1;
                DescriptionRichTxtbox.Document.Blocks.Clear();
                lblFileName.Content = "";
                progressBar.Value = 0;
                attachedFiles.Clear();
                isImageUploaded = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BackToMainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            // Going back to Main Menu
            MainWindow mainMenu = new MainWindow();
            mainMenu.Show();
            this.Hide();
        }

        private void MediaAttachBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.Multiselect = true; // Allow multiple file selection

            if (openFileDialog.ShowDialog() == true)
            {
                attachedFiles.AddRange(openFileDialog.FileNames);

                // Reset the progress bar for image upload
                progressBar.Value = 0;
                progressBar.Visibility = Visibility.Visible; // Show the progress bar
                backgroundWorker.RunWorkerAsync();

                // Set the image upload flag
                isImageUploaded = true;
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                // Simulate work
                System.Threading.Thread.Sleep(20);
                backgroundWorker.ReportProgress(i);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

            if (e.ProgressPercentage == 100)
            {
                lblFileName.Content = string.Join(", ", attachedFiles.Select(file => System.IO.Path.GetFileName(file)));
            }
        }

        /// <summary>
        /// It allows to close the Form safely and exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormReportIssues_FormClosed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
