using System;
using TrofeulNational.Concurent;

namespace TrofeulNational.Apps
{
    [Serializable]
    public class Echipa:Concurent
    {

        protected string nume;

        public override string ToString()
        {
            string ret = "echipa cu numele ";
            ret += nume + " si avand jucatorii:";
            Int32 m = new Int32();
            m = getTotalMP();
            foreach (Jucator j in jucatori)
            {
                ret += j.getNumeComplet() + ", ";
            }

            ret = ret.Substring(0, ret.Length - 1);
            ret += " si are un numar de ";
            ret += m.ToString();
            ret+= " puncte de expert";

            return ret;
        }

        public Echipa():base()
        {
        }

        public Echipa(string n) : base()
        {
            nume = n;
        }

        

        public bool isValid()
        {
            if (jucatori.Count < 4 || jucatori.Count > 6)
                return false;
            if (nume == null)
                return false;
            if (nume.Equals(""))
                return false;
            return true;
        }

        

        public string getNume()
        {
            return nume;
        }

    }
}
