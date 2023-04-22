using System;
using System.Collections.Generic;
using System.Text;

namespace ETL_SFC_Model
{
    public class Validation
    {
        public static bool ValidateEMail(string eMail)
        {
            return eMail.Contains('@') && eMail.Contains('.');
        }
    }
}
