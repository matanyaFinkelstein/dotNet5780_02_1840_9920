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
        public string GetEntryDate()
        {
            return EntryDate;
        }
        public string GetReleaseDate()
        {
            return ReleaseDate;
        }
        public bool GetIsApproved()
        {
            return IsApproved;
        }
        public void ToString()
        {
            Console.WriteLine("The entry date: {0}", GetEntryDate());
            Console.WriteLine("The release date: {0}", GetReleaseDate());
            if (GetIsApproved())
                Console.WriteLine("The request was accepted");
            else
                Console.WriteLine("The request was rejected");
        }
    }
}
