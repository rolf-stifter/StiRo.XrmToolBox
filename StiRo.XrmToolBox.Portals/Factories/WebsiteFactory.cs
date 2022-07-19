using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class WebsiteFactory
    {
        public static List<Website> GetActiveWebsites(IOrganizationService service) {
            QueryExpression websitesQuery = new QueryExpression()
            {
                EntityName = "adx_website",
                ColumnSet = new ColumnSet("adx_websiteid", "adx_name"),
                Criteria = {
                    Conditions = {
                        new ConditionExpression("statecode", ConditionOperator.Equal, 0)
                    }
                }
            };

            return service.RetrieveMultiple(websitesQuery).Entities.Select(e => new Website
            {
                Id = e.Id,
                Name = e.GetAttributeValue<string>("adx_name")
            }).ToList();
        } 
    }
}
