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
using Entities;
using DataAccess.CRUD;
using System.Data.Entity;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            VikingRejserEntities context = new VikingRejserEntities();

            Create create = new Create();

            create.CreateClient(TbNameClient.Text, TbAddresseClient.Text, TbCellPhoneClient.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource _ClientSource = (CollectionViewSource)(this.FindResource("ClientSource"));

            VikingRejserEntities _context = new VikingRejserEntities();

            _context.Kunders.Load();

            _ClientSource.Source = _context.Kunders.Local;
        }
    }
}
