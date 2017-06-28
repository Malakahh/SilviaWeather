using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilviaWeather
{
    public class SilviaWeather : SilviaCore.Plugin
    {
        public override string PluginName => "SilviaWeather";

        public override void OnLoad()
        {
            new WeatherWindow().Show();
        }
    }
}
