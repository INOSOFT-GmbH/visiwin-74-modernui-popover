using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Attributes;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [PopoverView]
    [ExportView("BarPopoverView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class BarPopoverView : View
    {
        public BarPopoverView()
        {
            this.InitializeComponent();
        }
    }
}
