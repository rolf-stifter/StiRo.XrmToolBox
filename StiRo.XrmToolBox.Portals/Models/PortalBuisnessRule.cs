using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class PortalBuisnessRule : CRMEntity
    {
        public EntityReference EntityFormId { get; set; }
        public List<PortalBuisnessRuleCondition> PortalBuisnessRuleConditions { get; set; }
        public List<PortalBuisnessRuleAction> PortalBuisnessRuleActions { get; set; }
    }
}
