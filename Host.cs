using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace dotNet5780_02_1840_9920
{
    class Host
    {
        private int HostKey;
        private List<HostingUnit> HostingUnitCollection;

        public int HostKey_GSet { get { return HostKey; } set { HostKey = value; } }
        public List<HostingUnit> HostingUnitCollection_GSet { get { return HostingUnitCollection; } private set { HostingUnitCollection = new List<HostingUnit>(value); } }

        Host(int _HostKey, int size) // constractor
        {
            HostKey = _HostKey; 
            HostingUnitCollection = new List<HostingUnit>(size);
            foreach (HostingUnit host_u in HostingUnitCollection) // to initialize all of the HostingUnits with false
                for (int i = 0; i < 12; i++)
                    for (int j = 0; j < 31; j++)
                        host_u.Diary_GSet[i, j] = false;
        }
        public override string ToString()
        {
            Console.WriteLine("the ID of the host is: {0}", HostKey);
            foreach (HostingUnit host_u in HostingUnitCollection)
            {
                host_u.ToString();
            }
            return null;
        }
        private long SubmitRequest(GuestRequest guestReq)
        {
            foreach (HostingUnit host_u in HostingUnitCollection) 
            {
                if (host_u.ApproveRequest(guestReq)) // if the request had accepted
                {
                    return host_u.HostingUnitKey_GSet; // return the key of the HostingUnit that accepted the request
                }
            }
            return -1; // if none of the HostingUnit accepted the request return -1
        }
        public int GetHostAnnualBusyDays()
        {
            int counter = 0;
            foreach (HostingUnit host_u in HostingUnitCollection)
            {
                // add to the counter the number of all of the nights that full in this HostingUnit
                counter += host_u.GetAnnualBusyDays();
            }
            return counter; // return the number of the nights that full in the whole HostingUnitCollection
        }
        public void SortUnits()
        {
            HostingUnitCollection.Sort(); // sort the HostingUnitCollection by the sum of the full nights 
        }
        public bool AssignRequests(params GuestRequest[] guestReq)
        {
            bool res = true;
            foreach (GuestRequest guest_r in guestReq)
            {
                if (SubmitRequest(guest_r) == -1) // if none of the HostingUnits can accept tyhe request
                    res = false;
            }
            return res;
        }

    }
}