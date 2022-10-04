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
using Microsoft.Win32;
using System.Drawing;
using System.IO;

namespace ISRPO_Palashicheva_PR5
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

        private void cat1_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Resources/cat_space.png", UriKind.Relative));
        }

        private void cat2_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Resources/kotcosmos.jpg", UriKind.Relative));
        }

        private void OpenD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (fileDialog.ShowDialog() == true)
            {
                //fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
                string fileName = fileDialog.FileName;
                img1.Source = new BitmapImage(new Uri(fileName));
            }
        }
    }
}
