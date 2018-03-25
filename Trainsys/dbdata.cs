using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileManipulation;
using Speechspeak;
using StringFromating;

namespace Trainsys
{
    class dbdata
    {
        public void gpsdata( int dbsk,int dbgsk)
        {
            //declaration of varibles 

            //int i = ;
            int sk =dbsk ;
            int gsk =dbgsk ;
            string gstr1;
            //declaration of class object

            FileRead rd = new FileRead();
            FilegRead grd = new FilegRead();
            FileWrite wr = new FileWrite();
            GPStringFromating gdata = new GPStringFromating();

            //code to setup gps string updates

            rd.ReadData(sk);
            //sk = sk + 69;

            //reading strings and processing them 

            gstr1 = grd.ReadgData(gsk);
            Console.WriteLine(gstr1);
            //gsk = gsk + 69;
            gdata.Gpsplit(gstr1);

            //creating a wait at output

            Console.ReadLine();
        }
    }
    
}
