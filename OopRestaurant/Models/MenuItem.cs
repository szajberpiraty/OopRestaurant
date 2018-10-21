using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopRestaurant.Models
{
    public class MenuItem
    {
        /// <summary>
        /// Egy elem a menüben
        /// Az id kötelező, elsődleges kulcs
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}