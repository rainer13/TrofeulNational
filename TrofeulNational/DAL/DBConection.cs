using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrofeulNational.Concurent;

namespace TrofeulNational.DAL
{
    public abstract class DBConection
    {

        public enum MyDBType { MySQL, MSSQL, Cloudscape, Oracle};

        public abstract void insertConcurent();

        public abstract void Open(string address, string uid, string pass, int port, string DB);

        public abstract void Close();

        public abstract Jucator getConcurentWithMPByID(string id);

        public abstract List<Jucator> getJucatorByInitials(string nume, string prenume);

        public abstract Jucator getJucatorByFullName(string nume, string prenume);


    }
}
