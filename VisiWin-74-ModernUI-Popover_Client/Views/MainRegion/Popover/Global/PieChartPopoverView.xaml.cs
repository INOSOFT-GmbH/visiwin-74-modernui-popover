using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Attributes;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [PopoverView]
    [ExportView("PieChartPopoverView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PieChartPopoverView : View
    {
        public PieChartPopoverView()
        {
            this.InitializeComponent();
        }
    }
}
