using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }
}