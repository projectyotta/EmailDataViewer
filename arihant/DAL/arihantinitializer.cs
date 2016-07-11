using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using arihant.Models;

namespace arihant.DAL
{
    public class arihantinitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<arihantcontext>
    {
        protected override void Seed(arihantcontext context)
        {
            var mails = new List<mail>      
            {
            new mail{sentemailid="lol@gmail.com",recemailid="haha@gmail.com",rectime= DateTime.Parse("2016, 3, 9"), senttime= DateTime.Parse("2008, 3, 9, 16, 5, 7, 123")},
            new mail{sentemailid="lol@gmail.com",recemailid="haha@gmail.com",rectime= DateTime.Parse("2016, 3, 9"), senttime= DateTime.Parse("2008, 3, 9, 16, 5, 7, 123")},
            new mail{sentemailid="lol@gmail.com",recemailid="haha@gmail.com",rectime= DateTime.Parse("2016, 3, 9"), senttime= DateTime.Parse("2008, 3, 9, 16, 5, 7, 123")},
            new mail{sentemailid="lol@gmail.com",recemailid="haha@gmail.com",rectime= DateTime.Parse("2016, 3, 9"), senttime= DateTime.Parse("2008, 3, 9, 16, 5, 7, 123")}};

    }
}
    }

