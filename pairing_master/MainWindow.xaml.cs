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

namespace pairing_master;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        // Générer dynamiquement la grille de TextBox
        for (int row = 0; row < 8; row++)
        {
            myGrid.RowDefinitions.Add(new RowDefinition());

            for (int col = 0; col < 8; col++)
            {
                if (row == 0)
                    myGrid.ColumnDefinitions.Add(new ColumnDefinition());

                TextBox textBox = new TextBox
                {
                    Text = "0",
                    Width = 30,
                    Height = 20,
                    Margin = new Thickness(0),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center
                };

                Grid.SetRow(textBox, row);
                Grid.SetColumn(textBox, col);

                myGrid.Children.Add(textBox);
            }
        }
    }
}
