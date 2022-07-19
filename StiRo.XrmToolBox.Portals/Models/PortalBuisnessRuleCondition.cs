using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class PortalBuisnessRuleCondition : CRMEntity
    {
        public EntityReference PortalBusinessRule { get; set; }
    }
}
