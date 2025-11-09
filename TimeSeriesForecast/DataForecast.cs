using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;

namespace TimeSeriesForecast
{
    public class DataForecast
    {
        public DataForecast()
        {

        }

        public void GetData()
        {
            var context = new MLContext();
            var data = context.Data.LoadFromTextFile<EnergyData>("../../energy_hourly.csv",
                hasHeader: true, separatorChar: ',');


            var pipeline = context.Forecasting.ForecastBySsa(
                    "Forecast",
                    nameof(EnergyData.Energy),
                    windowSize: 5,
                    seriesLength: 10,
                    trainSize: 100,
                    horizon: 3
                );


            var model = pipeline.Fit(data);
            var forecastingEnine = model.CreateTimeSeriesEngine<EnergyData, EnergyForecast>(context);
            Forecasts = forecastingEnine.Predict();

        }

        public EnergyForecast Forecasts { get; set; }
    }
}
