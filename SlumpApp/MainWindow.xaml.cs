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

namespace SlumpApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {

        // Läsa av max värde

         if (!int max = int.Parse(tbxMax.Text) + 1;)

        // Slumpa ett tal mellan 1 och 100
        int slumptal = Random.Shared.Next(1, 101);

        txbResultat.Text = $"{slumptal}";

    }
}