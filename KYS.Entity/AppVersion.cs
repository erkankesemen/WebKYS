using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class AppVersion
    {
        public int Id { get; set; }
        public string? VersionNumber { get; set; }
        public string? DownloadUrl { get; set; }
        public Nullable<DateTime> ReleaseDate { get; set; }
    }
}