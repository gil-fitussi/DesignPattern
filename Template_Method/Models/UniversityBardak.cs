using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method.Models
{
    public class UniversityBardak : CourseRegistration
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Process CC Payment..");
        }

        protected override void SendNotification()
        {
            Console.WriteLine("Send an letter..");
        }

        protected override void VerifyPrerequisites()
        {
            Console.WriteLine("Validate records..");
        }
    }
}
