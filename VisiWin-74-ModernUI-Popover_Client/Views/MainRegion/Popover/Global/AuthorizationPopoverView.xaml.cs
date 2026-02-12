using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Attributes;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [PopoverView]
    [ExportView("AuthorizationPopoverView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AuthorizationPopoverView : View
    {
        public AuthorizationPopoverView()
        {
            this.InitializeComponent();
        }
    }
}
