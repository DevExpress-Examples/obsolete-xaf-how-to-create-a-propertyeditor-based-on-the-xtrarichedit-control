using System.Windows.Forms;
using DevExpress.ExpressApp;
using System.Collections.Generic;
using DevExpress.ExpressApp.RibbonUI.Win.Templates;

namespace WinSolution.Module.Win {
    public class MergeRibbonsDetailViewController : ViewController {
        public MergeRibbonsDetailViewController() {
            TargetViewType = ViewType.DetailView;
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            ((Control)View.Control).HandleCreated += Control_HandleCreated;
        }
        private void Control_HandleCreated(object sender, System.EventArgs e) {
            Control control = (Control)sender;
            control.HandleCreated -= Control_HandleCreated;
            IList<RichEditPropertyEditor> editors = ((DetailView)View).GetItems<RichEditPropertyEditor>();
            if (editors.Count > 0) {
                RichEditUserControl richEditUserControl = (RichEditUserControl)editors[0].Control;
                RibbonDetailViewForm ribbonForm = (RibbonDetailViewForm)control.FindForm();
                ribbonForm.RibbonControl.MergeRibbon(richEditUserControl.RibbonControl);
                ribbonForm.RibbonControl.ForceInitialize();
            }
        }
    }
}