using System;

namespace OpenDocument
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document open");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in the Pro version.");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document is available in the Pro version");
        }
    }
}