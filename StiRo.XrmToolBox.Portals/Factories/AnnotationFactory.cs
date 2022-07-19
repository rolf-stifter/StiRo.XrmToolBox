using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Factories
{
    public static class AnnotationFactory
    {
        public static Guid CreateAnnotation(IOrganizationService service, Annotation annotation) {
            Entity annotationE = new Entity("annotation");
            annotationE["subject"] = annotation.Subject;
            annotationE["filename"] = annotation.Subject;
            annotationE["documentbody"] = annotation.DocumentBody;
            annotationE["objectid"] = new EntityReference(annotation.Regarding.EntityLogicalName, annotation.Regarding.Id);
            annotationE["mimetype"] = annotation.MimeType;

            return service.Create(annotationE);
        }
    }
}
