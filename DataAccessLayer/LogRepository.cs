using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LogRepository
    {
        public void ZapisiLog(string poruka)
        {
            string path = @"C:\Users\VK\Desktop\faks\3.semestar\.NET\IMDB\logFile.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(poruka+" - " + DateTime.Now.ToString());
                writer.Close();
            }
        }
    }
}
