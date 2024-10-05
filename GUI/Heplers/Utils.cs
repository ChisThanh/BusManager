using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.Heplers
{
    public class Utils
    {
        public static bool ValidateField(Control control, string value, string errorMessage, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, errorMessage);
                return false;
            }
            errorProvider.SetError(control, "");
            return true;
        }
    }
}
