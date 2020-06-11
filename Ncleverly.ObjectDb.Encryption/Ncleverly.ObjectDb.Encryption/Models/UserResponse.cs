using System.Collections.Generic;

namespace Ncleverly.ObjectDb.Encryption.Models
{
    public partial class UserResponse
    {
        public List<Result> Results { get; set; }
        public Info Info { get; set; }
    }
}
