using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETflixAPI.Application.Features.CQRSDP.Results.MovieResults
{
    public class GetMovieByIdQueryResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public float Rating { get; set; }
        public float Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CreateYear { get; set; }
    }
}
