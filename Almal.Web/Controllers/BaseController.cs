using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Almal.Core;
using Almal.Web.Infrastructure.ValidationMessage;

namespace Almal.Web.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        public static ValidateMessage AddMessage(Controller controller, string title, string message, MessageType messageType )
        {
            var toastr = controller.TempData["Toastr"] as ValidateMessageContainer;
            toastr = toastr ?? new ValidateMessageContainer();

            var toastMessage = toastr.AddMessage(title, message, messageType);
            controller.TempData["Toastr"] = toastr;
            return toastMessage;
        }
    }
}