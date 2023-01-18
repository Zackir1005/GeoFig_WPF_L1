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

namespace GeoFig_WPF_L1
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
        private void ButtonCircle_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Кнопка нажата\nКруг");
            FigBack();

            Ellipse _circle = new Ellipse();
            _circle.Fill = Brushes.White;
            _circle.Stroke = Brushes.Black;
            _circle.Width = 150;
            _circle.Height = 150;
            _circle.HorizontalAlignment = HorizontalAlignment.Left;
            _circle.VerticalAlignment = VerticalAlignment.Center;
            myGrid.Children.Add(_circle);

            if (cmbColors1.Text == "Red")
            {
                _circle.Fill = Brushes.Red;
            }
            if (cmbColors1.Text == "Orange")
            {
                _circle.Fill = Brushes.Orange;
            }
            if (cmbColors1.Text == "Yellow")
            {
                _circle.Fill = Brushes.Yellow;
            }
            if (cmbColors1.Text == "Green")
            {
                _circle.Fill = Brushes.Green;
            }
            if (cmbColors1.Text == "Blue")
            {
                _circle.Fill = Brushes.Blue;
            }
            if (cmbColors1.Text == "Pink")
            {
                _circle.Fill = Brushes.Pink;
            }
            if (cmbColors1.Text == "Violet")
            {
                _circle.Fill = Brushes.Violet;
            }
        }
        private void ButtonRectangle_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Кнопка нажата\nПрямоугольник");
            FigBack();

            Rectangle _rectangle = new Rectangle();
            _rectangle.Fill = Brushes.White;
            _rectangle.Stroke = Brushes.Black;
            _rectangle.Width = 150;
            _rectangle.Height = 80;
            _rectangle.HorizontalAlignment = HorizontalAlignment.Left;
            _rectangle.VerticalAlignment = VerticalAlignment.Center;

            myGrid.Children.Add(_rectangle);
            if (cmbColors2.Text == "Red")
            {
                _rectangle.Fill = Brushes.Red;
            }
            if (cmbColors2.Text == "Orange")
            {
                _rectangle.Fill = Brushes.Orange;
            }
            if (cmbColors2.Text == "Yellow")
            {
                _rectangle.Fill = Brushes.Yellow;
            }
            if (cmbColors2.Text == "Green")
            {
                _rectangle.Fill = Brushes.Green;
            }
            if (cmbColors2.Text == "Blue")
            {
                _rectangle.Fill = Brushes.Blue;
            }
            if (cmbColors2.Text == "Pink")
            {
                _rectangle.Fill = Brushes.Pink;
            }
            if (cmbColors2.Text == "Violet")
            {
                _rectangle.Fill = Brushes.Violet;
            }
        }
        private void ButtonTriangle_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Кнопка нажата\nТреугольник");
            FigBack();

            Polygon _triangle = new Polygon();
            _triangle.Fill = Brushes.White;
            _triangle.Stroke = Brushes.Black;
            _triangle.Points.Add(new Point(0, 100));
            _triangle.Points.Add(new Point(100, 0));
            _triangle.Points.Add(new Point(200, 100));
            _triangle.HorizontalAlignment = HorizontalAlignment.Left;
            _triangle.VerticalAlignment = VerticalAlignment.Center;

            myGrid.Children.Add(_triangle);
            if (cmbColors3.Text == "Red")
            {
                _triangle.Fill = Brushes.Red;
            }
            if (cmbColors3.Text == "Orange")
            {
                _triangle.Fill = Brushes.Orange;
            }
            if (cmbColors3.Text == "Yellow")
            {
                _triangle.Fill = Brushes.Yellow;
            }
            if (cmbColors3.Text == "Green")
            {
                _triangle.Fill = Brushes.Green;
            }
            if (cmbColors3.Text == "Blue")
            {
                _triangle.Fill = Brushes.Blue;
            }
            if (cmbColors3.Text == "Pink")
            {
                _triangle.Fill = Brushes.Pink;
            }
            if (cmbColors3.Text == "Violet")
            {
                _triangle.Fill = Brushes.Violet;
            }
        }
        private void cmbColors1_SelectChang(object sender, SelectionChangedEventArgs e)
        {
            //Color selectedColor = (Color)(cmbColors1.SelectedItem as PropertyInfo).GetValue(null, null);
            //this.Background = new SolidColorBrush(selectedColor);
        }
        private void cmbColors2_SelectChang(object sender, SelectionChangedEventArgs e)
        {
            //Color selectedColor = (Color)(cmbColors2.SelectedItem as PropertyInfo).GetValue(null, null);
            //this.Background = new SolidColorBrush(selectedColor);
        }
        private void cmbColors3_SelectChang(object sender, SelectionChangedEventArgs e)
        {
            //Color selectedColor = (Color)(cmbColors3.SelectedItem as PropertyInfo).GetValue(null, null);
            //this.Background = new SolidColorBrush(selectedColor);
        }
        public void FigBack()
        {
            Rectangle _rectangle = new Rectangle();
            _rectangle.Fill = Brushes.White;
            _rectangle.Stroke = Brushes.White;
            _rectangle.Width = 250;
            _rectangle.Height = 250;
            _rectangle.HorizontalAlignment = HorizontalAlignment.Left;
            _rectangle.VerticalAlignment = VerticalAlignment.Center;
            myGrid.Children.Add(_rectangle);
        }
    }
}
