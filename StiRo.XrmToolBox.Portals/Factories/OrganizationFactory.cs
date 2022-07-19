using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class OrganizationFactory
    {
        public static Organization GetOrganization(IOrganizationService service) {
            QueryExpression organizationsQuery = new QueryExpression("organization")
            {
                ColumnSet = new ColumnSet("blockedattachments", "maxuploadfilesize")
            };

            return service.RetrieveMultiple(organizationsQuery).Entities.Select(e => new Organization
            {
                Id = e.Id,
                BlockedAttachments = e.GetAttributeValue<string>("blockedattachments")?.Split(';'),
                MaxUploadFileSize = e.GetAttributeValue<int>("maxuploadfilesize")
            }).FirstOrDefault();
        } 
    }
}
