using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using System.ComponentModel;

namespace WinSolution.Module {
    [DefaultClassOptions]
    [DefaultProperty("Subject")]
    public class Document : BaseObject {
        public Document(Session session) : base(session) { }
        private string _Subject;
        public string Subject {
            get { return _Subject; }
            set { SetPropertyValue("Subject", ref _Subject, value); }
        }
        private string _Body;
        [Size(SizeAttribute.Unlimited)]
        public string Body {
            get { return _Body; }
            set { SetPropertyValue("Body", ref _Body, value); }
        }
    }
}
