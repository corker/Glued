using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class TaskExtensions
    {
        public static Task<T> AsTask<T>(this T t)
        {
            return Task.FromResult(t);
        }
    }
}