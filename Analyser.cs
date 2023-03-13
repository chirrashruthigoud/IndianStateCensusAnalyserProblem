using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class Analyser
    {

        private readonly string csv_file = "C:\\Users\\Admin\\source\\repos\\214\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\statecensus.csv";
        public Analyser(string csv_file)
        {
            this.csv_file = csv_file;
        }

    }
}
