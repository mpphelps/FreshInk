namespace FreshInk
{
    internal interface IPrintTestConfigParser
    {
        PrintTestConfigs ParsePrintTestConfigs();
        void SerializePrintTestConfigs(PrintTestConfigs config);
    }

}
