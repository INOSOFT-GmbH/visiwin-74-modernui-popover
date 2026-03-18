using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("CloseOnBackgroundView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CloseOnBackgroundView : View
    {
        public CloseOnBackgroundView()
        {
            this.InitializeComponent();
        }
    }
}
