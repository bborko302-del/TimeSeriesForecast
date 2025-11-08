using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace TimeSeries
{

    public class CarSales
    {
        public DateTime Date { get; set; }
        public int Sales { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //NewTimeSeriesMethod();
            Person();
        }

        private static void Person()
        {
            using (var reader = new StreamReader("../../car_sales.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>();
                foreach (var person in records)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
                }
            }
        }

        private static void NewTimeSeriesMethod()
        {
            using (var reader = new StreamReader("../../car_sales.csv"))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<CarSales>();
                foreach (var record in records)
                {
                    Console.WriteLine($"Date: {record.Date}, Sales: {record.Sales}");
                }
            }
        }
    }


}
