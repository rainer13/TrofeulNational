using System.Collections.Generic;
using System.Windows;
using TrofeulNational.DAL;
using TrofeulNational.Apps;
using TrofeulNational.Concurent;

namespace TrofeulNational
{
    /// <summary>
    /// Interaction logic for Teams.xaml
    /// </summary>
    public partial class Teams : Window
    {
        DBConection conection;
        Concurenti<Echipa> echipe;
        

        public Teams(DBConection con)
        {

            conection = con;
            echipe = new Concurenti<Echipa>();
            InitializeComponent();
        }

        private void addTeams(object sender, RoutedEventArgs e)
        {
            
            string numeEchipa= NumeEchipa.Text.Equals("Nume Echipa") ? "" : NumeEchipa.Text;
            Echipa ee = new Echipa(numeEchipa);

            string[] jucatori = new string[7];

            jucatori[1] = J1.Text;
            jucatori[2] = J2.Text;
            jucatori[3] = J3.Text;
            jucatori[4] = J4.Text;
            jucatori[5] = J5.Text;
            jucatori[6] = J6.Text;

            for (int i = 1; i <= 6; ++i)
            {
                 ee.addJucator(Jucator.getFromTextBox(jucatori[i], conection));
            }
            if (ee.isValid()&&echipe.CanAdd(ee)&&checkName(numeEchipa))
            {
                Log.Text = "s-a adaugat " + ee.ToString();
                echipe.Add(ee);
            }
            else
            {

                Log.Text = "Eroare";
                if (!ee.isValid())
                    Log.Text += "echipa are un numar incorect de jucatori";
                else
                    if(!echipe.CanAdd(ee))
                        Log.Text += "un jucator mai joaca si in alta echipa";
                    else
                        Log.Text += "mai exista si o alta echipa cu acelasi nume";
            }


        }

        private HashSet<string> getTeamNames()
        {
            HashSet<string> hs = new HashSet<string>();
            foreach(Echipa e in echipe.getListaConcurenti())
                hs.Add(e.getNume());
            return hs;
        }

        private bool checkName(string nume)
        {
            HashSet<string> hs = this.getTeamNames();
            if (hs.Contains(nume))
                return false;
            return true;
        }

        private void finishButton(object sender, RoutedEventArgs e)
        {
            string s = "";
            foreach (Echipa ee in echipe.getListaConcurenti())
                s += ee.getNume() + " " + ee.getTotalMP() + "\n";
            Log.Text = s;
        }
    }
}
