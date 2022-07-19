using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class EntityFormFactory
    {
        public static List<EntityForm> GetActiveEntityForms(IOrganizationService service) {
            QueryExpression entityFormsQuery = new QueryExpression()
            {
                EntityName = "adx_entityform",
                ColumnSet = new ColumnSet("adx_entityformid", "adx_name", "adx_entityname", "adx_formname", "adx_tabname", "adx_mode"),
                Criteria = {
                    Conditions = {
                        new ConditionExpression("statecode", ConditionOperator.Equal, 0),
                    }
                },
                Orders = {
                    new OrderExpression("adx_name", OrderType.Ascending)
                }
            };

            return service.RetrieveMultiple(entityFormsQuery).Entities.Select(e => new EntityForm
            {
                Id = e.Id,
                Name = e.GetAttributeValue<string>("adx_name"),
                EntityName = e.GetAttributeValue<string>("adx_entityname"),
                FormName = e.GetAttributeValue<string>("adx_formname"),
                TabName = e.GetAttributeValue<string>("adx_tabname"),
                Mode = (Mode)e.GetAttributeValue<OptionSetValue>("adx_mode")?.Value,
            }).ToList();
        }
    }
}
