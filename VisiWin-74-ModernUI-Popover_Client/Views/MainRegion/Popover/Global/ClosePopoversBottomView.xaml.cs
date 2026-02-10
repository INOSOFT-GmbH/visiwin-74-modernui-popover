using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("ClosePopoversBottomView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ClosePopoversBottomView : View
    {
        public ClosePopoversBottomView()
        {
            this.InitializeComponent();
        }
    }
}
