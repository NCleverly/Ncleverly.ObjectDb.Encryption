using Realms;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Timezone : RealmObject
    {
        public string Offset { get; set; }
        public string Description { get; set; }
    }
}
