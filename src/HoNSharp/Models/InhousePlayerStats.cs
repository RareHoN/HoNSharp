using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HoNSharp.Models
{
    public class InhousePlayerStats
    {
        public int Matches { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public Dictionary<string, int> Heroes { get; set; } = new Dictionary<string, int>();
    }
}
