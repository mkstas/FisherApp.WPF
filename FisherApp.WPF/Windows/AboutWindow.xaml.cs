using System.Windows;

namespace FisherApp.WPF
{
    /// <summary>
    /// Interaction logic for AboutModal.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
