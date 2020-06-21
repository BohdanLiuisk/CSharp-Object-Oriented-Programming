using System;

namespace OpenDocument
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in other formats");
        }
    }
}
