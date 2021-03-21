using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    public class Profile
    {
        private DateTime DateOfBirth;
        private ProfileSettings Settings;

        public Profile()
        {
            Settings = new ProfileSettings();
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public int Age => CalculateAge();

        public bool IsPrivate
        {
            get => Settings.IsPrivate;
            set => Settings.IsPrivate = value;
        }

        public bool HideEmail
        {
            get => Settings.HideEmail;
            set => Settings.HideEmail = value;
        }

        public bool HideAge
        {
            get => Settings.HideAge;
            set => Settings.HideAge = value;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public void SetSettings(ProfileSettings settings)
        { 
            Settings = settings; 
        }

        private int CalculateAge()
        {
            double ageInDays = TimeSpan.FromTicks(DateTime.Now.Ticks).TotalDays - TimeSpan.FromTicks(DateOfBirth.Ticks).TotalDays;
            return (int)ageInDays / 365;
        }

        // Deep Clone
        public Profile Clone()
        {
            return new Profile()
            {
                Name = Name,
                Email = Email,
                DateOfBirth = DateOfBirth,
                Settings = Settings.Clone()
            };
        }
    }
}
