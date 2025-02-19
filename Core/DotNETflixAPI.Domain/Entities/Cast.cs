using DotNETflixAPI.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETflixAPI.Domain.Entities
{
   public class Cast:BaseEntity
    {
        
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Overview { get; set; }
        public string Biography { get; set; }





    }
}
