using HMI.Views.MainRegion.Popover;
using VisiWin.ApplicationFramework;

namespace HMI
{
    [ExportView("PopoverNavigationView")]
    public partial class PopoverNavigationView : VisiWin.Controls.View
    {
        public PopoverNavigationView()
        {
            InitializeComponent();
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            ApplicationService.SetView(this.ClosePopoversBottomRegion.Name, nameof(ClosePopoversBottomView));
        }
    }
}
