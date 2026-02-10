using System.ComponentModel.Composition;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;

namespace HMI.Views.MainRegion.Popover
{
    [ExportView("VarOutSampleView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class VarOutSampleView : View
    {
        public VarOutSampleView()
        {
            this.InitializeComponent();
        }
    }
}
