using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method.Models
{
    public class UniversityBalagan : CourseRegistration
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Process Payment..");
        }

        protected override void SendNotification()
        {
            Console.WriteLine("Send an email..");
        }

        protected override void VerifyPrerequisites()
        {
            Console.WriteLine("Validate transcript..");
        }
    }
}
