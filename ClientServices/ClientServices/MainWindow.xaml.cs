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
using Services;
using System.Windows.Forms;

namespace ClientServices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AbstractFactoryService services = new AbstractFactoryService();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        // открыть файл вывод на форму
        private void Click_Open(object sender, RoutedEventArgs e)
        {
            var file = services.GetFileService();
            TextBox1.Text = file.OpenFile();
        }

        // сохрание файла
        private void Click_Save(object sender, RoutedEventArgs e)
        {
            var file = services.GetFileService();

            file.CreateFile(TextBox1.Text);
        }

        // удаление файла
        private void Click_Delete(object sender, RoutedEventArgs e)
        {
            var file = services.GetFileService();

            file.DeleteFile();
        }

        // перемещение файла
        private void Click_Move(object sender, RoutedEventArgs e)
        {
            var file = services.GetFileService();
            file.Move();
        }

        /////////////////////////////////////////////////////////////////


        private void Click_Load(object sender, RoutedEventArgs e)
        {

        }

        private void Click_Play(object sender, RoutedEventArgs e)
        {

        }

        private void Click_Stop(object sender, RoutedEventArgs e)
        {

        }
    }
}
