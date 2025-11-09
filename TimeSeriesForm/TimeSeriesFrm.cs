using Microsoft.ML;
using Microsoft.ML.Transforms.TimeSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSeriesForm
{
    public partial class TimeSeriesFrm : Form
    {
        public TimeSeriesFrm()
        {
            InitializeComponent();
        }

        private void GetForecast()
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

            DataTable dt = new DataTable();

            // Add columns
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("EnergyHour", typeof(string));
            dt.Columns.Add("forecast", typeof(double));

            var id = 0;
            foreach (var forecast in forecasts.Forecast)
            {
                id++;
                dt.Rows.Add(id, "Kw", forecast);                
            }

            dgvForecast.DataSource = dt;
        }

        private void TimeSeriesFrm_Shown(object sender, EventArgs e)
        {
            GetForecast();
        }
    }
}
