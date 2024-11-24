using api.Models;

namespace api.Interfaces
{
    public interface IJobService
    {
        IEnumerable<Job> GetAll();
    }
}
