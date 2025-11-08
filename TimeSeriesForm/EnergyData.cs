using Microsoft.ML.Data;
using System;

namespace TimeSeriesForm
{
    internal class EnergyData
    {
        [LoadColumn(0)]
        public DateTime DateTime { get; set; }

        [LoadColumn(1)]
        public float Energy { get; set; }

    }
}