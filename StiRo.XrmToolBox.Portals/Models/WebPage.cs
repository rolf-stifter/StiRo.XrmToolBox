using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class WebPage : CRMEntity
    {
        public List<WebPage> ChildPages { get; set; }
        public List<WebFile> ChildFiles { get; set; }
    }
}
