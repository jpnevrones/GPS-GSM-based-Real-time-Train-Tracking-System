using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringFromating
{
    class GPStringFromating
    {
        public void Gpsplit(string str)
        {
            string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = ""; string s7 = ""; string s8 = ""; string s9 = ""; string s10 = ""; string s11 = ""; string s12 = ""; string s13 = "";
            // Split string on spaces.
            // ... This will separate all the words.
            string[] words = str.Split(',');
            int i = 0;

            foreach (string word in words)
            {
                if (i == 0)
                {
                    s1 = String.Copy(word);

                }
                if (i == 1)
                {
                    s2 = String.Copy(word);

                }
                if (i == 2)
                {
                    s3 = String.Copy(word);
                }
                if (i == 3)
                {
                    s4 = String.Copy(word);
                }
                if (i == 4)
                {
                    s5 = String.Copy(word);
                }
                if (i == 5)
                {
                    s6 = String.Copy(word);
                }
                if (i == 6)
                {
                    s7 = String.Copy(word);
                }
                if (i == 7)
                {
                    s8 = String.Copy(word);
                }
                if (i == 8)
                {
                    s9 = String.Copy(word);
                }
                if (i == 9)
                {
                    s10 = String.Copy(word);
                }
                if (i == 10)
                {
                    s11 = String.Copy(word);
                }
                if (i == 11)
                {
                    s12 = String.Copy(word);
                }
                if (i == 12)
                {
                    s13 = String.Copy(word);
                }

                i++;
            }
            float f_num = float.Parse(s8);
            string hours = s2.Remove(2);
            float f_hours = float.Parse(hours);
            string seconds = s2.Remove(0, 4);
            float f_seconds = float.Parse(seconds);
            string min = s2.Remove(0, 2);
            string min1 = min.Remove(2);
            float f_minutes = float.Parse(min1);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(s8);
            Console.WriteLine(s9);
            Console.WriteLine(s10);
            Console.WriteLine(s11);
            Console.WriteLine(s12);
            Console.WriteLine("Hours=" + f_hours);
            Console.WriteLine("minutes=" + f_minutes);
            Console.WriteLine("seconds=" + f_seconds);
            Console.WriteLine("Speed=" + f_num);

            //to convert lattitude in dd.dddddd format from ddmm.mmmm

            string lat1 = s4.Remove(2);
            float f_lat1 = float.Parse(lat1);
            string lat2 = s4.Remove(0, 2);
            float f_lat2 = float.Parse(lat2);
            double f_latitude = (f_lat1 + (f_lat2 / 60.0));
            String d = "S";
            int n = String.Compare(s5, d);
            if (n == 0)
            {
                f_latitude = f_latitude * (-1);
            }
            Console.WriteLine("latitude=" + f_latitude);


            //to find speed over the ground      

            float f_speed = float.Parse(s8);
            double speed = f_speed * 1.8;
            Console.WriteLine("speed=" + speed);

            //to convert longitude to dd.ddddddd format from dddmm.mmmm

            string lon1 = s6.Remove(3);
            float f_lon1 = float.Parse(lon1);
            string lon2 = s6.Remove(0, 3);
            float f_lon2 = float.Parse(lon2);
            double f_longitude = (f_lon1 + (f_lon2 / 60.0));
            string d2 = "W";
            int n2 = String.Compare(s7, d2);
            if (n2 == 0)
            {
                f_longitude = f_longitude * (-1);
            }

            Console.WriteLine("longitude=" + f_longitude);
            //date   
            string m = ":";
            string date1 = s10.Remove(2);
            Console.WriteLine(date1);
            string date2 = s10.Remove(0, 4);
            Console.WriteLine(date2);
            string date3 = s10.Remove(0, 2);
            string date4 = date3.Remove(2);
            Console.WriteLine(date4);
            //Console.ReadLine();
        }
    }

}