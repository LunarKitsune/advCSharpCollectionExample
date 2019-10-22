using System.Collections.Generic;
using System.Linq;

namespace ContractExample
{
    class ContractorCollection
    {
        Dictionary<int, Contract> ContractCollection = new Dictionary<int, Contract>();
        public Dictionary<int,Contract>.ValueCollection pulledContracts
        {
            get { return ContractCollection.Values; }
        }

        public void AddContract(Contract collectorContract)
        {
            ContractCollection.Add(collectorContract.contractID, collectorContract);
        }

        public void RemoveContract(int ID)
        {
            ContractCollection.Remove(ID);
        }

        public double TotalFromContracts()
        {
            double total = 0;
            foreach(Contract contractItem in pulledContracts)
            {
                total += contractItem.contractAmount;
            }

            return total;
        }

        public Contract GetRecord(int ID)
        {
            Contract foundContract;
            if(ContractCollection.ContainsKey(ID))
            {
                foundContract = ContractCollection[ID];
                return foundContract;
            }
            else
            {
                return null;
            }
        }

        public string Over1000()
        {
            string output = "Contracts over $1000";
            output += "Name\t Sales\r\n";

            var foundContracts = from items in pulledContracts
                                 where items.contractAmount > 1000
                                 select new { items.contracteeName, items.contractAmount };

            foreach(var contractPaper in foundContracts)
            {
                output += $"{contractPaper.contracteeName}\t{contractPaper.contracteeName}\r\n";
            }

            return output;
        }

        /// <returns>Returns entire list of all contracts</returns>
        public override string ToString()
        {
            string output = "ID\t\tName\t\tAmount\t\tdate\r\n";
            double total = 0;
            
            foreach(Contract item in pulledContracts)
            {
                output += $"{item.contractID}\t\t{item.contracteeName}\t\t{item.contractDate.ToString()}\t\t{item.contractAmount:C}\n";
                total += item.contractAmount;
            }
            output += $"\nTotal Amount: {total:C}";

            return output;
        }

    }
}
