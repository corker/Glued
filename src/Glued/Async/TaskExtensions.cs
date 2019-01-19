using System.Threading.Tasks;

namespace Glued.Async
{
    public static class TaskExtensions
    {
        public static Task<T> AsTask<T>(this T source)
        {
            return Task.FromResult(source);
        }
    }
}