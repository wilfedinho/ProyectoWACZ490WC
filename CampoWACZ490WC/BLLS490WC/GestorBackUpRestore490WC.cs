using DAL490WC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS490WC
{
    public class GestorBackUpRestore490WC
    {
        public void RealizarBackUp490WC(string rutaBackup490WC)
        {
            BackUpRestoreDAL490WC GestorBURE490WC = new BackUpRestoreDAL490WC();
            GestorBURE490WC.RealizarBackUp490WC(rutaBackup490WC);
        }

        public void RealizarRestore490WC(string rutaRestore490WC)
        {
            BackUpRestoreDAL490WC GestorBURE490WC = new BackUpRestoreDAL490WC();
            GestorBURE490WC.RealizarRestore490WC(rutaRestore490WC);
        }
    }
}
