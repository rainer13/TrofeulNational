using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrofeulNational.Concurent;

namespace TrofeulNational.Apps
{
    [Serializable]
    public class Concurent
    {


        protected List<Jucator> jucatori;

        public Concurent()
        {
            jucatori = new List<Jucator>();
        }

        public void addJucator(Jucator j)
        {
            if(j!=null)
                jucatori.Add(j);
        }

        public int getTotalMP()
        {
            int t = 0;
            foreach (Jucator j in jucatori)
                t += j.getMP();
            return t;
        }

        public HashSet<int> getConcurenti()
        {
            HashSet<int> indexi = new HashSet<int>();
            foreach (Jucator j in jucatori)
                indexi.Add(j.getIID());
            return indexi;
        }

        public bool canAdd(List<Concurent> l)
        {
            HashSet<int> thisIndexi = this.getConcurenti();


            return true;
        }

       
    }
}
