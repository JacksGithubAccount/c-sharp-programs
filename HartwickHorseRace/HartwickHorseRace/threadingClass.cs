using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HartwickHorseRace
{
    class threadingClass
    {
        private Thread horse1;
        private Thread horse2;
        private Thread horse3;
        private Thread horse4;
        private Thread horse5;

        public Thread horse1props
        {
            get { return horse1; }
            set { horse1 = value; }
        }
        public Thread horse2props
        {
            get { return horse2; }
            set { horse2 = value; }
        }
        public Thread horse3props
        {
            get { return horse3; }
            set { horse3 = value; }
        }
        public Thread horse4props
        {
            get { return horse4; }
            set { horse4 = value; }
        }
        public Thread horse5props
        {
            get { return horse5; }
            set { horse5 = value; }
        }

        public void RunCourse()
        {
            Thread thisThread = Thread.CurrentThread;
            int winPoints1 = 0;
            int winPoints2 = 0;
            int winPoints3 = 0;
            int winPoints4 = 0;
            int winPoints5 = 0;
            bool p200check = false;
            bool p400check = false;
            bool p600check = false;
            bool p800check = false;
            
            
            //Random Number generate
            Random rndValue = new Random();

            bool check = false;
            do
            {
                int rndNumber1 = rndValue.Next(1, 9);
                winPoints1 = winPoints1 + rndNumber1;
                int rndNumber2 = rndValue.Next(1, 9);
                winPoints2 = winPoints2 + rndNumber2;
                int rndNumber3 = rndValue.Next(1, 9);
                winPoints3 = winPoints3 + rndNumber3;
                int rndNumber4 = rndValue.Next(1, 9);
                winPoints4 = winPoints4 + rndNumber4;
                int rndNumber5 = rndValue.Next(1, 9);
                winPoints5 = winPoints5 + rndNumber5;

                if (winPoints1 >= 200 || winPoints2 >= 200 || winPoints3 >= 200 || winPoints4 >= 200
                    || winPoints5 >= 200)
                {
                    if (p200check == false)
                    {
                        Console.WriteLine(thisThread.Name + " is in the lead!");
                        p200check = true;
                    }
                }
                if (winPoints1 >= 400 || winPoints2 >= 400 || winPoints3 >= 400 || winPoints4 >= 400
                    || winPoints5 >= 400)
                {
                    if (p400check == false)
                    {
                        Console.WriteLine(thisThread.Name + " is in the lead!");
                        p400check = true;
                    }
                }
                if (winPoints1 >= 600 || winPoints2 >= 600 || winPoints3 >= 600 || winPoints4 >= 600
                    || winPoints5 >= 600)
                {
                    if (p600check == false)
                    {
                        Console.WriteLine(thisThread.Name + " is in the lead!");
                        p600check = true;
                    }
                }
                if (winPoints1 >= 800 || winPoints2 >= 800 || winPoints3 >= 800 || winPoints4 >= 800
                    || winPoints5 >= 800)
                {
                    if (p800check == false)
                    {
                        Console.WriteLine(thisThread.Name + " is in the lead!");
                        p800check = true;
                    }
                }
                if (winPoints1 >= 1000 || winPoints2 >= 1000 || winPoints3 >= 1000 || winPoints4 >= 1000
                    || winPoints5 >= 1000)
                {
                    Console.WriteLine(thisThread.Name + " is the winner!");
                    break;
                }


            } while (check == false);
            //ends
            
        }
    }
}
