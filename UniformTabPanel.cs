using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace FRSP_Carta
{
    public class UniformTabPanel : UniformGrid
    {
        public UniformTabPanel()
        {
            this.IsItemsHost = true;
            this.Rows = 1;

            this.HorizontalAlignment = HorizontalAlignment.Stretch;
        }

        protected override Size MeasureOverride(Size constraint)
        {
            var totalMaxWidth = this.Children.OfType<TabItem>().Sum(tab => tab.MaxWidth);
            if (!double.IsInfinity(totalMaxWidth))
            {
                this.HorizontalAlignment = (constraint.Width > totalMaxWidth)
                    ? HorizontalAlignment.Left
                    : HorizontalAlignment.Stretch;
            }

            return base.MeasureOverride(constraint);
        }
    }
}
