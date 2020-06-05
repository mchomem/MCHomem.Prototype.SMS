using System;
using System.IO;

namespace MCHomem.Prototype.SMS.Services
{
    public static class TwilioKey
    {
        public static String Read(String key)
        {
            try
            {
                String appPath = String.Format(@"{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "Data");

                if (!Directory.Exists(appPath))
                {
                    throw new Exception("Data directory don't exists. Check the instalation.");
                }

                String fullFilePath = String.Format(@"{0}\{1}", appPath, "Twilio.txt");

                if (!File.Exists(fullFilePath))
                {
                    throw new Exception("File don't exsits. Check the instalation.");
                }

                using (StreamReader sr = new StreamReader(fullFilePath))
                {
                    String line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (key.Equals(line[0].ToString()))
                        {
                            return line.Substring(2, line.Length - 2);
                        }
                    }
                }

                throw new Exception("The value for the requested key could not be found. Check content of file.");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
