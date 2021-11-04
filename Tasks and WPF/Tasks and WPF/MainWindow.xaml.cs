using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tasks_and_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Creating dependency property.
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "Html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When myButton is clicked, i want to download something from the web and assign the html to the button text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            // I want to see in which thread am I on.
            //Debug.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId}");

            //// In order to download something, will use HTTP Client.
            //HttpClient webClient = new HttpClient();

            //string html = webClient.GetStringAsync("https://google.com").Result;

            //// Show done when done fetching html.
            //myButton.Content = "Done";

            // WHEN DOWNLOADING STUFF, IT IS NOT RECOMMENDED TO USE THE MAIN THREAD FOR THIS
            // BECAUSE THE MAIN THREAD IS PRIMARILY USED TO MANAGE THE UI IN THIS CASE.
            // A GOOGLE PAGE DOWNLOADS FAIRLY QUICKLY, BUT IF SOMETHING BIGGER IS DOWNLOADED,
            // THE UI WOULD FREEZE UNTIL ITS DOWNLOADED. THIS IS WHY THAT SHOULD BE DONE IN A 
            // SEPARATE TASK.

            // NOW CREATING A TASK TO RUN PREVIOUSLY RAN CODE.
            Task.Run(() =>
            {
                // I want to see in which thread am I on.
                Debug.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId}");

                // In order to download something, will use HTTP Client.
                HttpClient webClient = new HttpClient();

                string html = webClient.GetStringAsync("https://google.com").Result;

                // Using dispatcher to manage our thread for the main button.
                // The invoke method will run the specified code synchronously on the thread that
                // this dispatcher is associated with.
                myButton.Dispatcher.Invoke(() =>
                {
                    // I want to see in which thread am I on.
                    Debug.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId}");
                    // Show done when done fetching html.
                    myButton.Content = "Done";
                });

                // Show done when done fetching html.
                //myButton.Content = "Done";  // Getting an error here because a separate thread finished before this thread. (Will use Dispatcher)
            });
        }

        /// <summary>
        /// When I press this button, google.com html will be downloaded and displayed in the web browser element.
        /// This myButton_Click2 is an asynchronous method that awaits for a task to run.
        /// It's another way of performing what myButton_Click did.
        /// This way is better since you don't need to use the dispatcher to check which thread is running.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void myButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "bla";
            // View on which thread we are
            Debug.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(() =>
            {
                // View on which thread we are
                Debug.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
                
            });
            // View on which thread we are
            Debug.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} after await task");
            myButton.Content = "Done Downloading";
            // Set the web browser value.
            myWebBrowser.SetValue(HtmlProperty, myHtml);



        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
                webBrowser.NavigateToString(e.NewValue as string);
        }
    }
}
