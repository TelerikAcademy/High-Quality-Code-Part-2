using log4net;

namespace ProjectManager.Common
{
    public class FileLogger
    {
        private static ILog log;

        static FileLogger()
        {
            log = LogManager.GetLogger(typeof(FileLogger));
        }
        public void info(object msg)
        {
            log.Info(msg);
        }        
        public void error(object msg)
        {
            //log.Error(msg);
        }        
        public void fatal(object msg)
        {
            log.Fatal(msg);
        }
    }
}
