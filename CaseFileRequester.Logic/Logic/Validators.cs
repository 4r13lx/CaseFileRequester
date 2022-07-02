using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using CaseFileRequester.Entities;

namespace CaseFileRequester.Logic
{
    static class Validators
    {
        public static void ValidateControls(params Gecko.GeckoHtmlElement[] ctrls)
        {
            try
            {
                foreach (Gecko.GeckoHtmlElement ctrl in ctrls)
                    if (ctrl == null)
                        throw new WarningException("No se encontro el control correspondiente para " + ctrl.GetType().Name);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool ValidateUserSettings()
        {
            try
            {
                // Validate user
                if ((CaseFileRequester.Logic.Properties.Settings.Default.Lawers == null) || CaseFileRequester.Logic.Properties.Settings.Default.Lawers.LstLawers == null)
                    return false;
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
