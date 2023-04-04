using Singumonety.Data.Security;

namespace Singumonety.Data
{
    public class User : Activable
    {
        public string Name { get; private set; }
        public SecurityPassword Password { get; private set; }
        public SecurityFingerprint Fingerprint { get; private set; }

        public User(string name, SecurityPassword password, SecurityFingerprint fingerprint, bool active)
        {
            Name = name;
            Password = password;
            Fingerprint = fingerprint;
            Active = active;
        }

        public static readonly User Unknown = new(string.Empty, new NoPassword(), new SecurityFingerprint(), true);
    }
}
