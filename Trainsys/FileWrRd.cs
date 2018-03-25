using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileManipulation
{
    class FileWrite
    {
        public void WriteData(string str)
        {
            FileStream fs = new FileStream("c:\\gpslog.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }

    class FileRead
    {
        public void ReadData(int sk)
        {
            FileWrite wr = new FileWrite();
            FileStream fs = new FileStream("c:\\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);


            sr.BaseStream.Seek(sk, SeekOrigin.Current);
            string str = sr.ReadLine();
            //Console.WriteLine(str);
            //str = sr.ReadLine();
            wr.WriteData(str);
            sr.Close();
            fs.Close();
        }
    }
    class FilegRead
    {
        public string ReadgData(int sk)
        {
            FileWrite wr = new FileWrite();
            FileStream fs = new FileStream("c:\\gpslog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);


            sr.BaseStream.Seek(sk, SeekOrigin.Current);
            string str = sr.ReadLine();
            //Console.WriteLine(str);
            //str = sr.ReadLine();
            //wr.WriteData(str);
            sr.Close();
            fs.Close();
            return str;
        }
    }

}
