using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class Annotation: CRMEntity
    {
        public string Subject { get; set; }
        public string FileName { get; set; }
        public string DocumentBody { get; set; }
        public string MimeType { get; set; }
        public CRMEntity Regarding { get; set; }
    }
}
