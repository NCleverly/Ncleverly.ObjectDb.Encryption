using Realms;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Info : RealmObject
    {
        public string Seed { get; set; }
        public long Results { get; set; }
        public long Page { get; set; }
        public string Version { get; set; }
    }
}
