using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_02_1840_9920
{
    class GuestRequest
    {
        private string EntryDate;
        private string ReleaseDate;
        private bool IsApproved;
        public GuestRequest()
        {
            EntryDate = null;
            ReleaseDate = null;
            IsApproved = false;
        }
        public void SetEntryDate(string _EntryDate)
        {
            EntryDate = _EntryDate;
        }
        public void SetReleaseDate(string _ReleaseDate)
        {
            ReleaseDate = _ReleaseDate;
        }
        public void SetIsApproved(bool _IsApproved)
        {
            IsApproved = _IsApproved;
        }
        public string GetIsApproved(string EntryDate)
        {
            return EntryDate;
        }
        public string GetReleaseDate(string ReleaseDate)
        {
            return ReleaseDate;
        }
        public bool GetIsApproved(bool IsApproved)
        {
            return IsApproved;
        }
    }
}
