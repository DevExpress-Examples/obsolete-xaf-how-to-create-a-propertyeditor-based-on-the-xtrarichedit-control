using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace WinSolution.Module.Win {
    public partial class RichEditUserControl : XtraUserControl {
        public RichEditUserControl() {
            InitializeComponent();
        }
        public RichEditControl RichEditControl {
            get {
                return this.richEditControl;
            }
        }
        public RibbonControl RibbonControl {
            get {
                return this.ribbonControl1;
            }
        }
        public string RtfText {
            get {
                return richEditControl.RtfText;
            }

            set {
                richEditControl.RtfText = value;
            }
        }
    }
}