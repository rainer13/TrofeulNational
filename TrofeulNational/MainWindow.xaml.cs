using System;
using System.Windows;
using TrofeulNational.DAL;
using System.Configuration;

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

            //Console.WriteLine( ConfigurationManager.AppSettings.Get("Database, Address"));
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
