namespace FreshInk
{
    internal interface IPrintJob
    {
        void LoadDocument();
        void PrintDocumentTo(string printerName);
        void CloseDocument();
    }
}
