using System;
using System.IO;

namespace MCHomem.Prototype.SMS.Services
{
    public static class TwilioKey
    {
        #region Properties

        private static String DefautlFileName
        {
            get { return "Twilio.txt"; }
        }

        private static String DefaultPathApp
        {
            get { return AppDomain.CurrentDomain.BaseDirectory; }
        }

        private static String DefaultFullPath
        {
            get { return String.Format(@"{0}{1}", DefaultPathApp, DefautlFileName); }
        }

        public static Boolean IsExistsFile
        {
            get
            {
                return (File.Exists(DefaultFullPath));
            }
        }

        #endregion

        #region Constructors

        static TwilioKey() {}

        #endregion

        #region Methods

        public static String Read(String key)
        {
            try
            {
                if (!File.Exists(DefaultFullPath))
                {
                    CreateEmptyFile();
                }

                using (StreamReader sr = new StreamReader(DefaultFullPath))
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

        public static void Save(String keyA, String keyB, String keyC)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(DefaultFullPath))
                {
                    sw.WriteLine("A={0}", keyA);
                    sw.WriteLine("B={0}", keyB);
                    sw.WriteLine("C={0}", keyC);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static void CreateEmptyFile()
        {
            using (StreamWriter sw = new StreamWriter(DefaultFullPath))
            {
                sw.WriteLine("A=");
                sw.WriteLine("B=");
                sw.WriteLine("C=");
            }
        }

        #endregion
    }
}
