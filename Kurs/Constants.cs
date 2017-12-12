using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    /// <summary>
    /// Константы, описывающие параметры вычислительной системы
    /// </summary>
    public static class Constants
    {
        public const int ServersCount = 3;
        public const int BufferSize = 0;

        public static class ProgrammPopupTime
        {
            public const double LinearMinTime = 1.0/3.0;
            public const double LinearMaxTime = 2.0/3.0;

            public const double ExpLambda = 2.0;
        }

        public static class ProgrammExecutionTime
        {
            public const double LinearMinTime = 1;
            public const double LinearMaxTime = 5;

            public const double ExpAvgExecutionTime = 3.0;
        }



        public const int SimulationTime = 60 * 60;
        public const double SimulationStep = 0.001;
    }
}
