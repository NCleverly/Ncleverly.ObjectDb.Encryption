using Realms;
using System;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Login : RealmObject
    {
        public string Uuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
    }
}
