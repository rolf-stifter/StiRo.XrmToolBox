﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace StiRo.XrmToolBox.Portals.EasyWebFileTransporter
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Portal - Easy Web File Transporter"),
        ExportMetadata("Description", "Easily transport web files accross environments."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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b2JlLmNvbS90aWZmLzEuMC8iCiAgICB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iCiAgIHhtcE1NOkRvY3VtZW50SUQ9ImdpbXA6ZG9jaWQ6Z2ltcDpjY2Y3N2IyYi1hMGMyLTRmZTMtYjU2ZC03ZGUxY2NkMDUxMmIiCiAgIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6NzczYmRmYjUtYTZmZi00YmRhLTk1YTgtY2I2ZTAzNWE1YjNlIgogICB4bXBNTTpPcmlnaW5hbERvY3VtZW50SUQ9InhtcC5kaWQ6ODk3OTk0OGQtMDRjMy00Y2FiLWFiZmItNjJhODFhMDViOGE1IgogICBkYzpGb3JtYXQ9ImltYWdlL3BuZyIKICAgR0lNUDpBUEk9IjIuMCIKICAgR0lNUDpQbGF0Zm9ybT0iV2luZG93cyIKICAgR0lNUDpUaW1lU3RhbXA9IjE2NDk4MzA0NDYyMDg4MzUiCiAgIEdJTVA6VmVyc2lvbj0iMi4xMC4zMCIKICAgdGlmZjpPcmllbnRhdGlvbj0iMSIKICAgeG1wOkNyZWF0b3JUb29sPSJHSU1QIDIuMTAiPgogICA8eG1wTU06SGlzdG9yeT4KICAgIDxyZGY6U2VxPgogICAgIDxyZGY6bGkKICAgICAgc3RFdnQ6YWN0aW9uPSJzYXZlZCIKICAgICAgc3RFdnQ6Y2hhbmdlZD0iLyIKICAgICAgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDpmMTE4Yzc3Yi1kODRhLTQxMTItOWE1Mi0xYzJlN2JiNjZlODYiCiAgICAgIHN0RXZ0OnNvZnR3YXJlQWdlbnQ9IkdpbXAgMi4xMCAoV2luZG93cykiCiAgICAgIHN0RXZ0OndoZW49IjIwMjItMDQtMTNUMDg6MTQ6MDYiLz4KICAgIDwvcmRmOlNlcT4KICAgPC94bXBNTTpIaXN0b3J5PgogIDwvcmRmOkRlc2NyaXB0aW9uPgogPC9yZGY6UkRGPgo8L3g6eG1wbWV0YT4KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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aHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIKICAgIHhtbG5zOnN0RXZ0PSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvc1R5cGUvUmVzb3VyY2VFdmVudCMiCiAgICB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iCiAgICB4bWxuczpHSU1QPSJodHRwOi8vd3d3LmdpbXAub3JnL3htcC8iCiAgICB4bWxuczp0aWZmPSJodHRwOi8vbnMuYWRvYmUuY29tL3RpZmYvMS4wLyIKICAgIHhtbG5zOnhtcD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLyIKICAgeG1wTU06RG9jdW1lbnRJRD0iZ2ltcDpkb2NpZDpnaW1wOjk0YmMyNDYyLTZlMWYtNGE1MC05ZWYwLWQzMjU4NDU5YmYwNiIKICAgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDpjNTlmZmJlMC1lOWM3LTRjMDgtYTNjZC1lOTBlNWIwZWE3ODYiCiAgIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDpkYzJiMWFhMS0wOTEzLTRlNGQtODE0Mi0wOTI3ZWZkMjgwM2EiCiAgIGRjOkZvcm1hdD0iaW1hZ2UvcG5nIgogICBHSU1QOkFQST0iMi4wIgogICBHSU1QOlBsYXRmb3JtPSJXaW5kb3dzIgogICBHSU1QOlRpbWVTdGFtcD0iMTY0OTgzMDQyNTYwNzc0MSIKICAgR0lNUDpWZXJzaW9uPSIyLjEwLjMwIgogICB0aWZmOk9yaWVudGF0aW9uPSIxIgogICB4bXA6Q3JlYXRvclRvb2w9IkdJTVAgMi4xMCI+CiAgIDx4bXBNTTpIaXN0b3J5PgogICAgPHJkZjpTZXE+CiAgICAgPHJkZjpsaQogICAgICBzdEV2dDphY3Rpb249InNhdmVkIgogICAgICBzdEV2dDpjaGFuZ2VkPSIvIgogICAgICBzdEV2dDppbnN0YW5jZUlEPSJ4bXAuaWlkOjExZmE5MjQ0LTA0ZmUtNDdkMS1hOTg5LWY1NzgzZjllMGJjNCIKICAgICAgc3RFdnQ6c29mdHdhcmVBZ2VudD0iR2ltcCAyLjEwIChXaW5kb3dzKSIKICAgICAgc3RFdnQ6d2hlbj0iMjAyMi0wNC0xM1QwODoxMzo0NSIvPgogICAgPC9yZGY6U2VxPgogICA8L3htcE1NOkhpc3Rvcnk+CiAgPC9yZGY6RGVzY3JpcHRpb24+CiA8L3JkZjpSREY+CjwveDp4bXBtZXRhPgogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgCjw/eHBhY2tldCBlbmQ9InciPz52F57bAAAABmJLR0QA/wD/AP+gvaeTAAAACXBIWXMAAA9hAAAPYQGoP6dpAAAAB3RJTUUH5gQNBg0t/99yqAAACgpJREFUeNrtnXlUlOUexz+zygwIyJLI4nY9uZK5lCBBhlmeXDuWhlopejPtplanMspOnQS8md7KOt1raEcjLLVOdcslpUUWDQmhhIsgiIA6ww4NDMs0c/9gLNF5ZwGGdb7/8T7P+8w7H37P81vmmWdEWKkoF4Un8AAQBkwERgBe9A1VABeBLOAkcDhGo6205kaRFeDuAFYDSwEX+oc0QAIQF6PRnmkXwCgXhTfwPLARkNE/1QK8DWyL0WjLTXWQCMCbAbwLLBfq008kAUKAyaFyWXFSs67IIsAoF8VCYCsQjEPXNBKYFCqXqZKadbmCAI2Wt9XoJBxqKx9gbKhclnu9JUpuWPPedVieRYgBoXLZkaRmXQOA+LrG54GZDkYWNdPI6i8vbAxVUvqxt22Pdw6J0WjPXLPA1Q54NklmZIbImGEU9aMguTOD7eFiY3rmgGe7XIAHxMbc1qH2KUxqKubzmv8g4evWddqriEQiqlVqqtUq8o4dozbxO/vEGEsiGB4UjIfvENw9vRBLOi+JMhgMfBJ+942XJ0qNVZU2cvP3Z2JIiH3+Z2vXUnblCudSU0nduRNtxpkODec1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"),
        ExportMetadata("BackgroundColor", "#7A0C09"),
        ExportMetadata("PrimaryFontColor", "White"),
        ExportMetadata("SecondaryFontColor", "White")]
    public class EasyWebFileTransporterPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new EasyWebFileTransporterPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public EasyWebFileTransporterPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}