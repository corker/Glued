using System.Threading.Tasks;

namespace Glued.Async
{
    public static class TaskExtensions
    {
        public static Task<TR> AsTask<TR>(this TR @const)
        {
            return Task.FromResult(@const);
        }
    }
}