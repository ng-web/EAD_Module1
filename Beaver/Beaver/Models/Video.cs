using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beaver.Models
{
    public class Video
    {
        //fields in our video database
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Genre genre { get; set; }

        //fields for genre drop-down list
        public enum Genre
        {
            Comedy = 1,
            Horror, 
            Action,
            SciFi,
            Romance,
            Documentary,
            Kids
        }
    }
}