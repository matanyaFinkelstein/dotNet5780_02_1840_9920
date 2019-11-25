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
        public int HostKey;
        private List<HostingUnit> HostingUnitCollection;
        public Host(int _HostKey, List<HostingUnit> _HostingUnitCollection, int size)
        {
            HostKey = _HostKey;

        }
        private void SetHostingUnitCollection(List<HostingUnit> _HostingUnitCollection)
        {
            HostingUnitCollection = _HostingUnitCollection;
        }
        public List<HostingUnit> GetHostingUnitCollection()
        {
            return HostingUnitCollection;
        }
    }
}