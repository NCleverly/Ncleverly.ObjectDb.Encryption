using Realms;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Street : RealmObject
    {
        public long Number { get; set; }
        public string Name { get; set; }
    }
}
