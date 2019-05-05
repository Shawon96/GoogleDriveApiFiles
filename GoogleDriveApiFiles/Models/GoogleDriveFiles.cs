using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleDriveApiFiles.Models
{
    public class GoogleDriveFiles
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public long? Size { set; get; }
        public long? Version { set; get; }
        public DateTime? CreatedTime { set; get; }
        public IList<string> Parents { set; get; }
    }
}