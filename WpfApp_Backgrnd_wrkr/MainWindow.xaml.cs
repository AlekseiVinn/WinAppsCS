using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Backgrnd_wrkr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.ComponentModel.BackgroundWorker aWorker = new System.ComponentModel.BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();
            aWorker.WorkerSupportsCancellation = true;
            aWorker.DoWork += aWorker_DoWork;
            aWorker.RunWorkerCompleted += aWorker_RunWorkerCompleted;

        }

        private void aWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                Thread.Sleep(180);
                if (aWorker.CancellationPending)
                { 
                    e.Cancel = true;
                    return;
                }

                UpdateDelegate update = new UpdateDelegate(UpdateLabel);
                lbl1.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, update, i);
            }
        }

        private void aWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                lbl2.Content = "Run Completed";
            }
            else
            {
                lbl2.Content = "Run Canceled";
            }
        }

        private delegate void UpdateDelegate(int i);
        private void UpdateLabel(int i)
        {
            lbl1.Content = "Cycles: " + i.ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            aWorker.RunWorkerAsync();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            aWorker.CancelAsync();
        }
    }
}