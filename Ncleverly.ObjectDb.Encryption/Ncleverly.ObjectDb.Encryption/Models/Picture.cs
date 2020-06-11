using System;

namespace Ncleverly.ObjectDb.Encryption.Models
{

    public partial class Picture
    {
        public Uri Large { get; set; }
        public Uri Medium { get; set; }
        public Uri Thumbnail { get; set; }
    }
}
