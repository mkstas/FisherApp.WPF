using FisherApp.WPF.Windows;
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

namespace FisherApp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isStart = false;
        public bool isPause = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenColorsWindow_Click(object sender, RoutedEventArgs e)
        {
            ColorsWindow colorsWindow = new();
            colorsWindow.ShowDialog();
        }

        private void OpenInitialWindow_Click(object sender, RoutedEventArgs e)
        {
            InitialWindow initialWindow = new();
            initialWindow.ShowDialog();
        }

        private void OpenAboutWindow_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new();
            aboutWindow.ShowDialog();
        }

        private void OpenAuthorWindow_Click(object sender, RoutedEventArgs e)
        {
            AuthorWindow authorWindow = new();
            authorWindow.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            isStart = !isStart;

            if (isStart)
            {
                startBtn.Content = "Старт";
            }

            if (!isStart)
            {
                startBtn.Content = "Стоп";
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            isPause = !isPause;

            if (isPause)
            {
                pauseBtn.Content = "Продолжить";
            }

            if (!isPause)
            {
                pauseBtn.Content = "Пауза";
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}