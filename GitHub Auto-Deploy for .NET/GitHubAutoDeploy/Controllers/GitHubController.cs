using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubAutoDeploy.Controllers
{
    public class GitHubController : Controller
    {

        /// <summary>
        /// Listener for GitHub Post-Receive services.
        /// </summary>
        /// <param name="args">Arguments that are provided as a Json string by GitHub.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Update(string args)
        {
            var value = Json(args);
            ViewBag.Args = value;
            return View();
        }

    }
}
