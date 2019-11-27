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
        public List<HostingUnit> HostUC_GSet { get { return HostingUnitCollection; } private set { HostingUnitCollection = new List<HostingUnit>(value); } }
        public int HostKey;
        private List<HostingUnit> HostingUnitCollection;
        public Host(int _HostKey, int size)
        {
            HostKey = _HostKey;
            HostingUnitCollection = new List<HostingUnit>(size);
            foreach(HostingUnit host_u in HostingUnitCollection)
            host_u.
        }
       
        public List<HostingUnit> GetHostingUnitCollection()
        {
            return HostingUnitCollection;
        }
    }
}