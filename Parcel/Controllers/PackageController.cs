using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
    public class PackageController : Controller
    {
        [HttpGet("/package/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/package")]
        public ActionResult Index(string newlength, string newwidth, string newheight, string newweight)
        {
            int inputtedLength = int.Parse(newlength);
            int inputtedWidth = int.Parse(newwidth);
            int inputtedHeight = int.Parse(newheight);
            int inputtedWeight = int.Parse(newweight);

            Package newPackage = new Package(inputtedLength, inputtedWidth, inputtedHeight, inputtedHeight);
            newPackage.GetVolume();
            newPackage.GetCost();
            return View(newPackage);
        }

    }
}