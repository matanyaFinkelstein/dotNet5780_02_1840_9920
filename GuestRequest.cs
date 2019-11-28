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

        public string EntryDate_GSet { get { return EntryDate; } set { EntryDate = value; } }
        public string ReleaseDate_GSet { get { return ReleaseDate; } set { ReleaseDate = value; } }
        public bool IsApproved_GSet { get { return IsApproved; } set { IsApproved = value; } }
       
        public override string ToString()
        {
            Console.WriteLine("The entry date: {0}", EntryDate);
            Console.WriteLine("The release date: {0}", ReleaseDate);
            if (IsApproved)
                Console.WriteLine("The request was accepted");
            else
                Console.WriteLine("The request was rejected");
            return null;
        }
    }
}
