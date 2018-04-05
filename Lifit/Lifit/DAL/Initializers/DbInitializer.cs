using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifit.DAL.Initializers
{
	internal class DbInitializer: MigrateDatabaseToLatestVersion<LifitDBContext, Lifit.DAL.Migration.Configuration>
	{
	}
}
