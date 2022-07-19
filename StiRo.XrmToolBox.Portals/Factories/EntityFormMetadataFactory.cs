using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class EntityFormMetadataFactory
    {
        public static List<EntityFormMetadata> GetEntityFormMetadataFromEntityForm(IOrganizationService service, EntityForm entityForm)
        {
            QueryExpression entityFormsQuery = new QueryExpression("adx_entityformmetadata")
            {
                ColumnSet = new ColumnSet(true),
                Criteria = {
                    Conditions = {
                        new ConditionExpression("adx_entityform", ConditionOperator.Equal, entityForm.Id)
                    }
                },
                Orders = {
                    new OrderExpression("adx_attributelogicalname", OrderType.Ascending)
                }
            };

            return service.RetrieveMultiple(entityFormsQuery).Entities.Select(e => new EntityFormMetadata
            {
                Id = e.Id,
                Entity = e
            }).ToList();
        }
    }
}
