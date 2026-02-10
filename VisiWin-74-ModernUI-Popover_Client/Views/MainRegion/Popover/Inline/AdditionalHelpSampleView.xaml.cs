using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("AdditionalHelpSampleView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AdditionalHelpSampleView : View
    {
        public AdditionalHelpSampleView()
        {
            this.InitializeComponent();
        }
    }
}
