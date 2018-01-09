using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2084FinalF2017.Tests.Controllers
{
    class Class1:interface1

    {
        Country db = new Country();
        public IQueryable<Country> Countries
        {
            get { return db.Albums; }
        }
        public void Delete(Country Country)
        {
            db.Countries.Remove(Country);
            db.SaveChanges();
            
        }
       
}
