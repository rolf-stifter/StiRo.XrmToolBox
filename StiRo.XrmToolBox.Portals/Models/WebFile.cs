using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class WebFile : CRMEntity
    {
        public WebFile()
        {
            EntityLogicalName = "adx_webfile";
        }
        public Website Website { get; set; }
        public WebPage ParentPage { get; set; }
        public string PartialURL { get; set; }
        public PublishingState PublishingState { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
