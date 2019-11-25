using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_02_1840_9920
{
    class HostingUnit
    {
        private static int stSerialKey;
        int HostingUnitKey;
        bool [,]Diary;
        public HostingUnit()
        {
            Diary = new bool[12, 31];
        }
        private void setHostingUnitKey(int _HostingUnitKey)
        {
            HostingUnitKey = _HostingUnitKey;
        }
        public int getHostingUnitKey()
        {
            return HostingUnitKey;
        }
        public void ToString()
        {
             Console.WriteLine("the host unit key: {0}", HostingUnitKey);
           bool firstDay = false;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (Diary[i, j]) // if this day is ordered
                    {
                        if (!firstDay) // if this is the first day of the order
                        {
                            firstDay = true;
                            Console.WriteLine("{0}.{1}", j + 1, i + 1);
                        }
                    }
                    else if (firstDay) // if this is the last day of the order
                    {
                        firstDay = false;
                        Console.WriteLine("{0}.{1}", j + 1, i + 1);
                    }
                }
            }

        }
        public bool ApproveRequest(GuestRequest guestReq)
        {

        }
        public int GetAnnualBusyDays()
        {
            int counter = 0;
            bool flag = false;
            bool flag1 = false;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (Diary[i, j]) // if the day was ordered
                    {
                        counter++;
                        flag = true;
                        if (j == 30) //if we are at the last day of the month
                            flag1 = true;
                    }
                    else if (flag1) //if the previous day was in the previous month and it was ordered
                    {
                        counter++;
                        flag1 = false;
                        flag = false;
                    }
                    else if (flag) //if the previous day was order and this isn't, it mean's this is the last day of the order
                    {
                        flag = false;
                        flag1 = false;
                        counter++;
                    }
                }
            }
            return counter;
        }
        public float GetAnnualBusyPercentage()
        {
            int counter = 0;
            bool flag = false;
            bool flag1 = false;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (Diary[i, j]) // if the day was ordered
                    {
                        counter++;
                        flag = true;
                        if (j == 30) //if we are at the last day of the month
                            flag1 = true;
                    }
                    else if (flag1) //if the previous day was in the previous month and it was ordered
                    {
                        counter++;
                        flag1 = false;
                        flag = false;
                    }
                    else if (flag) //if the previous day was order and this isn't, it mean's this is the last day of the order
                    {
                        flag = false;
                        flag1 = false;
                        counter++;
                    }
                }
            }
            float occupancy = ((float)(100 * counter) / 372); //calculate the percentage of the ordered days from the year
            return occupancy;
        }
    }
}
