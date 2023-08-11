using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models;
internal class Clouds
{
    public double All { get; }

    public Clouds(JToken cloudData)
    {
        if (cloudData != null)
            All = double.Parse(cloudData.SelectToken("all").ToString(), CultureInfo.InvariantCulture);
    }
}


