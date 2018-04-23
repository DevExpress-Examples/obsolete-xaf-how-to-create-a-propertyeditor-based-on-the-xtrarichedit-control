using System;
using DevExpress.ExpressApp;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using DevExpress.ExpressApp.Win.Templates.ActionContainers;

namespace WinSolution.Module.Win {
    public class MergeRibbonsViewController : ViewController<DetailView> {
        private RichEditPropertyEditor editor;
        private RibbonControl mainRibbonControl;
        protected override void OnFrameAssigned() {
            base.OnFrameAssigned();
            Frame.TemplateChanged += new EventHandler(Frame_TemplateChanged);
        }
        private void UnMergeRibbon() {
            if (mainRibbonControl != null) {
                mainRibbonControl.UnMergeRibbon();
            }
        }
        private void Frame_TemplateChanged(object sender, EventArgs e) {
            UnMergeRibbon();
            mainRibbonControl = null;
            IClassicToRibbonTransformerHolder form = Frame.Template as IClassicToRibbonTransformerHolder;
            if (form != null) {
                form.RibbonTransformer.Transformed += RibbonTransformer_Transformed;
            }
        }
        private void RibbonTransformer_Transformed(object sender, EventArgs e) {
            ClassicToRibbonTransformer transformer = (ClassicToRibbonTransformer)sender;
            transformer.Transformed -= RibbonTransformer_Transformed;
            mainRibbonControl = transformer.Ribbon;
            CheckForMerge();
        }
        private void CheckForMerge() {
            if (editor != null && mainRibbonControl != null) {
                mainRibbonControl.MergeRibbon(editor.RichEditUserControl.RibbonControl);
            }
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            IList<RichEditPropertyEditor> editors = View.GetItems<RichEditPropertyEditor>();
            if (editors.Count > 0) {
                editor = editors[0];
                CheckForMerge();
            }
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            UnMergeRibbon();
            editor = null;
        }
    }
}