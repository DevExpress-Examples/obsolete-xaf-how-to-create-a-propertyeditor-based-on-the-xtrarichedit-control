using System;
using System.IO;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;

namespace WinSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.FindObject<Document>(new BinaryOperator("Subject", "RichEditAbout.rtf")) == null) {
                Document doc = ObjectSpace.CreateObject<Document>();
                doc.Subject = "RichEditAbout.rtf";
                StreamReader rtfStreamReader = new StreamReader(GetType().Assembly.GetManifestResourceStream("WinSolution.Module." + doc.Subject));
                doc.Text = rtfStreamReader.ReadToEnd();
                doc.Save();
            }
        }
    }
}
