using IndianStateCensusAnalyserProblem;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string file1 = "statecensus.csv";
            var analyser1 = new StateCensusAnalyser(file1);
            var recordCount1 = analyser1.GetRecordCount();
            Console.WriteLine($"{file1}: Number of records: {recordCount1}");
        }
    }
}