using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xrm.Sdk;

namespace StiRo.XrmToolBox.Portals.Models
{
    public abstract class CRMEntity
    {
        public string EntityLogicalName { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Entity Entity { get; set; }
    }
}
