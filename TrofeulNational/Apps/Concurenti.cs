using System;
using System.Collections.Generic;
using System.Linq;

namespace TrofeulNational.Apps
{
    //[Serializable]
    class Concurenti<T> where T : Concurent
    {

        private List<T> concurenti;

        public void Add(T x)
        {
            concurenti.Add(x);
        }

        public Concurenti(){
            concurenti = new List<T>();
        }

        public bool CanAdd(T x)
        {
            HashSet<int> indexiNoi = x.getConcurenti();
            HashSet<int> indexiMei = this.getConcurenti();
            if (indexiMei.Count == 0)
                return true;
            if (indexiMei.Intersect(indexiNoi).Count() == 0)
                return true;
            else
                return false;

        }

        public HashSet<int> getConcurenti()
        {
            HashSet<int> hs = new HashSet<int>();
            foreach(T x in concurenti)
                hs.UnionWith(x.getConcurenti());
            return hs;
        }

        public List<T> getListaConcurenti()
        {
            return concurenti;
        }

    }
}
