using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrofeulNational
{
    class ConnectionNotConfiguredException : Exception
    {

        public override string ToString()
        {
            return "datele de conectare la baza de date nu sunt confugurate bine sau lipsesc";
        }

    }
}
