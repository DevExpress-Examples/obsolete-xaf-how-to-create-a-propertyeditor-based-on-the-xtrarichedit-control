using System;
using DevExpress.ExpressApp.Win.Editors;

namespace WinSolution.Module.Win {
    public class RichEditPropertyEditor : WinPropertyEditor {
        public RichEditPropertyEditor(Type objectType, DevExpress.ExpressApp.DictionaryNode info)
            : base(objectType, info) {
            ControlBindingProperty = "RtfText";
        }
        private RichEditUserControl richEditUserControlCore = null;
        public RichEditUserControl RichEditUserControl {
            get {
                return richEditUserControlCore;
            }
        }
        protected override object CreateControlCore() {
            richEditUserControlCore = new RichEditUserControl();
            richEditUserControlCore.RichEditControl.ReadOnly = ReadOnly;
            return richEditUserControlCore;
        }
        protected override void OnReadOnlyChanged() {
            base.OnReadOnlyChanged();
            if (RichEditUserControl != null) {
                RichEditUserControl.RichEditControl.ReadOnly = ReadOnly;
            }
        }
    }
}
