using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Security.Authentication.Identity.Provider;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP1_AsyncAwait
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage() // samma som Main
        {
            this.InitializeComponent(); // aldrig tabort
        }
        private void SyncButton_Click(object sender, RoutedEventArgs e)
        {
            ExecutionResult.Text = ""; // göra tomt
            TimeResult.Text = "";    //göra tomt
            var watch = Stopwatch.StartNew(); // kolla hur long tid nån tar- starta -

            RunExample(10);//funk. ska ha nedre


            watch.Stop();
            TimeResult.Text = watch.ElapsedMilliseconds.ToString();

        }
        private async void AsyncButton_Click(object sender, RoutedEventArgs e)
            //void kan använda på knapp=click/ async -await -Task kedja
        {
            ExecutionResult.Text = ""; // göra tomt
            TimeResult.Text = "";    //göra tomt
            var watch = Stopwatch.StartNew(); // kolla hur long tid nån tar- starta -

            await RunExampleAsync(10);//funk. ska ha nedre


            watch.Stop();
            TimeResult.Text = watch.ElapsedMilliseconds.ToString();
        }
        private void RunExample (int seconds)
            // funk. RunExemple --kan public--anlig metod
        { // for loop
            for (var i = 0; i < seconds; i++)
                ExecutionResult.Text += DoWork(i);// funk.DoWork ska nedre

            ExecutionResult.Text += "Completed";
        }

        private async Task RunExampleAsync(int seconds)
            // vi for aldrig har void på async--nån retuneras // om text->Task<string>
            
        { // for loop
            for (var i = 0; i < seconds; i++)
                ExecutionResult.Text += await Task.Run(() => DoWork(i));
            /* funk.DoWork-free göra=app kör huvud thred vidare trots att parallet 
             * körs andra thread
             => lambda expression = errow funktion = anonim funktion som köra den på egen tråd
             await = för att skicka tillbacka nånting- förvänta att nån kommer tillbacka */

            ExecutionResult.Text += "Completed";
        }
            private string DoWork(int i)// gör nån med DoWork- tar tid //
        { // i den fall --- simulering 
            Thread.Sleep(1000); //pausar  1 seconds-- stå steel
            return $"loop #{i + 1} {Environment.NewLine}";  // return text 0+1 &new rad
        }
    }
}
