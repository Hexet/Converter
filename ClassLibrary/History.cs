using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ClassLibrary
{
    public interface IHistory
    {
        void WriteToHistory(string data);
        string Content { get; }
        void OpenFile();
    }
    public class History: IHistory
    {
        readonly string writePath = "history.txt";
        public void WriteToHistory(string data)
        {
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(data);
            }
        }

        public string Content
        {
            get {
                if (!File.Exists(writePath))
                {
                    return "File not exist";
                }
                return File.ReadAllText(writePath, System.Text.Encoding.Default);
                }
        }

        public History()
        {
            File.WriteAllText(writePath, string.Empty);
        }
        public void OpenFile()
        {
            if (!File.Exists(writePath))
            {
                return;
            }
            Process proc = Process.Start("notepad.exe", writePath);
            proc.WaitForExit();
            proc.Close();
        }

    }
}
