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
            LoadClientDtg();
        }
        #region Client
        /// <summary>
        /// Represent a method for adding client data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of VikingRejserEntities called context
            VikingRejserEntities context = new VikingRejserEntities();

            Create create = new Create();

            create.CreateClient(TbNameClient.Text, TbAddresseClient.Text, TbCellPhoneClient.Text);

            //Represent a messagebox showing that a client has been created
            MessageBox.Show("Bruger oprettet");

            LoadClientDtg();
        }

        /// <summary>
        /// Represent a method for editing client data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of VikingRejserEntities called _context
            VikingRejserEntities _context = new VikingRejserEntities();

            Edit edit = new Edit();

            edit.EditClient(Convert.ToInt32(TbIdClient.Text), TbNameClient.Text, TbAddresseClient.Text, TbCellPhoneClient.Text);

            //Represent a messagebox showing that a client has been edited
            MessageBox.Show("Kunde data er blevet ændret");

            LoadClientDtg();
        }
        #endregion

        #region Travel
        private void BtnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            VikingRejserEntities _context = new VikingRejserEntities();

            Create create = new Create();

            create.
        }
        #endregion



        /// <summary>
        /// Represent a method that fires a eventhandler called Window_Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Calling a method called LoadDtg
            LoadClientDtg();
        }

        #region Datagrid load methods
        /// <summary>
        /// Represent a method that loads client data to datagrid 
        /// </summary>
        public void LoadClientDtg()
        {
            //Represent a object called _ClientSource, that is used to find a resouce called ClientSource
            CollectionViewSource _clientSource = (CollectionViewSource)(this.FindResource("ClientSource"));

            //Represent a object of VikingRejserEntities called _context
            VikingRejserEntities _context = new VikingRejserEntities();

            //Access the table called Kunders and load that table
            _context.Kunders.Load();

            //sets the CollectionViewSource object _clientSource to what data that is in Kunders
            _clientSource.Source = _context.Kunders.Local;
        }

        /// <summary>
        /// Represent a that loads travel data to datagrid
        /// </summary>
        public void LoadTravelDtg()
        {
            //Represent a object called _travelSource, that is used to find a resource called TraveSource
            CollectionViewSource _travelSource = (CollectionViewSource)this.FindResource("TravelSource");

            //Represent a object of VikingRejserEntites called _context
            VikingRejserEntities _context = new VikingRejserEntities();

            //Access the table called RejseArrangementers and load that table
            _context.Rejsearrangementers.Load();

            //sets the CollectionViewSource object _travelSource to what data that is in Rejsearrangementer
            _travelSource.Source = _context.Rejsearrangementers.Local;
        }
        #endregion




    }
}
