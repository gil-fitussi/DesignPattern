using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method.Models
{
    public abstract class CourseRegistration
    {
        public void RegisterStudent()
        {
            VerifyPrerequisites(); // Step 1
            ProcessPayment(); // Step 2
            SendNotification(); // Step 3
        }

        protected abstract void VerifyPrerequisites();
        protected abstract void ProcessPayment();
        protected abstract void SendNotification();
    }
}
