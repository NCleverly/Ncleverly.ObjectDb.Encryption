using Realms;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Name : RealmObject
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
}
