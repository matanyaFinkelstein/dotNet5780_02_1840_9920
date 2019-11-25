using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_02_1840_9920
{
    class GuestRequest
    {
        public string EntryDate;
        public string ReleaseDate;
        public bool IsApproved;
        public GuestRequest()
        {
            EntryDate = null;
            ReleaseDate = null;
            IsApproved = false;
        }
        public void ToString()
        {
            Console.WriteLine("The entry date: {0}", EntryDate);
            Console.WriteLine("The release date: {0}", ReleaseDate);
            if (IsApproved)
                Console.WriteLine("The request was accepted");
            else
                Console.WriteLine("The request was rejected");
        }
    }
}
