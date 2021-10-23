using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bloodhound_Typeahead_JS.Models
{
    public class PostalCodes
    {
        public string Name { get; set; }
        public string Suburb { get; set; }
        public int PostalCode { get; set; }
    }

    public class PostalCodeService
    {
        public List<PostalCodes> GetPostalCodes()
        {
            var PostalCodes = new List<PostalCodes>();

            PostalCodes.Add(new PostalCodes() { Name = "Pietermaritzburg; KwaZulu-Natal", Suburb = "Mpumalanga", PostalCode = 3000 });
            PostalCodes.Add(new PostalCodes() { Name = "Cape Town; Western Cape", Suburb = "Hermanus", PostalCode = 5070 });
            PostalCodes.Add(new PostalCodes() { Name = "Springbok; Northern Cape", Suburb = "Orania", PostalCode = 5044 });

            return PostalCodes;
        }
    }
}
