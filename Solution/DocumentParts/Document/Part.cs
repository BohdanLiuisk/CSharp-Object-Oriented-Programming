using System;

namespace DocumentParts
{
    abstract class Part
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
