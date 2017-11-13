using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Odbc;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using TrofeulNational.Concurent;

namespace TrofeulNational.DAL
{
    class ConexiuneMySQL : DBConection


    {

        static MySqlConnection sqlc;
        static bool isOpenb = false;

        public bool isOpen()
        {
            return isOpenb;
        }

        public ConexiuneMySQL()
        {

        }

        public override void insertConcurent()
        {
            throw new NotImplementedException();
        }

        public override void Open(string address, string uid, string pass, int port, string DB)
        {
            try
            {
                sqlc = new MySqlConnection("Server= " + address + "; Port=" + port + "; Database= " + DB + " ; Uid=" + uid + "; Pwd=" + pass + ";");

                sqlc.Open();
                isOpenb = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override void Close()
        {
            sqlc.Close();
            isOpenb = false;
        }

        public override Jucator getConcurentWithMPByID(string id)
        {
            sqlc.Close();
            sqlc.Open();
            MySqlCommand msc = new MySqlCommand("select * from jucatorimp where iid="+id+ ";", sqlc);
            MySqlDataReader reader = msc.ExecuteReader();
            if (reader.Read())
            {
                return Jucator.jucatorWithMPFromDBRow(reader);
            }
            else
                return null;
        }

        public override Jucator getJucatorByFullName(string nume, string prenume)
        {

            MySqlCommand com = new MySqlCommand("select * from jucatoriMP where nume='" + nume + "' and prenume='" + prenume + "' ;", sqlc);
            MySqlDataReader reader = com.ExecuteReader();
            return Jucator.jucatorWithMPFromDBRow(reader);

            return null;
        }

        public override List<Jucator> getJucatorByInitials(string nume, string prenume)
        {
            throw new NotImplementedException();
        }
    }
}
