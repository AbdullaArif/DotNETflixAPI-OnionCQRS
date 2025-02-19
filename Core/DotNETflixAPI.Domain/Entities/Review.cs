using DotNETflixAPI.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETflixAPI.Domain.Entities
{
   public class Review: BaseEntity
    {
      
        public int UserRating { get; set; }
        public DateTime ReviewDate { get; set; }

        public string ReviewComment { get; set; }

    }
}
