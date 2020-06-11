using Realms;
using System;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Dob : RealmObject
    {
        public DateTimeOffset Date { get; set; }
        public long Age { get; set; }
    }
}
