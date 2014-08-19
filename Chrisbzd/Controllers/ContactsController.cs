using Chrisbzd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chrisbzd.Controllers
{
    public class ContactsController : Chrisbzd.Controllers.ControllerBase<Contact>
    {
        public override bool IsNew(object o)
        {
            return o != null && ((Contact)o).ContactID == 0;
        }
    }
}
