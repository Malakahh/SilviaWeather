using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SilviaCore;
using SilviaCore.Controls;

namespace SilviaWeather
{
    /// <summary>
    /// Interaction logic for WeatherWindow.xaml
    /// </summary>
    public partial class WeatherWindow : StickyWindow
    {
        public WeatherWindow()
        {
            InitializeComponent();

            header.PreviewMouseDown += Header_PreviewMouseDown;
            this.PreviewMouseUp += WeatherWindow_PreviewMouseUp;

            headerOpen.Source = SilviaCore.Images.HeaderIcons.OpenNormal.ToWPFImageSource();
            headerOpen.MouseEnter += HeaderOpen_MouseEnter;
            headerOpen.MouseLeave += HeaderOpen_MouseLeave;

            patchworkGrid.CellClick += PatchworkGrid_CellClick;
        }

        private void PatchworkGrid_CellClick(PatchworkGridCell obj)
        {
            BaseControl b = new BaseControl();
            Grid.SetColumnSpan(obj, 2);
            Grid.SetRowSpan(obj, 1);
            patchworkGrid.SetCellContent(obj, b);
        }

        public override void ApplySettings(StickyWindowSettings settings = null)
        {
            WeatherWindowSettings s = Settings.GetSettings<WeatherWindowSettings>(0) ?? new WeatherWindowSettings();

            base.ApplySettings(s);
        }

        private void Header_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragStart();
            }
        }

        private void WeatherWindow_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
            {
                this.DragStop();
            }
        }

        #region headerOpen events
        private void HeaderOpen_MouseEnter(object sender, MouseEventArgs e)
        {
            headerOpen.Source = Images.HeaderIcons.OpenHighlight.ToWPFImageSource();
        }

        private void HeaderOpen_MouseLeave(object sender, MouseEventArgs e)
        {
            headerOpen.Source = Images.HeaderIcons.OpenNormal.ToWPFImageSource();
        }
        #endregion

    }

    class WeatherWindowSettings : StickyWindowSettings
    { }
}
