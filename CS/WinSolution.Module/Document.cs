using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using System.ComponentModel;

namespace WinSolution.Module {
    [DefaultClassOptions]
    [DefaultProperty("Subject")]
    public class Document : Note {
        internal Document(Session session) : base(session) { }
        private string _Subject;
        public string Subject {
            get { return _Subject; }
            set { SetPropertyValue("Subject", ref _Subject, value); }
        }
    }
}
