using PersonalSystem.Shared;

namespace PersonalSystem.Services
{
    public class AvdelningService : ServiceBase<Avdelning>
    {
        public AvdelningService(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
