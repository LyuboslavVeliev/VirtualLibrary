namespace VirtualLibrary.Web.Areas.Administration.Controllers
{
    using VirtualLibrary.Common;
    using VirtualLibrary.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
