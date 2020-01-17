using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DDA.Models
{
    public class DDAInitializer : DropCreateDatabaseAlways<DDAContext>
    {
        protected override void Seed(DDAContext context)
        {
            base.Seed(context);
        }
    }
}