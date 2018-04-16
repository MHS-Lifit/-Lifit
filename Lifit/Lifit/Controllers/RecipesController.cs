using Facebook;
using Newtonsoft.Json.Linq;
using Lifit.DAL;
using Lifit.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Threading;
using System.Security.Cryptography;
using System.Threading.Tasks;

using System.Web.Script.Serialization;
using System.Device.Location;

namespace Lifit.Controllers
{


    public class RecipesController : BaseController
    {

        [Route("Рецепти")]
        [Route("Recipes")]
        public ActionResult Index()
        {
            ViewBag.menu = "recipes";
            return View("Index");

        }


        [HttpGet]
        [Route("добавяне-на-рецепта")]
        public ActionResult RecipesAdd()
        {

            ViewBag.menu = "recipes";
            return View("AddRecipes");

        }


        [HttpPost]
        [Route("добавяне-на-рецепта")]
        public ActionResult RecipesAddPost(IEnumerable<HttpPostedFileBase> UserFiles)
        {
            ViewBag.menu = "recipes";
            using (LifitDBContext dc = new LifitDBContext())
            {
                var name = Request.Form["name"];
                var text = Request.Form["text"];

                var recip = new Recip()
                {
                    Name = name,
                    Text = text
                };

                if (UserFiles != null)
                {

                    if (UserFiles != null && UserFiles.First().ContentLength > 0)
                    {
                        var file = UserFiles.First();
                        var fname = Guid.NewGuid() + "." + file.FileName.Split('.')[1];
                        file.SaveAs(Server.MapPath("~/files/picture/" + name));
                        recip.PictureUrl = "/files/picture/" + name;
                    }

                    dc.SaveChanges();
                }
                dc.Recipes.Add(recip);
                var model = dc.Recipes.ToList();
                return View("RecipesList", model);
            }
        }

        [HttpGet]
        [Route("рецепта/{id}")]
        public ActionResult RecipDetail(int id)
        {
            ViewBag.menu = "recipes";
            using (LifitDBContext dc = new LifitDBContext())
            {
                var model = dc.Recipes.Where(r => r.RecipId == id).SingleOrDefault();
                model.Visits++;
                dc.SaveChanges();

                return View("ReceipDetail", model);
            }
        }

        [Route("рецепти-списък")]
        public ActionResult RecipesList()
        {
            using (LifitDBContext dc = new LifitDBContext())
            {
                var model = dc.Recipes.ToList();
                return View("RecipesList", model);
            }

           

        }

    }
}