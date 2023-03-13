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
            try
            {
                var csv_data = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\214\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\statecensus.csv").Skip(1);
                Console.WriteLine(csv_data.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
