namespace FreshInkParser
{
    public interface IPrintTestConfigParser
    {
        PrintTestConfig GetConfigs();
        void SaveConfigs(PrintTestConfig config);
    }
}
