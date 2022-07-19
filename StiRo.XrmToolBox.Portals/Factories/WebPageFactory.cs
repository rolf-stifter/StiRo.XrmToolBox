using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class WebPageFactory
    {
        public static List<WebPage> GetActiveWebPagesByWebsite(IOrganizationService service, Website website) {
            QueryExpression webPagesQuery = new QueryExpression
            {
                EntityName = "adx_webpage",
                ColumnSet = new ColumnSet("adx_webpageid", "adx_name"),
                Criteria = {
                    Conditions = {
                        new ConditionExpression("statecode", ConditionOperator.Equal, 0),
                        new ConditionExpression("adx_websiteid", ConditionOperator.Equal, website.Id),
                        new ConditionExpression("adx_isroot", ConditionOperator.Equal, true)
                    }
                },
                Orders = { 
                    new OrderExpression("adx_name", OrderType.Ascending)
                }
            };

            return service.RetrieveMultiple(webPagesQuery).Entities.Select(e => new WebPage
            {
                Id = e.Id,
                Name = e.GetAttributeValue<string>("adx_name")
            }).ToList();
        }
    }
}
