namespace FreshInk
{
    internal interface IPrintJob
    {
        void LoadDocument(string fileName);
        void PrintDocumentTo(string printerName);
        void CloseDocument();
    }
}
