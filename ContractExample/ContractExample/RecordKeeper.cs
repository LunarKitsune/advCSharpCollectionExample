using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContractExample
{
    class RecordKeeper
    {
        public void FileWriter(ContractorCollection contracts)
        {
            string logFile = "ContractLog.txt";

            using (StreamWriter Writer = File.CreateText(logFile))
            {
                Writer.WriteLine($"{DateTime.Now}\n{"-".PadRight(30, '-')}");
                
                foreach(Contract item in contracts.pulledContracts)
                {
                    Writer.WriteLine($"{item.contractID},{item.contracteeName},{item.contractAmount},{item.contractDate.ToShortDateString()}");
                }
                
            }
        }

        public void FileReader(ContractorCollection contracts)
        {
            string logFile = "ContractLog.txt";
            Contract contractPaper = new Contract();

            if (File.Exists("ContractLog.txt"))
            {
                using(StreamReader Reader = new StreamReader(logFile))
                {
                    string fileLine = Reader.ReadLine();
                    string[] record = fileLine.Split(',');
                    contractPaper.contractID = int.Parse(record[0]);
                    contractPaper.contracteeName = record[1];
                    contractPaper.contractAmount = double.Parse(record[2]);
                    contractPaper.contractDate = DateTime.Parse(record[3]);

                    contracts.AddContract(contractPaper);
                }
            }
        }
    }
}
