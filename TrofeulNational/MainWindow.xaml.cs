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
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Odbc;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using TrofeulNational.DAL;

namespace TrofeulNational
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    
    {


        DBConection con;
        public MainWindow()
        {
            InitializeComponent();
            
            con = DBFactory.getConnection(DBConection.MyDBType.MySQL);
            con.Open("localhost", "root", "r@1n3r'5M@r1@", 3306, "TN");


        }

        private void newTeamContest(object sender, RoutedEventArgs e)
        {
            Teams t = new Teams(con);
            t.Show();
        }

        private void newPairContest(object sender, RoutedEventArgs e)
        {
        }

        private void newIndividualContest(object sender, RoutedEventArgs e)
        {

        }

        private void addPlayer(object sender, RoutedEventArgs e)
        {

        }

        private void updatePlayer(object sender, RoutedEventArgs e)
        {

        }

        private void automaticallyAddMP(object sender, RoutedEventArgs e)
        {

        }

        private void automaticallyUpdateMP(object sender, RoutedEventArgs e)
        {

        }


    }
}
