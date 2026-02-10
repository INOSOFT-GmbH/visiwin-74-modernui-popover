using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("PieChartSampleView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PieChartSampleView : View
    {
        public PieChartSampleView()
        {
            this.InitializeComponent();
        }
    }
}
