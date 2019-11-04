using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MonitorService
{
    public static class FileUtil
    {
        public static int FileCount(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    return -1;

                return Directory.GetFiles(path).Length;
            }
            catch (Exception e)
            {
                return -2;
            }
        }



    }
}