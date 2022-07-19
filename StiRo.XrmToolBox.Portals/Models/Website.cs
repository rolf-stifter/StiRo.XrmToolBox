using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class Website : CRMEntity
    {
        public WebPage HomePage { get; set; }
        public List<WebPage> WebPages { get; set; } = new List<WebPage>();
        public List<PublishingState> PublishingStates { get; set; } = new List<PublishingState>();
    }
}
