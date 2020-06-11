using Realms;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Coordinates : RealmObject
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
