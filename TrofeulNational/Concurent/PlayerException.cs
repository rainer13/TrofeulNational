using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrofeulNational.Concurent
{
    class PlayerException : Exception
    {
        public PlayerException(string message) : base(message)
        {
        }
    }
}
