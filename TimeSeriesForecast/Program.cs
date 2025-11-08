using System;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;
using System.Collections.Generic;
using System.IO;


namespace TimeSeriesForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetForecast();

            Console.ReadLine();
        }

        private static void GetForecast()
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
            var forecasts = forecastingEnine.Predict();

            foreach (var forecast in forecasts.Forecast)
            {
                Console.WriteLine(forecast);
            }
        }
    }
}
