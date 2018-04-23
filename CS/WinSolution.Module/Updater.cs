using System;
using System.IO;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Updating;

namespace WinSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Document doc = new Document(Session);
            doc.Subject = "RichEditAbout.rtf";
            StreamReader rtfStreamReader = new StreamReader(GetType().Assembly.GetManifestResourceStream("WinSolution.Module." + doc.Subject));
            doc.Text = rtfStreamReader.ReadToEnd();
            doc.Save();
        }
    }
}
