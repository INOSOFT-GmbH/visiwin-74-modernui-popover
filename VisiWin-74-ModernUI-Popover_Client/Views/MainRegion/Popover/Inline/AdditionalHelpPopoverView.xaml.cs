using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Attributes;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [PopoverView]
    [ExportView("AdditionalHelpPopoverView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AdditionalHelpPopoverView : View
    {
        public AdditionalHelpPopoverView()
        {
            this.InitializeComponent();
        }
    }
}
