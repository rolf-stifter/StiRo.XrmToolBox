using System;
using System.Collections.Generic;
using System.Text;

namespace StiRo.XrmToolBox.Portals.Models
{
    public class EntityForm : CRMEntity
    {
        public string EntityName { get; set; }
        public string FormName { get; set; }
        public string TabName { get; set; }
        public Mode Mode { get; set; }
        public List<PortalBuisnessRule> PortalBusinessRules { get; set; }


        public string GetModeLabel() {
            string modeLabel = string.Empty;
            switch (this.Mode) {
                case Mode.Insert: modeLabel = "Insert"; break;
                case Mode.Edit: modeLabel = "Edit"; break;
                case Mode.ReadOnly: modeLabel = "ReadOnly"; break;
            }

            return modeLabel;
        }
    }

    public enum Mode
    {
        Insert = 100000000, Edit = 100000001, ReadOnly = 100000002
    }
}
