using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartialViews.Models;

namespace PartialViews.Pages
{
    public class IndexModel : PageModel
    {
        public List<Film> Films; 
        public IndexModel()
        {              
            Films = new List<Film>();
            Films.Add(new Film("Perks of being a wallflower", "1h 43m", "Socially awkward teen Charlie (Logan Lerman) is a wallflower, always watching life from the sidelines, until two charismatic students become his mentors."));
            Films.Add(new Film("Office Space", "1h 23m", "Life in the corporate world becomes fodder for hilariously absurd comedy when three abused co-workers plot revenge against their dehumanizing company."));
            Films.Add(new Film("The Internship", "2h", "After salesmen Billy McMahon and Nick Campbell's employer goes out of business, Billy applies him and Nick for Google internships. They are accepted due to their unorthodox interview answers, despite a lack of relevant experience and being not of traditional collegiate age."));
        }
    }
}
