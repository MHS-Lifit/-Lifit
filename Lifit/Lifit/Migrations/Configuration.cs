using Lifit.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Lifit.DAL.Migration
{

    internal sealed class Configuration : DbMigrationsConfiguration<LifitDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LifitDBContext context)
        {
            base.Seed(context);

        }
    }
}
