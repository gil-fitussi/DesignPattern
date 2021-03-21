using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    public class ProfileSettingsPrototypeRegistry
    {
        private readonly ProfileSettings DefaultProfileSettings;
        private readonly ProfileSettings SecureProfileSettings;

        public ProfileSettingsPrototypeRegistry()
        {
            DefaultProfileSettings = new ProfileSettings()
            {
                HideAge = true,
                HideEmail = true,
                IsPrivate = true
            };

            SecureProfileSettings = new ProfileSettings()
            {
                HideAge = false,
                HideEmail = false,
                IsPrivate = false
            };
        }

        public ProfileSettings CreateDefaultProfileSettings()
        {
            return DefaultProfileSettings.Clone();
        }
        public ProfileSettings CreateSecureProfileSettings()
        {
            return SecureProfileSettings.Clone();
        }
    }
}
