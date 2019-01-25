using System;
using System.Collections.Generic;
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
            ProgressBarFertigEvent += IchHabeFertig;
        }

        private void IchHabeFertig(object sender, EventArgs e)
        {
            MessageBox.Show("Ende");
        }

        public event EventHandler ProgressBarFertigEvent;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Start");
            MachEtwas();
        }

        private void MachEtwas()
        {
            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    // "UI-Thread, bitte führe für mich diesen code aus:"
                    Dispatcher.Invoke(() => progressBarFortschritt.Value = i);
                    Thread.Sleep(100);
                }
                ProgressBarFertigEvent?.Invoke(this, EventArgs.Empty);
            });
        }
    }
}
