using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class WebFileFactory
    {
        public static Guid CreateWebFile(IOrganizationService service, WebFile webFile) {
            Entity webFileE = new Entity("adx_webfile");
            webFileE["adx_name"] = webFile.Name;
            webFileE["adx_websiteid"] = new EntityReference("adx_website", webFile.Website.Id);
            webFileE["adx_parentpageid"] = new EntityReference("adx_webpage", webFile.ParentPage.Id);
            webFileE["adx_partialurl"] = webFile.Name;
            webFileE["adx_publishingstateid"] = new EntityReference("adx_publishingstate", webFile.PublishingState.Id);

            return service.Create(webFileE);
        }
    }
}
