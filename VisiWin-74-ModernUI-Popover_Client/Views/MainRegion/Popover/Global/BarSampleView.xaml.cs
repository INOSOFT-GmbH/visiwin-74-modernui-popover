using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("BarSampleView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class BarSampleView : View
    {
        public BarSampleView()
        {
            this.InitializeComponent();
        }
    }
}
