using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Triangle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string pathRelativ = "resurces/triangle1.jpeg";

            Uri uri = new Uri(pathRelativ, UriKind.Relative);
            BitmapImage bitmapImage = new BitmapImage(uri);
            Image.Source = bitmapImage;
        }

        private void Butcount_Click(object sender, RoutedEventArgs e)
        {
           
            bool rezult = int.TryParse(tbEdgeA.Text,out int EdgeA);
            if(rezult==false) 
            {
                MessageBox.Show("неправильно введены даные");
                return;
            }
            rezult = int.TryParse(tbEdgeB.Text, out int EdgeB);
            if (rezult == false)
            {
                MessageBox.Show("неправильно введены даные");
                return;
            }
            rezult = int.TryParse(tbEdgeC.Text, out int EdgeC);
            if (rezult == false)
            {
                MessageBox.Show("неправильно введены даные");
                return;
            }

            if (EdgeA + EdgeB < EdgeC || EdgeC + EdgeB < EdgeA || EdgeA + EdgeC < EdgeB)
            {
                MessageBox.Show("это не треугольник");
                return;
            }
            if (EdgeA==EdgeB && EdgeA!=EdgeC || EdgeA==EdgeC && EdgeA!=EdgeB || EdgeB==EdgeC && EdgeB!=EdgeA)
            {
                MessageBox.Show("треугольник равнобедренный");
                return;
            }
            if (EdgeB == EdgeA && EdgeB == EdgeC)
            {
                MessageBox.Show("треугольник равносторонний");
                return;
            }
            else
            {
                MessageBox.Show("треугольник разносторонний");
                return;
            }

        }

        private void butErase_Click(object sender, RoutedEventArgs e)
        {
            tbEdgeA.Text = "";
            tbEdgeB.Text = "";
            tbEdgeC.Text = "";
        }

        private void butExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
