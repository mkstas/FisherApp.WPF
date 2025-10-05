using System.Windows;

namespace FisherApp.WPF
{
    /// <summary>
    /// Interaction logic for AuthorWindow.xaml
    /// </summary>
    public partial class AuthorWindow : Window
    {
        public AuthorWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
