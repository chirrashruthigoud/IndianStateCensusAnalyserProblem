using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
        public class InvalidDataTypeException : Exception
        {
            public InvalidDataTypeException(string message) : base(message)
            {

            }
        }
}
