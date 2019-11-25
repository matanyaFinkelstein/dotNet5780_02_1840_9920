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
        bool[,] Diary;
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
            String[] s = guestReq.EntryDate.Split(new char[] { '.', '/' }); // in case we put in the date like this: xx.yy xx/yy
            int day = Convert.ToInt32(s[0]); // the first part was the days
            int month = Convert.ToInt32(s[1]); // the second part was the months

            s = guestReq.ReleaseDate.Split(new char[] { '.', '/' }); // in case we put in the date like this: xx.yy xx/yy
            int day1 = Convert.ToInt32(s[0]); // the first part was the days
            int month1 = Convert.ToInt32(s[1]); // the second part was the months

            int duration = (month1 - month) * 31 + (day1 - day); // there is alot of science in this row!! please take of your shoes!!

            day--; //because the array start from 0 so this is the date minus 1
            month--; //because the array start from 0 so this is the date minus 1

            int days, months;
            for (int i = 0; i < duration; i++) // cheks if all of the days that has been orderd is empty
            {
                days = day + i; // the day in the month
                months = month; // the month in the year
                if (days >= 31) // if we got to the end of the month
                {
                    months += days / 31; // the next month
                    days = days % 31; // the days that left from the next month
                }
                if (Diary[month, day] == true) // if the day is orderd already
                {
                    return false;
                }
            }

            for (int i = 0; i < duration - 1; i++) // puts in all of the days - true
            {
                days = day + i;
                months = month;
                if (days >= 31)
                {
                    months += days / 31;
                    days = days % 31;
                }
                if (months >= 12)
                    months = months % 12;
                Diary[months, days] = true;
            }
            return true;

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