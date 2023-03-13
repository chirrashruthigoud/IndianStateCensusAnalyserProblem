using IndianStateCensusAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
                var file = "C:\\Users\\Admin\\source\\repos\\214\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\statecensus.csv";
            try
            {
                var analyser = new StateCensusAnalyser(file);
                var recordCount = analyser.GetRecordCount();
                Console.WriteLine($"{file}: Number of records: {recordCount}");
            }
            catch (InvalidDataTypeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
