using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("CustomSampleView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CustomSampleView : View
    {
        public CustomSampleView()
        {
            this.InitializeComponent();
        }
    }
}
