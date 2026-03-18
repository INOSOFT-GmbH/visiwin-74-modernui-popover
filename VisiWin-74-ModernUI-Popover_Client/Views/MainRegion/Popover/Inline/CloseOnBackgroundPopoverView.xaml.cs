using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Attributes;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [PopoverView]
    [ExportView("CloseOnBackgroundPopoverView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CloseOnBackgroundPopoverView : View
    {
        public CloseOnBackgroundPopoverView()
        {
            this.InitializeComponent();
        }
    }
}
