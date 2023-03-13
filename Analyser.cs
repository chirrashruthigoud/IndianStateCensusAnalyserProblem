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

        public int GetRecordCount()
        {
            try
            {
                var csv_data = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\214\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\statecensus.csv").Skip(1);
                return csv_data.Count();
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("File not found.");
            }
        }
    }

    public class StateCensusAnalyser
    {
        private readonly string csv_file = "C:\\Users\\Admin\\source\\repos\\214\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\statecensus.csv";

        public StateCensusAnalyser(string csv_file)
        {
            this.csv_file = csv_file;
        }

        public int GetRecordCount()
        {
            var csv_data = new Analyser("C:\\Users\\Admin\\source\\repos\\214\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\statecensus.csv").GetRecordCount();
            return csv_data;
        }
    }
}
