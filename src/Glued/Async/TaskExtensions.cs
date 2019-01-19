using System.Threading.Tasks;

namespace Glued.Async
{
    public static class TaskExtensions
    {
        public static Task<T> AsTask<T>(this T target)
        {
            return Task.FromResult(target);
        }
    }
}