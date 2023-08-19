using PersonalSystem.Shared;

namespace PersonalSystem.Services
{
    public class PersonalService : ServiceBase<Personal>
    {
        public PersonalService(ApplicationDbContext context) : base(context) 
        {
            
        }
    }
}
