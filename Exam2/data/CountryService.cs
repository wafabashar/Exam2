using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.data
{
    public class CountryService:ICountryService
    {

        Emoloyee_Context context;
        public CountryService(Emoloyee_Context _context)
        {
            context = _context;

        }

      public List<Country> loadallcountry()
        {
            List<Country> licountry = context.country.ToList();

            return licountry;

        }

    }
}
