using System.Windows;
using RMS.Client.WPF.Services;

namespace RMS.Client.WPF
{
    public partial class MainWindow : Window
    {
        private readonly AuthService _authService = new AuthService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            lblStatus.Text = "Logowanie...";
            
            var token = await _authService.LoginAsync(username, password);

            if (token != null)
            {
                lblStatus.Foreground = System.Windows.Media.Brushes.Green;
                lblStatus.Text = "Zalogowano pomyślnie!";
                
                // Tutaj później dodamy otwieranie głównego okna programu
                MessageBox.Show($"Twój token: {token.Substring(0, 20)}...", "Sukces!");
            }
            else
            {
                lblStatus.Foreground = System.Windows.Media.Brushes.Red;
                lblStatus.Text = "Błąd logowania. Sprawdź dane.";
            }
        }
    }
}