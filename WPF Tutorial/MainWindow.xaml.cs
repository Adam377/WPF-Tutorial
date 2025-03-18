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

namespace WPF_Tutorial;

public partial class MainWindow : Window
{
    private bool _running = false;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnToggleRun_Click(object sender, RoutedEventArgs e)
    {
        if (_running)
        {
            // stop
            tbStatus.Text = "Stopped";
            btnToggleRun.Content = "Run";
        }
        else
        {
            // run
            tbStatus.Text = "Running";
            btnToggleRun.Content = "Stop";
        }

        _running = !_running;
    }
}