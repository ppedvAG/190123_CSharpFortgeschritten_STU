using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace AsyncUndAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // async void => NICHT VERWENDEN, nur in EventHandler (wo es nicht anders geht)
        // -> Expeption können nicht weitergegeben werden, wenn es keine Rückgabe gibt

        // async Task => IMMER VERWENDEN (auch bei Methoden, die normalerweise void zurückgeben)
        // async Task<T> => IMMER verwenden, wenn es eine Rückgabe gibt

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            GibUhrzeit();

            MessageBox.Show("Start");
            await  MachEtwas(); // Wartet hier wie Task.WaitAll(), ABER der UI-Thread kann währenddessen weitermachen und blockiert NICHT
            MessageBox.Show("Ende");

        //    StreamReader sr = new StreamReader("demo.txt");
        //    string zeile = sr.ReadLine(); // Synchron - Blockiert
        //    zeile = sr.ReadLineAsync().Result; // Asynchrone logik synchron aufrufen - Blockiert
        //    zeile = await sr.ReadLineAsync(); // Asynchron - Blockiert nicht
        }

        private Task MachEtwas()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    // "UI-Thread, bitte führe für mich diesen code aus:"
                    Dispatcher.Invoke(() => progressBarFortschritt.Value = i);
                    Thread.Sleep(100);
                }
            });
        }

        private async void GibUhrzeit()
        {
            Task.Run(() => {
                throw new FormatException();
            });
        }
    }
}
