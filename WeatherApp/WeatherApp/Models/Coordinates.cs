using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models;

internal class Coordinates
{
    public double Longitude { get; }
    public double Latitude { get; }

    public Coordinates(JToken coordinateData)
    {
        if (coordinateData != null)
        {
            Longitude = double.Parse(coordinateData.SelectToken("lon").ToString(), CultureInfo.InvariantCulture);
            Latitude = double.Parse(coordinateData.SelectToken("lat").ToString(), CultureInfo.InvariantCulture);
        }
    }
}

