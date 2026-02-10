using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Attributes;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [PopoverView]
    [ExportView("VarOutPopoverView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class VarOutPopoverView : View
    {
        public VarOutPopoverView()
        {
            this.InitializeComponent();
        }
    }
}
