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
        bool Diary;

        public HostingUnit()
        {

        }
        private void setHostingUnitKey(int _HostingUnitKey)
        {
            HostingUnitKey = _HostingUnitKey;
        }
        public int getHostingUnitKey()
        {
            return HostingUnitKey;
        }
        public String ToString()
        {

        }
        public bool ApproveRequest(GuestRequest guestReq)
        {

        }
        public int GetAnnualBusyDays()
        {

        }
        public float GetAnnualBusyPercentage()
        {

        }
    }
}
