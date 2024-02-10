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
using System.IO;

namespace Practice1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isDataDirty = false;
        public MyWindow myWin { get; set; }
        string nameFile = "username.txt";

        public MainWindow()
        {
            InitializeComponent();
            lbl.Content = "Добрый день!";
            setBut.IsEnabled = false; 
            retBut.IsEnabled = false;
            Top = 25;
            Left = 25;

            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = CustomCommands.Launch;
            commandBinding.Executed += new ExecutedRoutedEventHandler(Launch_Handler);
            commandBinding.CanExecute += new CanExecuteRoutedEventHandler(LaunchEnabled_Handler);
            this.CommandBindings.Add(commandBinding);

        }

        private void SetBut()
        {
            using (StreamWriter sw = new System.IO.StreamWriter(nameFile))
            {
                sw.WriteLine(setText.Text);
            }
            retBut.IsEnabled = true;
            isDataDirty = false;
        }

        private void RetBut()
        {
            using (StreamReader sr = new StreamReader(nameFile))
            {
                retLable.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
            }
        }

        private void setText_TextChanged(object sender, TextChangedEventArgs e)
        {
            setBut.IsEnabled = true;
            isDataDirty = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.isDataDirty)
            {
                string msg = "Данные были изменены, но не сохранены!\n Закрыть окно без сохранения?";
                MessageBoxResult result = MessageBox.Show(msg, "Контроль данных", MessageBoxButton.YesNo, MessageBoxImage.Warning); 
                if (result == MessageBoxResult.No) 
                { 
                    e.Cancel = true; 
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs args)
        { 
            Close();
        }

        /*private void New_Win_Click(object sender, RoutedEventArgs e)
        {
            if (myWin == null) 
                myWin = new MyWindow();
            myWin.Owner = this;
            //myWin.Top = this.Top;
            //myWin.Left = this.Left + this.Width;

            var location = New_Win.PointToScreen(new Point(0, 0));
            myWin.Top = location.Y;
            myWin.Left = location.X + New_Win.Width;
            
            myWin.Show();
        }*/
        private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            if (myWin == null)
                myWin = new MyWindow();
            myWin.Owner = this;
            var location = New_Win.PointToScreen(new Point(0, 0));
            myWin.Top = location.Y;
            myWin.Left = location.X + New_Win.Width;

            myWin.Show();
        }
        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement element = e.Source as FrameworkElement;
            try
            {
                switch (element.Name)
                {
                    case "setBut":
                        SetBut();
                        break;
                    case "retBut":
                        RetBut();
                        break;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LaunchEnabled_Handler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (bool)check.IsChecked;
        }

    }
}