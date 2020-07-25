using System;

namespace OpenDocument
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
        }
    }
}