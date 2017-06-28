using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using SilviaCore;

namespace SilviaWeather
{
    class BaseControl : UserControl
    {


        public BaseControl()
        {
            Rectangle r = new Rectangle();
            r.Fill = new System.Windows.Media.SolidColorBrush().SetRGB(0xFF00FF);

            this.Content = r;
        }
    }
}
