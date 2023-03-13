using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class StatecensusData
    {
        public string StateName { get; set; }
        public int Population { get; set; }
        public int AreaInSquareKm { get; set; }
        public int DensityPerSquareKm { get; set; }
    }
}
