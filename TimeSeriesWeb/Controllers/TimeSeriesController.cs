using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;
using TimeSeriesForecast;

namespace TimeSeriesWeb.Controllers
{
    public class TimeSeriesController : Controller
    {
        // GET: TimeSpan
        public ActionResult TimeSeries()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetTimeSeriesData()
        {
            /*
            var dataForecast = new DataForecast();
            dataForecast.GetData();

            var gridData = new List<ForecastEnergyData>();
            var id = 0;
            foreach (var forecast in dataForecast.Forecasts.Forecast)
            {
                id++;
                gridData.Add(new ForecastEnergyData { ID = id, EnergyHour = "KW", forecast = forecast.ToString() });
            }
            */
            

            var gridData = new List<ForecastEnergyData>();
            gridData.Add(new ForecastEnergyData { ID = 1, EnergyHour = "KW", forecast = "10400" });
            gridData.Add(new ForecastEnergyData { ID = 2, EnergyHour = "KW", forecast = "11400" });
            gridData.Add(new ForecastEnergyData { ID = 3, EnergyHour = "KW", forecast = "12400" });
            return Json(gridData);
        }

    }
    public class ForecastEnergyData
    {
        public int ID { get; set; }
        public string EnergyHour { get; set; }
        public string forecast { get; set; }
    }
}