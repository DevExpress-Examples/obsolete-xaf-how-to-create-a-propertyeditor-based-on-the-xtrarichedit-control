using System;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.ExpressApp.Model;

namespace WinSolution.Module.Win {
    public class RichEditPropertyEditor : WinPropertyEditor {
        public RichEditPropertyEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
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
            UpdateReadOnly();
            return richEditUserControlCore;
        }
        protected override void OnAllowEditChanged() {
            base.OnAllowEditChanged();
            UpdateReadOnly();
        }
        private void UpdateReadOnly() {
            if (RichEditUserControl != null && RichEditUserControl.RichEditControl != null) {
                RichEditUserControl.RichEditControl.ReadOnly = !AllowEdit;
            }
        }
    }
}