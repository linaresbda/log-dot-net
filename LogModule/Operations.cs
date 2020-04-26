namespace Log
{
    public static class Operatios
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

        }

        public static void Info(string message, string logger)
        {
            string str = $"{logger} - {message}";
            log.Info(str);
        }

        public static void Warning(string message, string logger)
        {
            string str = $"{logger} - {message}";
            log.Warn(str);
        }

        public static void Error(string message, string logger)
        {
            string str = $"{logger} - {message}";
            log.Error(str);
        }

        public static void Fatal(string message, string logger)
        {
            string str = $"{logger} - {message}";
            log.Fatal(str);
        }

        public static void Debug(string message, string logger)
        {
            string str = $"{logger} - {message}";
            log.Debug(str);
        }
    }
}
