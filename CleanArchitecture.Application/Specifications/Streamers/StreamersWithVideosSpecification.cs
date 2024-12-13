using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Specifications.Streamers
{
    public class StreamersWithVideosSpecification : BaseSpecification<Streamer>
    {
        public StreamersWithVideosSpecification() : base()
        {
            AddInclude(p => p.Videos);
        }

        public StreamersWithVideosSpecification(string url) : base(p => p.Url!.Contains(url))
        {
            AddInclude(p => p.Videos!);
        }
    }
}
