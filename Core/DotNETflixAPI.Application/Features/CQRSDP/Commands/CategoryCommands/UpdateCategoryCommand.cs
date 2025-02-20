using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETflixAPI.Application.Features.CQRSDP.Commands.CategoryCommands
{
  public  class UpdateCategoryCommand
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
