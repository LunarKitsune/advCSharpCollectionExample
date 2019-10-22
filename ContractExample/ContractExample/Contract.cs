using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractExample
{
    class Contract
    {
        public DateTime contractDate;
        public int contractID;
        public string contracteeName;
        public double contractAmount;

        public Contract()
        {

        }

        /// <summary>Contract record</summary>
        /// <param name="date">Date of contract</param>
        /// <param name="ID">Contract ID</param>
        /// <param name="name">Person of contract</param>
        /// <param name="amount">Contract Amount</param>
        public Contract(DateTime date, int ID, string name, double amount)
        {

        }
    }
}
