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
            string server, user, pass, port, db, type;
            var conMng = ConfigurationManager.GetSection("ConnectionManagerDatabaseServers") as System.Collections.Specialized.NameValueCollection;
            if (conMng != null)
            {
                //vezi http:/ 
                //blog.danskingdom.com
                //adding-and-accessing-custom-sections-in-your-c-app-config
                server = conMng["Server"].ToString();
                user = conMng["User"].ToString();
                pass = conMng["Password"].ToString();
                port = conMng["Port"].ToString();
                db = conMng["NumeDB"].ToString();
                type = conMng["tip"].ToString();
                //Console.WriteLine(server + " " + user + " " + pass + " " + port + " " + db + " " + db);
                switch (type)
                {
                    case "MySQL": con = DBFactory.getConnection(DBConection.MyDBType.MySQL); break;
                    default: con = null; throw new ConnectionNotConfiguredException();
                }
                con.Open(server, user, pass, Int32.Parse(port), db);
            }
            else
                throw new ConnectionNotConfiguredException();
            


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
