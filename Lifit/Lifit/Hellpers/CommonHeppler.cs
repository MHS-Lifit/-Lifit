using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lifit.DAL;
using Lifit.Models;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Net.Http;

namespace Lifit.Hellpers
{
    public static class CommonHeppler
    {
        private static readonly HttpClient client = new HttpClient();

        public static string ViewString(this ProblemType type)
        {
            string result = "";
            switch (type)
            {
                case ProblemType.Pending:
                    result = "Грешка";
                    break;
                case ProblemType.Delay:
                    result = "Закъснение при полет";
                    break;
                case ProblemType.Cancel:
                    result = "Отменен полет";
                    break;
                default:
                    result = "Отказан достъп до борда";
                    break;
            }

            return result;
        }



    }

}
