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

        Host(int _HostKey, int size)
        {
            HostKey = _HostKey;
            HostingUnitCollection = new List<HostingUnit>(size);
            foreach (HostingUnit host_u in HostingUnitCollection)
                for (int i = 0; i < 12; i++)
                    for (int j = 0; j < 31; j++)
                        host_u.Diary_GSet[i, j] = false;
        }
        public void ToString()
        {
            Console.WriteLine("the ID of the host is: {0}", HostKey);
            foreach(HostingUnit host_u in HostingUnitCollection)
            {
                host_u.ToString();
            }
        }
        private long SubmitRequest(GuestRequest guestReq)
        {
            foreach(HostingUnit host_u in HostingUnitCollection)
            {
                if(host_u.ApproveRequest)
                {
                    return host_u.HostingUnitKey_GSet;
                }
            }
        }
    }
}