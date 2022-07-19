using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class PublishingStateFactory
    {
        public static List<PublishingState> GetActivePublishingStatesByWebsite(IOrganizationService service, Website website) {
            QueryExpression publishingStatesQuery = new QueryExpression
            {
                EntityName = "adx_publishingstate",
                ColumnSet = new ColumnSet("adx_publishingstateid", "adx_name"),
                Criteria = {
                    Conditions = {
                        new ConditionExpression("statecode", ConditionOperator.Equal, 0),
                        new ConditionExpression("adx_websiteid", ConditionOperator.Equal, website.Id),
                    }
                },
                Orders = { 
                    new OrderExpression("adx_name", OrderType.Ascending)
                }
            };

            return service.RetrieveMultiple(publishingStatesQuery).Entities.Select(e => new PublishingState
            {
                Id = e.Id,
                Name = e.GetAttributeValue<string>("adx_name")
            }).ToList();
        }
    }
}
