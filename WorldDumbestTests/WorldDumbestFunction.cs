using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldDumbestTests
{
    class WorldDumbestFunction
    {
        public string TrafficLights(string status)
        {
            switch (status)
            {
                case "RED": return "STOP";
                case "YELLOW": return "SLOW"; 
                case "GREEN": return "GO";
                default: return " ";
            }
        }
    }    
}
