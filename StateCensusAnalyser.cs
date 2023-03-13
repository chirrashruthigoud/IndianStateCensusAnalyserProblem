using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class StateCensusAnalyser
    {
        private readonly string csv_file = "C:\\Users\\Admin\\source\\repos\\214\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\statecensus.csv";

        public StateCensusAnalyser(string csv_file)
        {
            this.csv_file = csv_file;
        }

        public int GetRecordCount()
        {
            var csv_data = new Analyser(csv_file).GetCensusData();
            return csv_data.Count;
        }
    }
}
