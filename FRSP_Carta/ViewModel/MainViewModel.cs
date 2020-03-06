using System;
using OxyPlot;
using OxyPlot.Series;

namespace FRSP_Carta.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            MyModel = new PlotModel { Title = "Carta" };
            MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
        }

        public PlotModel MyModel
        {
            get;
            private set;
        }
    }
}
