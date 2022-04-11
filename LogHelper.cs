using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Log4NetTest
{
    public class LogHelper
    {
        public static log4net.ILog GetLogger([CallerFilePath]string filename="")
        {
            string name = Path.GetFileNameWithoutExtension(filename);
            return log4net.LogManager.GetLogger(name);
        }
    }
}
