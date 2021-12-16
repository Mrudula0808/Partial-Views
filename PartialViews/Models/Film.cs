using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViews.Models
{
    public class Film
    {   
        public Film(string _title, string _duration, string _description)
        {
            Title = _title;
            Duration = _duration;
            Description = _description;
        }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}
