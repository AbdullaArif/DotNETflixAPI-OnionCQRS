using DotNETflixAPI.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETflixAPI.Domain.Entities
{
   public class Tag:BaseEntity
    {
        public string Title { get; set; }
    }
}
