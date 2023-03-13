using static IndianStateCensusAnalyserProblem.Analyser;

namespace IndianStateCensusAnalyserProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
                string filePath = "state_census.csv";
                var analyser = new StateCensusAnalyser(filePath);
                int numberOfRows = analyser.GetNumberOfRows();
                Console.WriteLine($"Number of rows: {numberOfRows}");
        }
    }
}