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
        public List<StatecensusData> GetCensusData()
        {
            try
            {
                var csv_data = File.ReadAllLines(csv_file).Skip(1);
                var census_data = new List<StatecensusData>();

                foreach (var line in csv_data)
                {
                    var fields = line.Split(',');
                    if (fields.Length != 4)
                    {
                        throw new InvalidDataTypeException("Invalid CSV file format.");
                    }

                    int.TryParse(fields[0], out int population);
                    int.TryParse(fields[1], out int area);
                    int.TryParse(fields[2], out int density);

                    var data = new StatecensusData
                    {
                        StateName = fields[3],
                        Population = population,
                        AreaInSquareKm = area,
                        DensityPerSquareKm = density
                    };

                    if (population == 0 || area == 0 || density == 0)
                    {
                        throw new InvalidDataTypeException("Invalid data type.");
                    }

                    census_data.Add(data);
                }

                return census_data;
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("File not found.");
            }
            catch (InvalidDataTypeException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new InvalidDataTypeException("Invalid data type.");
            }
        }
    }
}
