using System;

namespace Glued.Sync
{
    public static class ActionAsOptionalExtensions
    {
        public static Action<T> AsOptional<T>(this Action<T> source)
        {
            return source ?? (_ => { });
        }
    }
}