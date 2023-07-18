namespace FreshInkParser
{
    public interface IPrintTestConfigParser
    {
        PrintTestConfig ParsePrintTestConfigs();
        void SerializePrintTestConfigs(PrintTestConfig config);
    }

}
