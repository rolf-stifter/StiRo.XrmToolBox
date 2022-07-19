using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class Organization : CRMEntity
    {
        public string[] BlockedAttachments { get; set; }
        public int MaxUploadFileSize { get; set; }
    }
}
