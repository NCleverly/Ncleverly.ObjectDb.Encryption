using Realms;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class Result : RealmObject
    {
        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }

        //this is made to be the key forease of use here
        [PrimaryKey]
        public string Email { get; set; }
        public Login Login { get; set; }
        public Dob Dob { get; set; }
        public Dob Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public Id Id { get; set; }
        public string Nat { get; set; }
    }
}
