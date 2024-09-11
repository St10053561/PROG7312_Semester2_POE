using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Threading;
using Newtonsoft.Json.Linq;

namespace MunicipalService
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer; // Timer for the clock
        private const string ApiKey = "80IL9jsuiEyndwnAycXG0KxTarUuwyY7"; // Your AccuWeather API key
        private const string LocationUrl = "http://dataservice.accuweather.com/locations/v1/cities/search";
        private const string WeatherUrl = "http://dataservice.accuweather.com/currentconditions/v1/";

        public MainWindow()
        {
            InitializeComponent();
            InitalizeTimer();
            FetchWeatherData();
            DisableButtons();
        }

        private void InitalizeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTimeTextBlock.Text = DateTime.Now.ToString("ddd, MMMM dd yyyy, hh:mm tt");
        }

        private async void FetchWeatherData()
        {
            string locationKey = await GetLocationKey("Cape Town");
            if (!string.IsNullOrEmpty(locationKey))
            {
                await GetWeatherConditions(locationKey);
            }
        }

        private async Task<string> GetLocationKey(string cityName)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{LocationUrl}?apikey={ApiKey}&q={cityName}";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JArray jsonArray = JArray.Parse(jsonResponse);
                    return jsonArray[0]["Key"].ToString();
                }
                else
                {
                    MessageBox.Show("Error fetching location key.");
                    return null;
                }
            }
        }

        private async Task GetWeatherConditions(string locationKey)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{WeatherUrl}{locationKey}?apikey={ApiKey}";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JArray jsonArray = JArray.Parse(jsonResponse);
                    double temperature = jsonArray[0]["Temperature"]["Metric"]["Value"].Value<double>();
                    string weatherText = jsonArray[0]["WeatherText"].ToString();
                    CurrentTemperatureTextBlock.Text = $"{temperature} °C, {weatherText}";
                }
                else
                {
                    MessageBox.Show("Error fetching weather conditions.");
                }
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            //Opening FormReportIssues
            FormReportIssues reportIssuesForm = new FormReportIssues();
            reportIssuesForm.Show();
            this.Hide();
        }

        private void FeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            FeedbackSection.Visibility = Visibility.Visible;
        }

        private void SubmitFeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            string feedback = new TextRange(FeedbackRichTxtbox.Document.ContentStart, FeedbackRichTxtbox.Document.ContentEnd).Text;
            MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButton.OK, MessageBoxImage.Information);
            FeedbackRichTxtbox.Document.Blocks.Clear();
            FeedbackSection.Visibility = Visibility.Collapsed;
        }

        private void DisableButtons()
        {
            LocalBtn.IsEnabled = false;
            ServiceBtn.IsEnabled = false;
        }
    }
}
