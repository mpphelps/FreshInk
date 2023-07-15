namespace FreshInk
{
    internal interface IPrintTestConfigParser
    {
        PrintTestConfig ParsePrintTestConfigs();
        void SerializePrintTestConfigs(PrintTestConfig config);
    }

}
