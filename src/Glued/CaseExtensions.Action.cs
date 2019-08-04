using System;

namespace Glued
{
    public static partial class CaseExtensions
    {
        public static Action<Action<T>> Case<T>(this T t, Func<T, bool> guard, Action<T> action)
        {
            return next => { if (guard(t)) action(t); else next(t); };
        }

        public static Action<Action<T>> Case<T>(this Action<Action<T>> source, Func<T, bool> guard, Action<T> action)
        {
            return next => source(t => { if (guard(t)) action(t); else next(t); });
        }

        public static void Else<T>(this Action<Action<T>> source, Action<T> action)
        {
            source(action);
        }
    }
}