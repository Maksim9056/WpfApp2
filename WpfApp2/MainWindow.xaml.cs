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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //DrawingVisual drawingVisual = new DrawingVisual();
            //using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            //{

            //}

            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Гайрат");
            list.Add("Максим");

            Items.ItemsSource = list;
        }

        private void Items_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Items_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Получить выбранный элемент
            ListBox listBox = sender as ListBox;
            if (listBox != null && listBox.SelectedItem != null)
            {
                var selectedValue = listBox.SelectedItem;
                label.Content = selectedValue.ToString();
                // Далее можно выполнить нужные действия с выбранным элементом
                // Например, вывести его значение в консоль:
                Console.WriteLine("Выбрано: " + selectedValue.ToString());
            }
        }

    }
}