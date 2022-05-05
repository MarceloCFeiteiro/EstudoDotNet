namespace EstudoDotNet.StaticKeywordInCsharp
{
    public static class CommonTask
    {
        public static bool IsEmpty(string value)
        {
            if (value.Length > 0)
                return true;

            return false;
        }

        public static string GetComputerName() => System.Environment.MachineName;    
        
    }
}
