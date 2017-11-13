using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data.Common;
using TrofeulNational.DAL;

namespace TrofeulNational.Concurent
{
    //[Serializable]
    public class Jucator
    {


        private string nume;
        private string prenume;
        private Int32 iid;
        private int total_mp;

        public Jucator(int i, int m, string n, string p)
        {
            prenume = p;
            nume = n;
            total_mp = m;
            iid = i;
        }


        public Jucator(int i, string n, string p)
        {
            prenume = p;
            nume = n;
            iid = i;
        }

        public Jucator(string n, string p)
        {
            nume = n;
            prenume = p;
        }

        public Int32 getIID()
        {
            return iid;
        }


        public string getNume()
        {
            return nume;
        }

        public string getPrenume()
        {
            return prenume;
        }

        public string getNumeComplet()
        {
            return nume + " ," + prenume;
        }

        public override string  ToString()
        {
            return this.getNumeComplet() + " " + iid;
        }

        //aici trebuie modificat

        public static Jucator jucatorFromDBRow(MySqlDataReader reader)
        {
            return new Jucator(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
        }

        public int getMP()
        {
            return total_mp;
        }

        public static Jucator jucatorWithMPFromDBRow(DbDataReader reader)
        {
            return new Jucator(reader.GetInt32(0), reader.GetInt32(3), reader.GetString(1), reader.GetString(2));
        }



        //adauga baza de date
        public static void createInDB(int id, String n, String p)
        {
            Jucator j = new Jucator(id, n, p);
            //db.add(j)
        }

        public static Jucator ConcurentByName()
        {
            return new Jucator(1, "a", "b");
        }

        public static Jucator ConcurentByInitials()
        {
            return new Jucator(1, "a", "b");
        }

        public static List<Jucator> ConcurentiByName()
        {
            List<Jucator> a = new List<Jucator>();
            a.Add(new Jucator(1, "a", "b"));
            return a;
        }

        public static List<Jucator> ConcurentiByInitials()
        {
            List<Jucator> a = new List<Jucator>();
            a.Add(new Jucator(1, "a", "b"));
            return a;
        }



        public static Jucator getFromTextBox(String textBoxString, DBConection con)
        {
            if (textBoxString == "" || textBoxString.StartsWith("Jucator"))
                return null;
            int n;
            bool b = int.TryParse(textBoxString, out n);
            bool b1 = textBoxString.All(char.IsDigit);
            if (b1)
            {
                return con.getConcurentWithMPByID(textBoxString);
            }
            else
            {
                //prenume, nume
                int i = textBoxString.IndexOf(',');
                return con.getJucatorByFullName(textBoxString.Substring(i + 2), textBoxString.Substring(0, i));
            }

        }

        
    }
}
