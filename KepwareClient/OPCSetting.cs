using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KepwareClient
{
    public class OPCSettings
    {
        public string OPCURL { get; set; }
        public int TimeOut { get; set; }
        public int port { get; set; }
        public OPCSettings()
        {
            String line;
            try {
                StreamReader sr = new StreamReader("D:\\OPCSettings.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line != null){ 
                        string[] words = line.Split(':'); 
                        if (String.Compare(words[0], "Address") == 0)
                        {
                            OPCURL = words[1];
                        } else if(words[0] == "TimeOut")
                        {
                            Int32 TimeOutTemp; //Костыль
                            bool success = Int32.TryParse(words[1], out TimeOutTemp);
                            if (success) {
                                TimeOut = TimeOutTemp;
                            }
                        }
                        else if (words[0] == "Port")
                        {
                            Int32 portTemp; //Костыль
                            bool success = Int32.TryParse(words[1], out portTemp);
                            if (success)
                            {
                                port = portTemp;
                            }
                        }
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch(Exception e)
            {
                OPCURL = "127.0.0.1";
                TimeOut = 1000;
                port = 49320;
            }
            finally
            {

            }
            
        }
    }
}
