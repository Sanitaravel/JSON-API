using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_API
{
    public class Ans
    {
        public Class_Coord Coord { get; set; }
        public List<Class_Weather> Weather { get; set; }
        public string Base { get; set; }
        public Class_Main main { get; set; }
        public int Visibility { get; set; }
        public Class_Wind Wind { get; set; }
        public Class_Clouds Clouds { get; set; }
        public int dt { get; set; }
        public Class_Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string name { get; set; }
        public int Cod { get; set; }
    }

    public class Class_Coord
    {
        public double Lon;
        public double Lan;
    }

    public class Class_Weather
    {
        public int Id;
        public string Main;
        public string Description;
        public string Icon;
    }

    public class Class_Main
    {
        public double Temp;
        public double Feels_like;
        public double Temp_min;
        public double Temp_max;
        public int Pressure;
        public int Humidity;
    }

    public class Class_Wind
    {
        public int Speed;
        public int Deg;
    }

    public class Class_Clouds
    {
        public int all;
    }

    public class Class_Sys
    {
        public int Type;
        public int Id;
        public string Country;
        public long Sunrise;
        public long Sunset;
    }
}
