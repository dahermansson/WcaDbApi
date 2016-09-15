using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class ImportedFiles
    {
        public int Id { get; set; }
        public DateTime Imported { get; set; }
        public string WcaFileName { get; set; }
    }
}
