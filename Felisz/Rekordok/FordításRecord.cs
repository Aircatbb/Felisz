using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felisz
{
    public class RootObject
    {
        public FordításRecord[] translations { get; set; }
    }

    public class FordításRecord
    {
        public string text { get; set; }
        public string to { get; set; }
    }
}
