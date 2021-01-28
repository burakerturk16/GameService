using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class RecordManager
    {
        public void Register(Record record , IVerificationService verificationService)
        {
            Console.WriteLine("Registered");
            verificationService.CheckInformation();
        }

        public void Update(Record record)
        {
            Console.WriteLine("Record updated");
        }

        public void Delete(Record record)
        {
            Console.WriteLine("Record deleted");
        }
    }
}
