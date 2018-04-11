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


    public class ArticlesController : BaseController
    {

        [Route("articles")]
        public ActionResult Index()
        {
            return View("Index");
        }

    }
}