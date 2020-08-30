using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLoto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LotoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LotoService.svc or LotoService.svc.cs at the Solution Explorer and start debugging.

    public class LotoService : ILotoService
    {
        public bool PrijaviSe(Prijava novaPrijava)
        {
            throw new NotImplementedException();
        }
    }
}
