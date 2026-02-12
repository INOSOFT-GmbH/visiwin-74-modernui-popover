using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("AuthorizationSampleView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AuthorizationSampleView : View
    {
        public AuthorizationSampleView()
        {
            this.InitializeComponent();
        }
    }
}
