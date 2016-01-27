using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eat.Database
{
    public class EatDatabaseInitializer : DropCreateDatabaseIfModelChanges<EatContext>
    {
        protected override void Seed(EatContext context)
        {
            
        }
    }
}