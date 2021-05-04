using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeAndCars.Models;

namespace CodeAndCars.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Asset
        public ActionResult Shirts()
        {
            var shirt = new Inventory() {id = 1, name = "code shirt", type = "shirt"};
            return View(shirt);
        }

        public ActionResult edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }
            return Content(String.Format("pageIndx={0}&sortBy={1}", pageIndex, sortBy));
        }
    }


    /* 


Passing Content!
    1. pass into returned View, example: return view(data to pass)
    2. ViewData is a dictionary you can use to pass data wtih key value pairs
    3. viewBag creates a property at runtime. 

ContentResult
Returns a string

FileContentResult
Returns file content
	
FilePathResult
Returns file content
	
FileStreamResult
Returns file content

EmptyResult
Returns nothing

JavaScriptResult
Returns script for execution

JsonResult
Returns JSON formatted data

RedirectToResult
Redirects to the specified URL
	
HttpUnauthorizedResult
Returns 403 HTTP Status code

RedirectToRouteResult
Redirects to different action/different controller action

ViewResult
Received as a response for view engine

PartialViewResult
Received as a response for view engine 
    */
}