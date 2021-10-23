using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bloodhound_Typeahead_JS.Models;


namespace Bloodhound_Typeahead_JS.Controllers
{
    public class PostalCodesController : Controller
    {
        [HttpGet]
        public  IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult<List<PostalCodes>> GetPostalCodes(string name)
        {
            var PostalCodeService = new PostalCodeService();
            var model = new List<PostalCodes>();
            var list = (from x in PostalCodeService.GetPostalCodes()
                        where x.Suburb.Contains(name)
                        select x
                        ).ToList();

            foreach (var item in list)
            {
                var ps = new PostalCodes
                {
                    Name = item.Name,
                    Suburb = item.Suburb,
                    PostalCode = item.PostalCode
                };
                model.Add(ps);
            }
            return model;
        }
    }
}
